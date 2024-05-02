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

public unsafe static class TypeChangeEventsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeChangeEvents> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeChangeEvents> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, char* pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrName, pfCancel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, char* pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfCancelPtr = &pfCancel)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrName, pfCancelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, ref char pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStrNamePtr = &pStrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrNamePtr, pfCancel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, ref char pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStrNamePtr = &pStrName)
        {
            fixed (int* pfCancelPtr = &pfCancel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrNamePtr, pfCancelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrNamePtr, pfCancel);
        SilkMarshal.Free((nint)pStrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
        fixed (int* pfCancelPtr = &pfCancel)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBefore, pStrNamePtr, pfCancelPtr);
        }
        SilkMarshal.Free((nint)pStrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, char* pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrName, pfCancel);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, char* pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
            fixed (int* pfCancelPtr = &pfCancel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrName, pfCancelPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, ref char pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
            fixed (char* pStrNamePtr = &pStrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrNamePtr, pfCancel);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, ref char pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
            fixed (char* pStrNamePtr = &pStrName)
            {
                fixed (int* pfCancelPtr = &pfCancel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrNamePtr, pfCancelPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrNamePtr, pfCancel);
        SilkMarshal.Free((nint)pStrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, ref int pfCancel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoBeforePtr = &pTInfoBefore)
        {
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
            fixed (int* pfCancelPtr = &pfCancel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int*, int>)@this->LpVtbl[3])(@this, changeKind, pTInfoBeforePtr, pStrNamePtr, pfCancelPtr);
            }
        SilkMarshal.Free((nint)pStrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoAfter, char* pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfter, pStrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoAfter, ref char pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pStrNamePtr = &pStrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfter, pStrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoAfter, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfter, pStrNamePtr);
        SilkMarshal.Free((nint)pStrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoAfter, char* pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoAfterPtr = &pTInfoAfter)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfterPtr, pStrName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoAfter, ref char pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoAfterPtr = &pTInfoAfter)
        {
            fixed (char* pStrNamePtr = &pStrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, char*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfterPtr, pStrNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ref ITypeInfo pTInfoAfter, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo* pTInfoAfterPtr = &pTInfoAfter)
        {
        var pStrNamePtr = (byte*) SilkMarshal.StringToPtr(pStrName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeChangeEvents*, ChangeKind, ITypeInfo*, byte*, int>)@this->LpVtbl[4])(@this, changeKind, pTInfoAfterPtr, pStrNamePtr);
        SilkMarshal.Free((nint)pStrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeChangeEvents> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, char* pStrName, int* pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, pStrName, pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, char* pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, pTInfoBefore, pStrName, ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, char* pStrName, ref int pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, pStrName, ref pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, Span<char> pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, pTInfoBefore, ref pStrName.GetPinnableReference(), pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, ref char pStrName, int* pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, ref pStrName, pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, Span<char> pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, pTInfoBefore, ref pStrName.GetPinnableReference(), ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, ref char pStrName, ref int pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, ref pStrName, ref pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, int* pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, pStrName, pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, pTInfoBefore, pStrName, ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, ref int pfCancel) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RequestTypeChange(changeKind, (ITypeInfo*) pTInfoBefore.Handle, pStrName, ref pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, char* pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), pStrName, pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, char* pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), pStrName, ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, Span<char> pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), ref pStrName.GetPinnableReference(), pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, Span<char> pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), ref pStrName.GetPinnableReference(), ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, int* pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), pStrName, pfCancel);
    }

    /// <summary>To be documented.</summary>
    public static int RequestTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoBefore, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName, Span<int> pfCancel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RequestTypeChange(changeKind, ref pTInfoBefore.GetPinnableReference(), pStrName, ref pfCancel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoAfter, char* pStrName) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AfterTypeChange(changeKind, (ITypeInfo*) pTInfoAfter.Handle, pStrName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ITypeInfo* pTInfoAfter, Span<char> pStrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AfterTypeChange(changeKind, pTInfoAfter, ref pStrName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoAfter, ref char pStrName) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AfterTypeChange(changeKind, (ITypeInfo*) pTInfoAfter.Handle, ref pStrName);
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, ComPtr<TI0> pTInfoAfter, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AfterTypeChange(changeKind, (ITypeInfo*) pTInfoAfter.Handle, pStrName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoAfter, char* pStrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AfterTypeChange(changeKind, ref pTInfoAfter.GetPinnableReference(), pStrName);
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoAfter, Span<char> pStrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AfterTypeChange(changeKind, ref pTInfoAfter.GetPinnableReference(), ref pStrName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AfterTypeChange(this ComPtr<ITypeChangeEvents> thisVtbl, ChangeKind changeKind, Span<ITypeInfo> pTInfoAfter, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AfterTypeChange(changeKind, ref pTInfoAfter.GetPinnableReference(), pStrName);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeChangeEvents> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
