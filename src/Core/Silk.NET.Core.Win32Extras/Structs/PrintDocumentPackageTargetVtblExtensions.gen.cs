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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class PrintDocumentPackageTargetVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPrintDocumentPackageTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPrintDocumentPackageTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, uint* targetCount, Guid** targetTypes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCount, targetTypes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, uint* targetCount, ref Guid* targetTypes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid** targetTypesPtr = &targetTypes)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCount, targetTypesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref uint targetCount, Guid** targetTypes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* targetCountPtr = &targetCount)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCountPtr, targetTypes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref uint targetCount, ref Guid* targetTypes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* targetCountPtr = &targetCount)
        {
            fixed (Guid** targetTypesPtr = &targetTypes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCountPtr, targetTypesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, Guid* riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riid, ppvTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, Guid* riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvTargetPtr = &ppvTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riid, ppvTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, ref Guid riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riidPtr, ppvTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, ref Guid riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvTargetPtr = &ppvTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riidPtr, ppvTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType, Guid* riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidTargetTypePtr = &guidTargetType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riid, ppvTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType, Guid* riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidTargetTypePtr = &guidTargetType)
        {
            fixed (void** ppvTargetPtr = &ppvTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riid, ppvTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType, ref Guid riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidTargetTypePtr = &guidTargetType)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riidPtr, ppvTarget);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType, ref Guid riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidTargetTypePtr = &guidTargetType)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTargetPtr = &ppvTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riidPtr, ppvTargetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Cancel(this ComPtr<IPrintDocumentPackageTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<uint> targetCount, Guid** targetTypes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTargetTypes(ref targetCount.GetPinnableReference(), targetTypes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTargetTypes(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<uint> targetCount, ref Guid* targetTypes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTargetTypes(ref targetCount.GetPinnableReference(), ref targetTypes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvTarget = default;
        return @this->GetPackageTarget(guidTargetType, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, Span<Guid> riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(guidTargetType, ref riid.GetPinnableReference(), ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType, Span<Guid> riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(guidTargetType, ref riid.GetPinnableReference(), ref ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> guidTargetType, Guid* riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(ref guidTargetType.GetPinnableReference(), riid, ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetPackageTarget<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType, out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvTarget = default;
        return @this->GetPackageTarget(ref guidTargetType, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> guidTargetType, Guid* riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(ref guidTargetType.GetPinnableReference(), riid, ref ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> guidTargetType, Span<Guid> riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(ref guidTargetType.GetPinnableReference(), ref riid.GetPinnableReference(), ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPackageTarget(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Span<Guid> guidTargetType, Span<Guid> riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPackageTarget(ref guidTargetType.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetPackageTarget<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, Guid* guidTargetType) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetPackageTarget(guidTargetType, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetPackageTarget<TI0>(this ComPtr<IPrintDocumentPackageTarget> thisVtbl, ref Guid guidTargetType) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetPackageTarget(ref guidTargetType, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
