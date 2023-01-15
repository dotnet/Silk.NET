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

public unsafe static class DxcValidator2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcValidator2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcValidator2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcValidator2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcValidator2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Validate<TI0, TI1>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Validate((IDxcBlob*) pShader.Handle, Flags, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Validate((IDxcBlob*) pShader.Handle, Flags, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Validate(ref pShader.GetPinnableReference(), Flags, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int Validate<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Validate(ref pShader, Flags, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Validate(ref pShader.GetPinnableReference(), Flags, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TI0, TI1>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, Buffer* pOptDebugBitcode, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, pOptDebugBitcode, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, Span<Buffer> pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(pShader, Flags, ref pOptDebugBitcode.GetPinnableReference(), ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int ValidateWithDebug<TI0, TI1>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, ref Buffer pOptDebugBitcode, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, ref pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, IDxcBlob* pShader, uint Flags, Span<Buffer> pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(pShader, Flags, ref pOptDebugBitcode.GetPinnableReference(), ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ComPtr<TI0> pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, ref pOptDebugBitcode, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(ref pShader.GetPinnableReference(), Flags, pOptDebugBitcode, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug(ref pShader, Flags, pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(ref pShader.GetPinnableReference(), Flags, pOptDebugBitcode, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, Span<Buffer> pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(ref pShader.GetPinnableReference(), Flags, ref pOptDebugBitcode.GetPinnableReference(), ppResult);
    }

    /// <summary>To be documented.</summary>
    public static int ValidateWithDebug<TI0>(this ComPtr<IDxcValidator2> thisVtbl, ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateWithDebug(ref pShader, Flags, ref pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug(this ComPtr<IDxcValidator2> thisVtbl, Span<IDxcBlob> pShader, uint Flags, Span<Buffer> pOptDebugBitcode, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateWithDebug(ref pShader.GetPinnableReference(), Flags, ref pOptDebugBitcode.GetPinnableReference(), ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcValidator2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
