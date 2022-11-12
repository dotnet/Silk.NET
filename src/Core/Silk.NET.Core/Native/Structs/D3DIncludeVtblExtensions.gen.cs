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

public unsafe static class D3DIncludeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentData, ppData, pBytes);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (uint* pBytesPtr = &pBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentData, ppData, pBytesPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentData, ppDataPtr, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void** ppDataPtr = &ppData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentData, ppDataPtr, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void* pParentDataPtr = &pParentData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentDataPtr, ppData, pBytes);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentDataPtr, ppData, pBytesPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentDataPtr, ppDataPtr, pBytes);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in string pFileName, [Flow(FlowDirection.In)] in T0 pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
        var pFileNamePp = &pFileNamePtr;
        fixed (void* pParentDataPtr = &pParentData)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte**, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePp, pParentDataPtr, ppDataPtr, pBytesPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<ID3DInclude> thisVtbl, [Flow(FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close<T0>(this ComPtr<ID3DInclude> thisVtbl, [Flow(FlowDirection.In)] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, pParentData, in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, in pParentData.GetPinnableReference(), ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, in pParentData.GetPinnableReference(), ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, in pParentData.GetPinnableReference(), in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] string* pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, pFileName, in pParentData.GetPinnableReference(), in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentData, ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentData, ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentData, in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), pParentData, in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), in pParentData.GetPinnableReference(), ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] void** ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), in pParentData.GetPinnableReference(), ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), in pParentData.GetPinnableReference(), in ppData, pBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<T0>(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(FlowDirection.In)] ReadOnlySpan<string> pFileName, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pParentData, [Flow(FlowDirection.In)] in void* ppData, Span<uint> pBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(IncludeType, in pFileName.GetPinnableReference(), in pParentData.GetPinnableReference(), in ppData, ref pBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Close<T0>(this ComPtr<ID3DInclude> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Close(in pData.GetPinnableReference());
    }

}
