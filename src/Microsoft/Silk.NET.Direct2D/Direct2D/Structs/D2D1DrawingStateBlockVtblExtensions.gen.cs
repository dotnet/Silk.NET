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

public unsafe static class D2D1DrawingStateBlockVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1DrawingStateBlock> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1DrawingStateBlock> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, DrawingStateDescription* stateDescription)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[4])(@this, stateDescription);
    }

    /// <summary>To be documented.</summary>
    public static void GetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref DrawingStateDescription stateDescription)
    {
        var @this = thisVtbl.Handle;
        fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[4])(@this, stateDescriptionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* stateDescription)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[5])(@this, stateDescription);
    }

    /// <summary>To be documented.</summary>
    public static void SetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription stateDescription)
    {
        var @this = thisVtbl.Handle;
        fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[5])(@this, stateDescriptionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams*, void>)@this->LpVtbl[6])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)@this->LpVtbl[7])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)@this->LpVtbl[7])(@this, textRenderingParamsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, Span<DrawingStateDescription> stateDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDescription(ref stateDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetDescription(this ComPtr<ID2D1DrawingStateBlock> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DrawingStateDescription> stateDescription)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDescription(in stateDescription.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1DrawingStateBlock> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
