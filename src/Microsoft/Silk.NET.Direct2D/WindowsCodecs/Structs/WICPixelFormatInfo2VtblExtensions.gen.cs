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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICPixelFormatInfo2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICPixelFormatInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICPixelFormatInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponentType(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ComponentType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref ComponentType pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComponentType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCLSID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Guid* pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref Guid pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pclsidPtr = &pclsid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSigningStatus(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, char* wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, char* wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, ref char wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVendorGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Guid* pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref Guid pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, char* wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, char* wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, ref char wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, ref char wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFormatGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Guid* pFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[11])(@this, pFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFormatGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref Guid pFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pFormatPtr = &pFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[11])(@this, pFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContext(this ComPtr<IWICPixelFormatInfo2> thisVtbl, IWICColorContext** ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, IWICColorContext**, int>)@this->LpVtbl[12])(@this, ppIColorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContext(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref IWICColorContext* ppIColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, IWICColorContext**, int>)@this->LpVtbl[12])(@this, ppIColorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBitsPerPixel(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint* puiBitsPerPixel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[13])(@this, puiBitsPerPixel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBitsPerPixel(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref uint puiBitsPerPixel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiBitsPerPixelPtr = &puiBitsPerPixel)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[13])(@this, puiBitsPerPixelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelCount(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint* puiChannelCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[14])(@this, puiChannelCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelCount(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref uint puiChannelCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiChannelCountPtr = &puiChannelCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[14])(@this, puiChannelCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbActualPtr = &pcbActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, ref byte pbMaskBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbMaskBufferPtr = &pbMaskBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, ref byte pbMaskBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbMaskBufferPtr = &pbMaskBuffer)
        {
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMaskBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbMaskBufferPtr = (byte*) SilkMarshal.StringToPtr(pbMaskBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActual);
        SilkMarshal.Free((nint)pbMaskBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMaskBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbMaskBufferPtr = (byte*) SilkMarshal.StringToPtr(pbMaskBuffer, NativeStringEncoding.UTF8);
        fixed (uint* pcbActualPtr = &pcbActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActualPtr);
        }
        SilkMarshal.Free((nint)pbMaskBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SupportsTransparency(this ComPtr<IWICPixelFormatInfo2> thisVtbl, int* pfSupportsTransparency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsTransparency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SupportsTransparency(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref int pfSupportsTransparency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportsTransparencyPtr = &pfSupportsTransparency)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsTransparencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumericRepresentation(this ComPtr<IWICPixelFormatInfo2> thisVtbl, PixelFormatNumericRepresentation* pNumericRepresentation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, PixelFormatNumericRepresentation*, int>)@this->LpVtbl[17])(@this, pNumericRepresentation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNumericRepresentation(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref PixelFormatNumericRepresentation pNumericRepresentation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PixelFormatNumericRepresentation* pNumericRepresentationPtr = &pNumericRepresentation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, PixelFormatNumericRepresentation*, int>)@this->LpVtbl[17])(@this, pNumericRepresentationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICPixelFormatInfo2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<ComponentType> pType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComponentType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<Guid> pclsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCLSID(ref pclsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSigningStatus(ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, char* wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, Span<char> wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, Span<char> wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<Guid> pguidVendor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVendorGUID(ref pguidVendor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, char* wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, Span<char> wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, Span<char> wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFormatGUID(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<Guid> pFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFormatGUID(ref pFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorContext<TI0>(this ComPtr<IWICPixelFormatInfo2> thisVtbl, ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContext((IWICColorContext**) ppIColorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetBitsPerPixel(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<uint> puiBitsPerPixel)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBitsPerPixel(ref puiBitsPerPixel.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelCount(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<uint> puiChannelCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetChannelCount(ref puiChannelCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetChannelMask(uiChannelIndex, cbMaskBuffer, pbMaskBuffer, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, Span<byte> pbMaskBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetChannelMask(uiChannelIndex, cbMaskBuffer, ref pbMaskBuffer.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, Span<byte> pbMaskBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetChannelMask(uiChannelIndex, cbMaskBuffer, ref pbMaskBuffer.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetChannelMask(this ComPtr<IWICPixelFormatInfo2> thisVtbl, uint uiChannelIndex, uint cbMaskBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMaskBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetChannelMask(uiChannelIndex, cbMaskBuffer, pbMaskBuffer, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SupportsTransparency(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<int> pfSupportsTransparency)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SupportsTransparency(ref pfSupportsTransparency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetNumericRepresentation(this ComPtr<IWICPixelFormatInfo2> thisVtbl, Span<PixelFormatNumericRepresentation> pNumericRepresentation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNumericRepresentation(ref pNumericRepresentation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICPixelFormatInfo2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
