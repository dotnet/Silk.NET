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

namespace Silk.NET.Core.Native;

public unsafe static class D3DShaderCacheInstallerClientVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, nuint* pNameLength, char* pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLength, pName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, nuint* pNameLength, ref char pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLength, pNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, nuint* pNameLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, byte*, int>)@this->LpVtbl[0])(@this, pNameLength, pNamePtr);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ref nuint pNameLength, char* pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pNameLengthPtr = &pNameLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ref nuint pNameLength, ref char pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pNameLengthPtr = &pNameLength)
        {
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ref nuint pNameLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nuint* pNameLengthPtr = &pNameLength)
        {
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, byte*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pNamePtr);
        SilkMarshal.Free((nint)pNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static D3DShaderCacheAppRegistrationScope GetInstallerScope(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        D3DShaderCacheAppRegistrationScope ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, D3DShaderCacheAppRegistrationScope>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleDriverUpdate(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ID3DShaderCacheInstaller* pInstaller)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, ID3DShaderCacheInstaller*, int>)@this->LpVtbl[2])(@this, pInstaller);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HandleDriverUpdate(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ref ID3DShaderCacheInstaller pInstaller)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3DShaderCacheInstaller* pInstallerPtr = &pInstaller)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, ID3DShaderCacheInstaller*, int>)@this->LpVtbl[2])(@this, pInstallerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, nuint* pNameLength, Span<char> pName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInstallerName(pNameLength, ref pName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, Span<nuint> pNameLength, char* pName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInstallerName(ref pNameLength.GetPinnableReference(), pName);
    }

    /// <summary>To be documented.</summary>
    public static int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, Span<nuint> pNameLength, Span<char> pName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInstallerName(ref pNameLength.GetPinnableReference(), ref pName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInstallerName(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, Span<nuint> pNameLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInstallerName(ref pNameLength.GetPinnableReference(), pName);
    }

    /// <summary>To be documented.</summary>
    public static int HandleDriverUpdate<TI0>(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, ComPtr<TI0> pInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstaller>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->HandleDriverUpdate((ID3DShaderCacheInstaller*) pInstaller.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int HandleDriverUpdate(this ComPtr<ID3DShaderCacheInstallerClient> thisVtbl, Span<ID3DShaderCacheInstaller> pInstaller)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleDriverUpdate(ref pInstaller.GetPinnableReference());
    }

}
