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

public unsafe static class DCompositionShadowEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionShadowEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionShadowEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionShadowEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionShadowEffect> thisVtbl, uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStandardDeviation(this ComPtr<IDCompositionShadowEffect> thisVtbl, float amount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[5])(@this, amount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColor(this ComPtr<IDCompositionShadowEffect> thisVtbl, Silk.NET.Maths.Vector4D<float>* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[6])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColor(this ComPtr<IDCompositionShadowEffect> thisVtbl, ref Silk.NET.Maths.Vector4D<float> color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<float>* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[6])(@this, colorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRed(this ComPtr<IDCompositionShadowEffect> thisVtbl, float amount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[8])(@this, amount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreen(this ComPtr<IDCompositionShadowEffect> thisVtbl, float amount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[10])(@this, amount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlue(this ComPtr<IDCompositionShadowEffect> thisVtbl, float amount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[12])(@this, amount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlpha(this ComPtr<IDCompositionShadowEffect> thisVtbl, float amount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)@this->LpVtbl[14])(@this, amount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionShadowEffect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionShadowEffect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput<TI0>(this ComPtr<IDCompositionShadowEffect> thisVtbl, uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionShadowEffect> thisVtbl, uint index, Span<Silk.NET.Core.Native.IUnknown> input, uint flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInput(index, ref input.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetColor(this ComPtr<IDCompositionShadowEffect> thisVtbl, Span<Silk.NET.Maths.Vector4D<float>> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetColor(ref color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionShadowEffect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
