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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcAssemblerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcAssembler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcAssembler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, IDxcBlob* pShader, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, IDxcBlob* pShader, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, ref IDxcBlob pShader, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, ref IDxcBlob pShader, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcAssembler> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcAssembler> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AssembleToContainer<TI0, TI1>(this ComPtr<IDxcAssembler> thisVtbl, ComPtr<TI0> pShader, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AssembleToContainer((IDxcBlob*) pShader.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TI0>(this ComPtr<IDxcAssembler> thisVtbl, ComPtr<TI0> pShader, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AssembleToContainer((IDxcBlob*) pShader.Handle, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, Span<IDxcBlob> pShader, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AssembleToContainer(ref pShader.GetPinnableReference(), ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int AssembleToContainer<TI0>(this ComPtr<IDxcAssembler> thisVtbl, ref IDxcBlob pShader, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AssembleToContainer(ref pShader, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer(this ComPtr<IDxcAssembler> thisVtbl, Span<IDxcBlob> pShader, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AssembleToContainer(ref pShader.GetPinnableReference(), ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcAssembler> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
