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

public unsafe static class DxcContainerReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcContainerReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcContainerReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcContainerReflection> thisVtbl, IDxcBlob* pContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcContainerReflection> thisVtbl, ref IDxcBlob pContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pContainerPtr = &pContainer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pContainerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartCount(this ComPtr<IDxcContainerReflection> thisVtbl, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)@this->LpVtbl[4])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPartCount(this ComPtr<IDxcContainerReflection> thisVtbl, ref uint pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)@this->LpVtbl[4])(@this, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[5])(@this, idx, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, ref uint pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[5])(@this, idx, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartContent(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)@this->LpVtbl[6])(@this, idx, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartContent(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, ref IDxcBlob* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)@this->LpVtbl[6])(@this, idx, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFirstPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint kind, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[7])(@this, kind, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFirstPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint kind, ref uint pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[7])(@this, kind, pResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Guid* iid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Guid* iid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, ref Guid iid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, ref Guid iid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl, ComPtr<TI0> pContainer) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((IDxcBlob*) pContainer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IDxcContainerReflection> thisVtbl, Span<IDxcBlob> pContainer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pContainer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPartCount(this ComPtr<IDxcContainerReflection> thisVtbl, Span<uint> pResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPartCount(ref pResult.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Span<uint> pResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPartKind(idx, ref pResult.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPartContent<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPartContent(idx, (IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int FindFirstPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint kind, Span<uint> pResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFirstPartKind(kind, ref pResult.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPartReflection<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->GetPartReflection(idx, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Span<Guid> iid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPartReflection(idx, ref iid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Span<Guid> iid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPartReflection(idx, ref iid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetPartReflection<TI0>(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetPartReflection(idx, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
