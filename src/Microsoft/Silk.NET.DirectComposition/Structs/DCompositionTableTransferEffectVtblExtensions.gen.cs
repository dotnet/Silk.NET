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

public unsafe static class DCompositionTableTransferEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionTableTransferEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionTableTransferEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRedTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[4])(@this, tableValues, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* tableValuesPtr = &tableValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[4])(@this, tableValuesPtr, count);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGreenTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[5])(@this, tableValues, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* tableValuesPtr = &tableValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[5])(@this, tableValuesPtr, count);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBlueTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[6])(@this, tableValues, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* tableValuesPtr = &tableValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[6])(@this, tableValuesPtr, count);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetAlphaTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[7])(@this, tableValues, count);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* tableValuesPtr = &tableValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, float*, uint, int>)@this->LpVtbl[7])(@this, tableValuesPtr, count);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedDisable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Silk.NET.Core.Bool32 redDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, redDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenDisable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Silk.NET.Core.Bool32 greenDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, greenDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueDisable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Silk.NET.Core.Bool32 blueDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, blueDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaDisable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Silk.NET.Core.Bool32 alphaDisable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, alphaDisable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClampOutput(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Silk.NET.Core.Bool32 clampOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[12])(@this, clampOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRedTableValue(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[14])(@this, index, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenTableValue(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[16])(@this, index, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueTableValue(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[18])(@this, index, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaTableValue(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTableTransferEffect*, uint, float, int>)@this->LpVtbl[20])(@this, index, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput<TI0>(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, uint index, Span<Silk.NET.Core.Native.IUnknown> input, uint flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInput(index, ref input.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetRedTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetRedTable(in tableValues.GetPinnableReference(), count);
    }

    /// <summary>To be documented.</summary>
    public static int SetGreenTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetGreenTable(in tableValues.GetPinnableReference(), count);
    }

    /// <summary>To be documented.</summary>
    public static int SetBlueTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBlueTable(in tableValues.GetPinnableReference(), count);
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaTable(this ComPtr<IDCompositionTableTransferEffect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tableValues, uint count)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetAlphaTable(in tableValues.GetPinnableReference(), count);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionTableTransferEffect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
