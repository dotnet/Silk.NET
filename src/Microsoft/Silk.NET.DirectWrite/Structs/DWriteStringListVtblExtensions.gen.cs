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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteStringListVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteStringList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteStringList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCount(this ComPtr<IDWriteStringList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleNameLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[4])(@this, listIndex, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleNameLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[4])(@this, listIndex, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, char* localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, listIndex, localeName, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, ref char localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, listIndex, localeNamePtr, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, byte*, uint, int>)@this->LpVtbl[5])(@this, listIndex, localeNamePtr, size);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStringLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[6])(@this, listIndex, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStringLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[6])(@this, listIndex, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetString(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, char* stringBuffer, uint stringBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[7])(@this, listIndex, stringBuffer, stringBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, ref char stringBuffer, uint stringBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* stringBufferPtr = &stringBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[7])(@this, listIndex, stringBufferPtr, stringBufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string stringBuffer, uint stringBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var stringBufferPtr = (byte*) SilkMarshal.StringToPtr(stringBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, byte*, uint, int>)@this->LpVtbl[7])(@this, listIndex, stringBufferPtr, stringBufferSize);
        SilkMarshal.Free((nint)stringBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteStringList> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteStringList> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleNameLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleNameLength(listIndex, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, Span<char> localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleName(listIndex, ref localeName.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static int GetStringLength(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStringLength(listIndex, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteStringList> thisVtbl, uint listIndex, Span<char> stringBuffer, uint stringBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetString(listIndex, ref stringBuffer.GetPinnableReference(), stringBufferSize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteStringList> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
