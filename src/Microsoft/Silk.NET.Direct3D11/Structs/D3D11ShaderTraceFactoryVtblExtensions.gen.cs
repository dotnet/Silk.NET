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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTrace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ShaderTrace** ppShaderTracePtr = &ppShaderTrace)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDesc, ppShaderTracePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderTraceDesc* pTraceDescPtr = &pTraceDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShader, pTraceDescPtr, ppShaderTrace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Silk.NET.Core.Native.IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, int>)@this->LpVtbl[3])(@this, pShaderPtr, pTraceDesc, ppShaderTrace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, Span<ShaderTraceDesc> pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(pShader, ref pTraceDesc.GetPinnableReference(), ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, Span<ShaderTraceDesc> pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(pShader, ref pTraceDesc.GetPinnableReference(), ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), pTraceDesc, ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), pTraceDesc, ref ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, Span<ShaderTraceDesc> pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), ref pTraceDesc.GetPinnableReference(), ppShaderTrace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderTrace<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, Span<ShaderTraceDesc> pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) where TThis : IComVtbl<ID3D11ShaderTraceFactory>
    {
        var @this = (ID3D11ShaderTraceFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateShaderTrace(ref pShader.GetPinnableReference(), ref pTraceDesc.GetPinnableReference(), ref ppShaderTrace);
    }

}
