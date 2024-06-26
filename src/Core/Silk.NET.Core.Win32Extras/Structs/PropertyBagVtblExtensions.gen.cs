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

public unsafe static class PropertyBagVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPropertyBag> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPropertyBag> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVar, pErrorLog);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVar, pErrorLogPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarPtr = &pVar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVarPtr, pErrorLog);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarPtr = &pVar)
        {
            fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVarPtr, pErrorLogPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLog);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLogPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLog);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            fixed (Variant* pVarPtr = &pVar)
            {
                fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLogPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLog);
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLogPtr);
        }
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        fixed (Variant* pVarPtr = &pVar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLog);
        }
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        fixed (Variant* pVarPtr = &pVar)
        {
            fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLogPtr);
            }
        }
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropName, pVar);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarPtr = &pVar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropName, pVarPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVar);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVarPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVar);
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        fixed (Variant* pVarPtr = &pVar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVarPtr);
        }
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPropertyBag> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, pVar, ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Span<Variant> pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, ref pVar.GetPinnableReference(), pErrorLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Span<Variant> pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, ref pVar.GetPinnableReference(), ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Variant* pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(in pszPropName.GetPinnableReference(), pVar, pErrorLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(in pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Variant* pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(in pszPropName.GetPinnableReference(), pVar, ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Span<Variant> pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(in pszPropName.GetPinnableReference(), ref pVar.GetPinnableReference(), pErrorLog);
    }

    /// <summary>To be documented.</summary>
    public static int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(in pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Span<Variant> pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(in pszPropName.GetPinnableReference(), ref pVar.GetPinnableReference(), ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, pVar, ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Span<Variant> pVar, IErrorLog* pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, ref pVar.GetPinnableReference(), pErrorLog);
    }

    /// <summary>To be documented.</summary>
    public static int Read<TI0>(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Span<Variant> pVar, Span<IErrorLog> pErrorLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pszPropName, ref pVar.GetPinnableReference(), ref pErrorLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Span<Variant> pVar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(pszPropName, ref pVar.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Variant* pVar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pszPropName.GetPinnableReference(), pVar);
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Span<Variant> pVar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pszPropName.GetPinnableReference(), ref pVar.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Span<Variant> pVar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(pszPropName, ref pVar.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPropertyBag> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
