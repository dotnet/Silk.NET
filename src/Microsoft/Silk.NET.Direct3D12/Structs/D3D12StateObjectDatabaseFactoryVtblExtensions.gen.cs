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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12StateObjectDatabaseFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riid, ppvStateObjectDatabase);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riid, ppvStateObjectDatabasePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riidPtr, ppvStateObjectDatabase);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riidPtr, ppvStateObjectDatabasePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pDatabaseFilePtr = &pDatabaseFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabase);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pDatabaseFilePtr = &pDatabaseFile)
        {
            fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabasePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pDatabaseFilePtr = &pDatabaseFile)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabase);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pDatabaseFilePtr = &pDatabaseFile)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabasePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabase);
        SilkMarshal.Free((nint)pDatabaseFilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
        fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabasePtr);
        }
        SilkMarshal.Free((nint)pDatabaseFilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabase);
        }
        SilkMarshal.Free((nint)pDatabaseFilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabasePtr);
            }
        }
        SilkMarshal.Free((nint)pDatabaseFilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvStateObjectDatabase = default;
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, ref riid.GetPinnableReference(), ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, ref riid.GetPinnableReference(), ref ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile.GetPinnableReference(), flags, riid, ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvStateObjectDatabase = default;
        return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile.GetPinnableReference(), flags, riid, ref ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile.GetPinnableReference(), flags, ref riid.GetPinnableReference(), ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile.GetPinnableReference(), flags, ref riid.GetPinnableReference(), ref ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvStateObjectDatabase = default;
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, void** ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, ref riid.GetPinnableReference(), ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObjectDatabaseFromFile(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Span<Guid> riid, ref void* ppvStateObjectDatabase)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, ref riid.GetPinnableReference(), ref ppvStateObjectDatabase);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(in pDatabaseFile, flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>(this ComPtr<ID3D12StateObjectDatabaseFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
