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

public unsafe static class DWriteLocalizedStringsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCount(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, index, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, index, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indexPtr = &index)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, indexPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indexPtr = &index)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, indexPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, index, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, index, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (uint* indexPtr = &index)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, indexPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (uint* indexPtr = &index)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, indexPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, byte*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, index, exists);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, byte*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, index, existsPtr);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (uint* indexPtr = &index)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, byte*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, indexPtr, exists);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (uint* indexPtr = &index)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, byte*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeNamePtr, indexPtr, existsPtr);
            }
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleNameLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[5])(@this, index, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleNameLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[5])(@this, index, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, char* localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[6])(@this, index, localeName, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, ref char localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[6])(@this, index, localeNamePtr, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, byte*, uint, int>)@this->LpVtbl[6])(@this, index, localeNamePtr, size);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStringLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[7])(@this, index, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStringLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, ref uint length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[7])(@this, index, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetString(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, char* stringBuffer, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[8])(@this, index, stringBuffer, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, ref char stringBuffer, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* stringBufferPtr = &stringBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[8])(@this, index, stringBufferPtr, size);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string stringBuffer, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var stringBufferPtr = (byte*) SilkMarshal.StringToPtr(stringBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, byte*, uint, int>)@this->LpVtbl[8])(@this, index, stringBufferPtr, size);
        SilkMarshal.Free((nint)stringBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteLocalizedStrings> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(in localeName.GetPinnableReference(), index, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(in localeName.GetPinnableReference(), index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(in localeName.GetPinnableReference(), ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(in localeName.GetPinnableReference(), ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindLocaleName(localeName, ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleNameLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleNameLength(index, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, Span<char> localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleName(index, ref localeName.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static int GetStringLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, Span<uint> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStringLength(index, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetString(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, Span<char> stringBuffer, uint size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetString(index, ref stringBuffer.GetPinnableReference(), size);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteLocalizedStrings> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
