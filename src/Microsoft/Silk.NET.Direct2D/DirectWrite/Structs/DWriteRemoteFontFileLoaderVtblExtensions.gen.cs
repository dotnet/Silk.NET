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

public unsafe static class DWriteRemoteFontFileLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteRemoteFontFileStream* fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRemoteFontFileStream** fontFileStreamPtr = &fontFileStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteRemoteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteRemoteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, locality);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref Locality locality)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Locality* localityPtr = &locality)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, localityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, locality);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocalityFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref Locality locality) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (Locality* localityPtr = &locality)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, localityPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrl, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrl, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFileUrlPtr = &fontFileUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrlPtr, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFileUrlPtr = &fontFileUrl)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrlPtr, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrlPtr, fontFilePtr);
        }
        SilkMarshal.Free((nint)fontFileUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrl, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrl, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseUrlPtr = &baseUrl)
        {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
            }
        SilkMarshal.Free((nint)fontFileUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrl, fontFile);
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrl, fontFilePtr);
        }
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        fixed (char* fontFileUrlPtr = &fontFileUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFile);
        }
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        fixed (char* fontFileUrlPtr = &fontFileUrl)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
            }
        }
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
        }
        SilkMarshal.Free((nint)fontFileUrlPtr);
        SilkMarshal.Free((nint)baseUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrl, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrl, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrlPtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrlPtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrl, fontFileUrlPtr, fontFilePtr);
            }
        SilkMarshal.Free((nint)fontFileUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrl, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrl, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
                fixed (char* fontFileUrlPtr = &fontFileUrl)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFile);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
                fixed (char* fontFileUrlPtr = &fontFileUrl)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (char* baseUrlPtr = &baseUrl)
            {
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
                }
        SilkMarshal.Free((nint)fontFileUrlPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrl, fontFile);
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrl, fontFilePtr);
            }
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFile);
            }
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
            fixed (char* fontFileUrlPtr = &fontFileUrl)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
                }
            }
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFile);
        SilkMarshal.Free((nint)fontFileUrlPtr);
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
        var baseUrlPtr = (byte*) SilkMarshal.StringToPtr(baseUrl, NativeStringEncoding.UTF8);
        var fontFileUrlPtr = (byte*) SilkMarshal.StringToPtr(fontFileUrl, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, byte*, byte*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factoryPtr, baseUrlPtr, fontFileUrlPtr, fontFilePtr);
            }
        SilkMarshal.Free((nint)fontFileUrlPtr);
        SilkMarshal.Free((nint)baseUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStreamFromKey<T0, TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRemoteStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteRemoteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRemoteStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRemoteStreamFromKey<T0, TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRemoteStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteRemoteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRemoteStreamFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteRemoteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRemoteStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Span<Locality> locality)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocalityFromKey(fontFileReferenceKey, fontFileReferenceKeySize, ref locality.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocalityFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocalityFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, locality);
    }

    /// <summary>To be documented.</summary>
    public static int GetLocalityFromKey<T0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, Span<Locality> locality) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocalityFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref locality.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, baseUrl, in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, baseUrl, in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, in fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, in fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, in baseUrl.GetPinnableReference(), fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, in baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, baseUrl, in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(factory, baseUrl, in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, in fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0, TI1>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl((IDWriteFactory*) factory.Handle, baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, in baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, in baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, in baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), in baseUrl.GetPinnableReference(), fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, in fontFileUrl.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, in fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, in fontFileUrl.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReferenceFromUrl<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory, baseUrl, fontFileUrl, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReferenceFromUrl(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFileUrl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReferenceFromUrl(ref factory.GetPinnableReference(), baseUrl, fontFileUrl, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteRemoteFontFileLoader> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
