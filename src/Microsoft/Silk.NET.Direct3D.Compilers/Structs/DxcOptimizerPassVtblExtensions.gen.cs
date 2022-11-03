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

public unsafe static class DxcOptimizerPassVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcOptimizerPass> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcOptimizerPass> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionName(this ComPtr<IDxcOptimizerPass> thisVtbl, char** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionName(this ComPtr<IDxcOptimizerPass> thisVtbl, ref char* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, char** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, ref char* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgCount(this ComPtr<IDxcOptimizerPass> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionArgCount(this ComPtr<IDxcOptimizerPass> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgName(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, char** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgName(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, ref char* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, char** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, ref char* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcOptimizerPass> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizerPass> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionName(this ComPtr<IDxcOptimizerPass> thisVtbl, string[] ppResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
        var ret = @this->GetOptionName(ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
        SilkMarshal.Free((nint) ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, string[] ppResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
        var ret = @this->GetDescription(ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
        SilkMarshal.Free((nint) ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionArgCount(this ComPtr<IDxcOptimizerPass> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetOptionArgCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionArgName(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, string[] ppResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
        var ret = @this->GetOptionArgName(argIndex, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
        SilkMarshal.Free((nint) ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionArgDescription(this ComPtr<IDxcOptimizerPass> thisVtbl, uint argIndex, string[] ppResultSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppResult = (char**) SilkMarshal.StringArrayToPtr(ppResultSa);
        var ret = @this->GetOptionArgDescription(argIndex, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) ppResult, ppResultSa);
        SilkMarshal.Free((nint) ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcOptimizerPass> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
