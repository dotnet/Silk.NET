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

public unsafe static class DxcBlobUtf16VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetBufferPointer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, void*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetBufferSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, int* pKnown, uint* pCodePage) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, int* pKnown, ref uint pCodePage) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, ref int pKnown, uint* pCodePage) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pKnownPtr = &pKnown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnownPtr, pCodePage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEncoding<TThis>(this TThis thisVtbl, ref int pKnown, ref uint pCodePage) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pKnownPtr = &pKnown)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe char* GetStringPointer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        char* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, char*>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)]
    public static string GetStringPointerS<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        string ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, string>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetStringLength<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobUtf16>
    {
        var @this = (IDxcBlobUtf16*) thisVtbl.AsVtblPtr();
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)@this->LpVtbl[7])(@this);
        return ret;
    }

}
