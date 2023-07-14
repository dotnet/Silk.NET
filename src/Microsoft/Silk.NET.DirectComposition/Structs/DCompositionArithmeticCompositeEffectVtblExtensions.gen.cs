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

public unsafe static class DCompositionArithmeticCompositeEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCoefficients(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Silk.NET.Maths.Vector4D<float>* coefficients)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[4])(@this, coefficients);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficients(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, ref Silk.NET.Maths.Vector4D<float> coefficients)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<float>* coefficientsPtr = &coefficients)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Maths.Vector4D<float>*, int>)@this->LpVtbl[4])(@this, coefficientsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClampOutput(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Silk.NET.Core.Bool32 clampoutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, clampoutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficient1(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, float Coeffcient1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[7])(@this, Coeffcient1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficient2(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, float Coefficient2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[9])(@this, Coefficient2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficient3(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, float Coefficient3)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[11])(@this, Coefficient3);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficient4(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, float Coefficient4)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)@this->LpVtbl[13])(@this, Coefficient4);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput<TI0>(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, uint index, Span<Silk.NET.Core.Native.IUnknown> input, uint flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInput(index, ref input.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetCoefficients(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl, Span<Silk.NET.Maths.Vector4D<float>> coefficients)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCoefficients(ref coefficients.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionArithmeticCompositeEffect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
