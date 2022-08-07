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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum<TThis>(this TThis thisVtbl, uint* quantumNumerator, uint* quantumDenominator) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum<TThis>(this TThis thisVtbl, uint* quantumNumerator, ref uint quantumDenominator) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        fixed (uint* quantumDenominatorPtr = &quantumDenominator)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessingQuantum<TThis>(this TThis thisVtbl, ref uint quantumNumerator, uint* quantumDenominator) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        fixed (uint* quantumNumeratorPtr = &quantumNumerator)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessingQuantum<TThis>(this TThis thisVtbl, ref uint quantumNumerator, ref uint quantumDenominator) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        fixed (uint* quantumNumeratorPtr = &quantumNumerator)
        {
            fixed (uint* quantumDenominatorPtr = &quantumDenominator)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)@this->LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetProcessor<TThis>(this TThis thisVtbl, uint* processor) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processor);
    }

    /// <summary>To be documented.</summary>
    public static void GetProcessor<TThis>(this TThis thisVtbl, ref uint processor) where TThis : IComVtbl<IXAudio2Extension>
    {
        var @this = (IXAudio2Extension*) thisVtbl.AsVtblPtr();
        fixed (uint* processorPtr = &processor)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)@this->LpVtbl[4])(@this, processorPtr);
        }
    }

}
