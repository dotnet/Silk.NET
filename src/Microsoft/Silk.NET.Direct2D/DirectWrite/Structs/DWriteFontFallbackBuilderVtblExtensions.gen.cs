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

public unsafe static class DWriteFontFallbackBuilderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (char* localeNamePtr = &localeName)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                }
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char* localeNamePtr = &localeName)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                }
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
        SilkMarshal.Free((nint)localeNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
        SilkMarshal.Free((nint)localeNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* rangesPtr = &ranges)
        {
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        SilkMarshal.Free((nint)localeNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMappings(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddMappings(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ref IDWriteFontFallback fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFallback* fontFallbackPtr = &fontFallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallback(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallback(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ref IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFallback** fontFallbackPtr = &fontFallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
        var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
        SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
        SilkMarshal.Free((nint) targetFamilyNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), in localeName.GetPinnableReference(), baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, in baseFamilyName.GetPinnableReference(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddMapping(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnicodeRange> ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, Span<IDWriteFontCollection> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMapping(in ranges.GetPinnableReference(), rangesCount, in targetFamilyNames, targetFamilyNamesCount, ref fontCollection.GetPinnableReference(), localeName, baseFamilyName, scale);
    }

    /// <summary>To be documented.</summary>
    public static int AddMappings<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddMappings((IDWriteFontFallback*) fontFallback.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddMappings(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, Span<IDWriteFontFallback> fontFallback)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddMappings(ref fontFallback.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFallback<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl, ref ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFallback((IDWriteFontFallback**) fontFallback.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFallbackBuilder> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
