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

public unsafe static class DxcValidatorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, Span<IDxcBlob> pShader, uint Flags, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Validate(ref pShader.GetPinnableReference(), Flags, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, Span<IDxcBlob> pShader, uint Flags, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator>
    {
        var @this = (IDxcValidator*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Validate(ref pShader.GetPinnableReference(), Flags, ref ppResult);
    }

}
