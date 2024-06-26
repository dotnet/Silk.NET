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

public unsafe static class TypeLibRegistrationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeLibRegistration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeLibRegistration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGuid(this ComPtr<ITypeLibRegistration> thisVtbl, Guid* pGuid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, int>)@this->LpVtbl[3])(@this, pGuid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGuid(this ComPtr<ITypeLibRegistration> thisVtbl, ref Guid pGuid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pGuidPtr = &pGuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, int>)@this->LpVtbl[3])(@this, pGuidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<ITypeLibRegistration> thisVtbl, char** pVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[4])(@this, pVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<ITypeLibRegistration> thisVtbl, ref char* pVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pVersionPtr = &pVersion)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[4])(@this, pVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLcid(this ComPtr<ITypeLibRegistration> thisVtbl, uint* pLcid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[5])(@this, pLcid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLcid(this ComPtr<ITypeLibRegistration> thisVtbl, ref uint pLcid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pLcidPtr = &pLcid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[5])(@this, pLcidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWin32Path(this ComPtr<ITypeLibRegistration> thisVtbl, char** pWin32Path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[6])(@this, pWin32Path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWin32Path(this ComPtr<ITypeLibRegistration> thisVtbl, ref char* pWin32Path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pWin32PathPtr = &pWin32Path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[6])(@this, pWin32PathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWin64Path(this ComPtr<ITypeLibRegistration> thisVtbl, char** pWin64Path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[7])(@this, pWin64Path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWin64Path(this ComPtr<ITypeLibRegistration> thisVtbl, ref char* pWin64Path)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pWin64PathPtr = &pWin64Path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[7])(@this, pWin64PathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<ITypeLibRegistration> thisVtbl, char** pDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[8])(@this, pDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<ITypeLibRegistration> thisVtbl, ref char* pDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pDisplayNamePtr = &pDisplayName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[8])(@this, pDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlags(this ComPtr<ITypeLibRegistration> thisVtbl, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[9])(@this, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlags(this ComPtr<ITypeLibRegistration> thisVtbl, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[9])(@this, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHelpDir(this ComPtr<ITypeLibRegistration> thisVtbl, char** pHelpDir)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[10])(@this, pHelpDir);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHelpDir(this ComPtr<ITypeLibRegistration> thisVtbl, ref char* pHelpDir)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pHelpDirPtr = &pHelpDir)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[10])(@this, pHelpDirPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeLibRegistration> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLibRegistration> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetGuid(this ComPtr<ITypeLibRegistration> thisVtbl, Span<Guid> pGuid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGuid(ref pGuid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<ITypeLibRegistration> thisVtbl, string[] pVersionSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pVersion = (char**) SilkMarshal.StringArrayToPtr(pVersionSa);
        var ret = @this->GetVersion(pVersion);
        SilkMarshal.CopyPtrToStringArray((nint) pVersion, pVersionSa);
        SilkMarshal.Free((nint) pVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLcid(this ComPtr<ITypeLibRegistration> thisVtbl, Span<uint> pLcid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLcid(ref pLcid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWin32Path(this ComPtr<ITypeLibRegistration> thisVtbl, string[] pWin32PathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pWin32Path = (char**) SilkMarshal.StringArrayToPtr(pWin32PathSa);
        var ret = @this->GetWin32Path(pWin32Path);
        SilkMarshal.CopyPtrToStringArray((nint) pWin32Path, pWin32PathSa);
        SilkMarshal.Free((nint) pWin32Path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWin64Path(this ComPtr<ITypeLibRegistration> thisVtbl, string[] pWin64PathSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pWin64Path = (char**) SilkMarshal.StringArrayToPtr(pWin64PathSa);
        var ret = @this->GetWin64Path(pWin64Path);
        SilkMarshal.CopyPtrToStringArray((nint) pWin64Path, pWin64PathSa);
        SilkMarshal.Free((nint) pWin64Path);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayName(this ComPtr<ITypeLibRegistration> thisVtbl, string[] pDisplayNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pDisplayName = (char**) SilkMarshal.StringArrayToPtr(pDisplayNameSa);
        var ret = @this->GetDisplayName(pDisplayName);
        SilkMarshal.CopyPtrToStringArray((nint) pDisplayName, pDisplayNameSa);
        SilkMarshal.Free((nint) pDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlags(this ComPtr<ITypeLibRegistration> thisVtbl, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFlags(ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetHelpDir(this ComPtr<ITypeLibRegistration> thisVtbl, string[] pHelpDirSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pHelpDir = (char**) SilkMarshal.StringArrayToPtr(pHelpDirSa);
        var ret = @this->GetHelpDir(pHelpDir);
        SilkMarshal.CopyPtrToStringArray((nint) pHelpDir, pHelpDirSa);
        SilkMarshal.Free((nint) pHelpDir);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeLibRegistration> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
