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

public unsafe static class DxcContainerBuilderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcContainerBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcContainerBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcContainerBuilder> thisVtbl, IDxcBlob* pDxilContainerHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pDxilContainerHeader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcContainerBuilder> thisVtbl, ref IDxcBlob pDxilContainerHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pDxilContainerHeaderPtr = &pDxilContainerHeader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pDxilContainerHeaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC, IDxcBlob* pSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)@this->LpVtbl[4])(@this, fourCC, pSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddPart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC, ref IDxcBlob pSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pSourcePtr = &pSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)@this->LpVtbl[4])(@this, fourCC, pSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemovePart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int>)@this->LpVtbl[5])(@this, fourCC);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeContainer(this ComPtr<IDxcContainerBuilder> thisVtbl, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)@this->LpVtbl[6])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeContainer(this ComPtr<IDxcContainerBuilder> thisVtbl, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)@this->LpVtbl[6])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcContainerBuilder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IDxcContainerBuilder> thisVtbl, ComPtr<TI0> pDxilContainerHeader) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((IDxcBlob*) pDxilContainerHeader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcContainerBuilder> thisVtbl, Span<IDxcBlob> pDxilContainerHeader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pDxilContainerHeader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddPart<TI0>(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC, ComPtr<TI0> pSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddPart(fourCC, (IDxcBlob*) pSource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddPart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC, Span<IDxcBlob> pSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddPart(fourCC, ref pSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SerializeContainer<TI0>(this ComPtr<IDxcContainerBuilder> thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeContainer((IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcContainerBuilder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
