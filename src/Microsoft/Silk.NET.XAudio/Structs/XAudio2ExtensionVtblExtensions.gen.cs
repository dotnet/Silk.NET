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

namespace Silk.NET.XAudio;

public unsafe static class XAudio2ExtensionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IXAudio2Extension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IXAudio2Extension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, uint* quantumNumerator, uint* quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, uint* quantumNumerator, ref uint quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* quantumDenominatorPtr = &quantumDenominator)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, ref uint quantumNumerator, uint* quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* quantumNumeratorPtr = &quantumNumerator)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, ref uint quantumNumerator, ref uint quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* quantumNumeratorPtr = &quantumNumerator)
        {
            fixed (uint* quantumDenominatorPtr = &quantumDenominator)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessor(this ComPtr<IXAudio2Extension> thisVtbl, uint* processor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processor);
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessor(this ComPtr<IXAudio2Extension> thisVtbl, ref uint processor)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* processorPtr = &processor)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IXAudio2Extension> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2Extension> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, uint* quantumNumerator, Span<uint> quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetProcessingQuantum(quantumNumerator, ref quantumDenominator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, Span<uint> quantumNumerator, uint* quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetProcessingQuantum(ref quantumNumerator.GetPinnableReference(), quantumDenominator);
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessingQuantum(this ComPtr<IXAudio2Extension> thisVtbl, Span<uint> quantumNumerator, Span<uint> quantumDenominator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetProcessingQuantum(ref quantumNumerator.GetPinnableReference(), ref quantumDenominator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessor(this ComPtr<IXAudio2Extension> thisVtbl, Span<uint> processor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetProcessor(ref processor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IXAudio2Extension> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
