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

public unsafe static class DxcResultVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatus<TThis>(this TThis thisVtbl, int* pStatus) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, int*, int>)@this->LpVtbl[3])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStatus<TThis>(this TThis thisVtbl, ref int pStatus) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResult<TThis>(this TThis thisVtbl, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResult<TThis>(this TThis thisVtbl, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetErrorBuffer<TThis>(this TThis thisVtbl, IDxcBlobEncoding** ppErrors) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrors);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetErrorBuffer<TThis>(this TThis thisVtbl, ref IDxcBlobEncoding* ppErrors) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** ppErrorsPtr = &ppErrors)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrorsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HasOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, int>)@this->LpVtbl[6])(@this, dxcOutKind);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObject, ppOutputName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Guid* iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObject, ppOutputNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Guid* iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObjectPtr, ppOutputName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObjectPtr, ppOutputNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, void** ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObject, ppOutputName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObject, ppOutputNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObjectPtr, ppOutputName);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObjectPtr, ppOutputNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumOutputs<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OutKind GetOutputByIndex<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        OutKind ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint, OutKind>)@this->LpVtbl[9])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OutKind PrimaryOutput<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        OutKind ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, OutKind>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetStatus<TThis>(this TThis thisVtbl, Span<int> pStatus) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStatus(ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetResult<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetResult((IDxcBlob**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetErrorBuffer<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppErrors) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetErrorBuffer((IDxcBlobEncoding**) ppErrors.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(dxcOutKind, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref ComPtr<TI0> ppvObject, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(dxcOutKind, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, OutKind dxcOutKind, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(dxcOutKind, iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Span<Guid> iid, void** ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(dxcOutKind, ref iid.GetPinnableReference(), ppvObject, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(dxcOutKind, ref iid, ppvObject, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Span<Guid> iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(dxcOutKind, ref iid.GetPinnableReference(), ppvObject, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Span<Guid> iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(dxcOutKind, ref iid.GetPinnableReference(), ref ppvObject, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(dxcOutKind, ref iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, OutKind dxcOutKind, Span<Guid> iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcResult>
    {
        var @this = (IDxcResult*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(dxcOutKind, ref iid.GetPinnableReference(), ref ppvObject, ref ppOutputName);
    }

}
