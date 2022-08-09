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

public unsafe static class DxcVersionInfo2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcVersionInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcVersionInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pMajor, uint* pMinor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pMajor, ref uint pMinor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMinorPtr = &pMinor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pMajor, uint* pMinor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMajorPtr = &pMajor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pMajor, ref uint pMinor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMajorPtr = &pMajor)
        {
            fixed (uint* pMinorPtr = &pMinor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFlags(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)@this->LpVtbl[4])(@this, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFlags(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)@this->LpVtbl[4])(@this, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pCommitCount, byte** pCommitHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCount, pCommitHash);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pCommitCount, ref byte* pCommitHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** pCommitHashPtr = &pCommitHash)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCount, pCommitHashPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pCommitCount, byte** pCommitHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCommitCountPtr = &pCommitCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCountPtr, pCommitHash);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pCommitCount, ref byte* pCommitHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCommitCountPtr = &pCommitCount)
        {
            fixed (byte** pCommitHashPtr = &pCommitHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCountPtr, pCommitHashPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcVersionInfo2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pMajor, Span<uint> pMinor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(pMajor, ref pMinor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<uint> pMajor, uint* pMinor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(ref pMajor.GetPinnableReference(), pMinor);
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<uint> pMajor, Span<uint> pMinor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(ref pMajor.GetPinnableReference(), ref pMinor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFlags(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFlags(ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, uint* pCommitCount, string[] pCommitHashSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pCommitHash = (byte**) SilkMarshal.StringArrayToPtr(pCommitHashSa);
        var ret = @this->GetCommitInfo(pCommitCount, pCommitHash);
        SilkMarshal.CopyPtrToStringArray((nint) pCommitHash, pCommitHashSa);
        SilkMarshal.Free((nint) pCommitHash);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, ref uint pCommitCount, string[] pCommitHashSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pCommitHash = (byte**) SilkMarshal.StringArrayToPtr(pCommitHashSa);
        var ret = @this->GetCommitInfo(ref pCommitCount, pCommitHash);
        SilkMarshal.CopyPtrToStringArray((nint) pCommitHash, pCommitHashSa);
        SilkMarshal.Free((nint) pCommitHash);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<uint> pCommitCount, byte** pCommitHash)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCommitInfo(ref pCommitCount.GetPinnableReference(), pCommitHash);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommitInfo(this ComPtr<IDxcVersionInfo2> thisVtbl, Span<uint> pCommitCount, ref byte* pCommitHash)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCommitInfo(ref pCommitCount.GetPinnableReference(), ref pCommitHash);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcVersionInfo2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
