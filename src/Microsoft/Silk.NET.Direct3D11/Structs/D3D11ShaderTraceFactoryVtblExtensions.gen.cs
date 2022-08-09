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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ShaderTraceFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTrace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTracePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTrace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
        {
            fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTracePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTrace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTracePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTrace);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
            {
                fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShaderPtr, pTraceDescPtr, ppShaderTracePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TI0, TI1>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ComPtr<TI0> pShader, ShaderTraceDesc* pTraceDesc, ref ComPtr<TI1> ppShaderTrace) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace((Silk.NET.Core.Native.IUnknown*) pShader.Handle, pTraceDesc, (ID3D11ShaderTrace**) ppShaderTrace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ComPtr<TI0> pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace((Silk.NET.Core.Native.IUnknown*) pShader.Handle, pTraceDesc, ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, Span<ShaderTraceDesc> pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(pShader, ref pTraceDesc.GetPinnableReference(), ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static int CreateShaderTrace<TI0, TI1>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ComPtr<TI0> pShader, ref ShaderTraceDesc pTraceDesc, ref ComPtr<TI1> ppShaderTrace) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace((Silk.NET.Core.Native.IUnknown*) pShader.Handle, ref pTraceDesc, (ID3D11ShaderTrace**) ppShaderTrace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, Span<ShaderTraceDesc> pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(pShader, ref pTraceDesc.GetPinnableReference(), ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ComPtr<TI0> pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace((Silk.NET.Core.Native.IUnknown*) pShader.Handle, ref pTraceDesc, ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), pTraceDesc, ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ComPtr<TI0> ppShaderTrace) where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace(ref pShader, pTraceDesc, (ID3D11ShaderTrace**) ppShaderTrace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), pTraceDesc, ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, Span<ShaderTraceDesc> pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), ref pTraceDesc.GetPinnableReference(), ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static int CreateShaderTrace<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ComPtr<TI0> ppShaderTrace) where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateShaderTrace(ref pShader, ref pTraceDesc, (ID3D11ShaderTrace**) ppShaderTrace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, Span<ShaderTraceDesc> pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), ref pTraceDesc.GetPinnableReference(), ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11ShaderTraceFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
