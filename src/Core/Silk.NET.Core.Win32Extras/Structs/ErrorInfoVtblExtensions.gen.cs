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

public unsafe static class ErrorInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IErrorInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IErrorInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGUID(this ComPtr<IErrorInfo> thisVtbl, Guid* pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, pGUID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IErrorInfo> thisVtbl, ref Guid pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pGUIDPtr = &pGUID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, pGUIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource(this ComPtr<IErrorInfo> thisVtbl, char** pBstrSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[4])(@this, pBstrSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSource(this ComPtr<IErrorInfo> thisVtbl, ref char* pBstrSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrSourcePtr = &pBstrSource)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[4])(@this, pBstrSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IErrorInfo> thisVtbl, char** pBstrDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[5])(@this, pBstrDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IErrorInfo> thisVtbl, ref char* pBstrDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDescriptionPtr = &pBstrDescription)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[5])(@this, pBstrDescriptionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHelpFile(this ComPtr<IErrorInfo> thisVtbl, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[6])(@this, pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHelpFile(this ComPtr<IErrorInfo> thisVtbl, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, char**, int>)@this->LpVtbl[6])(@this, pBstrHelpFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHelpContext(this ComPtr<IErrorInfo> thisVtbl, uint* pdwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint*, int>)@this->LpVtbl[7])(@this, pdwHelpContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHelpContext(this ComPtr<IErrorInfo> thisVtbl, ref uint pdwHelpContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorInfo*, uint*, int>)@this->LpVtbl[7])(@this, pdwHelpContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IErrorInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IErrorInfo> thisVtbl, Span<Guid> pGUID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGUID(ref pGUID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSource(this ComPtr<IErrorInfo> thisVtbl, string[] pBstrSourceSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrSource = (char**) SilkMarshal.StringArrayToPtr(pBstrSourceSa);
        var ret = @this->GetSource(pBstrSource);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrSource, pBstrSourceSa);
        SilkMarshal.Free((nint) pBstrSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDescription(this ComPtr<IErrorInfo> thisVtbl, string[] pBstrDescriptionSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDescription = (char**) SilkMarshal.StringArrayToPtr(pBstrDescriptionSa);
        var ret = @this->GetDescription(pBstrDescription);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDescription, pBstrDescriptionSa);
        SilkMarshal.Free((nint) pBstrDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHelpFile(this ComPtr<IErrorInfo> thisVtbl, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetHelpFile(pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHelpContext(this ComPtr<IErrorInfo> thisVtbl, Span<uint> pdwHelpContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetHelpContext(ref pdwHelpContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IErrorInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
