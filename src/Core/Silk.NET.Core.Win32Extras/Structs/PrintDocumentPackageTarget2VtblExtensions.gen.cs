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

public unsafe static class PrintDocumentPackageTarget2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIsTargetIppPrinter(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, int* isIppPrinter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, int*, int>)@this->LpVtbl[3])(@this, isIppPrinter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetIsTargetIppPrinter(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, ref int isIppPrinter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isIppPrinterPtr = &isIppPrinter)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, int*, int>)@this->LpVtbl[3])(@this, isIppPrinterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Guid* riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Guid* riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvTargetPtr = &ppvTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, ref Guid riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, ref Guid riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvTargetPtr = &ppvTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetIsTargetIppPrinter(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Span<int> isIppPrinter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetIsTargetIppPrinter(ref isIppPrinter.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetIppPrintDevice<TI0>(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvTarget = default;
        return @this->GetTargetIppPrintDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Span<Guid> riid, void** ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTargetIppPrintDevice(ref riid.GetPinnableReference(), ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetIppPrintDevice(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl, Span<Guid> riid, ref void* ppvTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTargetIppPrintDevice(ref riid.GetPinnableReference(), ref ppvTarget);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetTargetIppPrintDevice<TI0>(this ComPtr<IPrintDocumentPackageTarget2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetTargetIppPrintDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
