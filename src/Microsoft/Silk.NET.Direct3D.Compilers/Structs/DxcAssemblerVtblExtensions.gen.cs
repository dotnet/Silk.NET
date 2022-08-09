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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, IDxcBlob* pShader, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, IDxcBlob* pShader, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
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
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TI0, TThis>(this TThis thisVtbl, IDxcBlob* pShader, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0> where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->AssembleToContainer(pShader, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pShader, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AssembleToContainer(ref pShader.GetPinnableReference(), ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int AssembleToContainer<TI0, TThis>(this TThis thisVtbl, ref IDxcBlob pShader, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0> where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->AssembleToContainer(ref pShader, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AssembleToContainer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pShader, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AssembleToContainer(ref pShader.GetPinnableReference(), ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcAssembler>
    {
        var @this = (IDxcAssembler*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
