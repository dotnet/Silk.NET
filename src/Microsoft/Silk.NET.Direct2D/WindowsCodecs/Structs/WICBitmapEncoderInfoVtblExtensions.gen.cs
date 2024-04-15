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

public unsafe static class WICBitmapEncoderInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapEncoderInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapEncoderInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponentType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ComponentType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref ComponentType pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComponentType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCLSID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Guid* pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref Guid pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pclsidPtr = &pclsid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSigningStatus(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, ref char wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVendorGUID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Guid* pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref Guid pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, char* wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, char* wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, ref char wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, ref char wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormat(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Guid* pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref Guid pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, Guid* pguidPixelFormats, ref uint pcActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcActualPtr = &pcActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, ref Guid pguidPixelFormats, uint* pcActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, ref Guid pguidPixelFormats, ref uint pcActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
        {
            fixed (uint* pcActualPtr = &pcActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, char* wzColorManagementVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, char* wzColorManagementVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, ref char wzColorManagementVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, ref char wzColorManagementVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzColorManagementVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzColorManagementVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, ref char wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, ref char wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
        SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, ref char wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, ref char wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
        SilkMarshal.Free((nint)wzDeviceModelsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzDeviceModelsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, char* wzMimeTypes, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, char* wzMimeTypes, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, ref char wzMimeTypes, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzMimeTypesPtr = &wzMimeTypes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, ref char wzMimeTypes, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzMimeTypesPtr = &wzMimeTypes)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
        SilkMarshal.Free((nint)wzMimeTypesPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzMimeTypesPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, char* wzFileExtensions, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, char* wzFileExtensions, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, ref char wzFileExtensions, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, ref char wzFileExtensions, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
        SilkMarshal.Free((nint)wzFileExtensionsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzFileExtensionsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportAnimation(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, int* pfSupportAnimation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportAnimation(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref int pfSupportAnimation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportAnimationPtr = &pfSupportAnimation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChromakey(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, int* pfSupportChromakey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportChromakey(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref int pfSupportChromakey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportChromakeyPtr = &pfSupportChromakey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakeyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportLossless(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, int* pfSupportLossless)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLossless);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportLossless(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref int pfSupportLossless)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportLosslessPtr = &pfSupportLossless)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLosslessPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportMultiframe(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, int* pfSupportMultiframe)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframe);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportMultiframe(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref int pfSupportMultiframe)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportMultiframePtr = &pfSupportMultiframe)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatches);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfMatchesPtr = &pfMatches)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatchesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzMimeTypePtr = &wzMimeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzMimeTypePtr = &wzMimeType)
        {
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
        SilkMarshal.Free((nint)wzMimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
        fixed (int* pfMatchesPtr = &pfMatches)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
        }
        SilkMarshal.Free((nint)wzMimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, IWICBitmapEncoder** ppIBitmapEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int>)@this->LpVtbl[23])(@this, ppIBitmapEncoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref IWICBitmapEncoder* ppIBitmapEncoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapEncoder** ppIBitmapEncoderPtr = &ppIBitmapEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int>)@this->LpVtbl[23])(@this, ppIBitmapEncoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<ComponentType> pType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComponentType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<Guid> pclsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCLSID(ref pclsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSigningStatus(ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, Span<char> wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, Span<char> wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<Guid> pguidVendor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVendorGUID(ref pguidVendor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, char* wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, Span<char> wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, Span<char> wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<Guid> pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormat(ref pguidContainerFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, Guid* pguidPixelFormats, Span<uint> pcActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormats(cFormats, pguidPixelFormats, ref pcActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, Span<Guid> pguidPixelFormats, uint* pcActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormats(cFormats, ref pguidPixelFormats.GetPinnableReference(), pcActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormats(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cFormats, Span<Guid> pguidPixelFormats, Span<uint> pcActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormats(cFormats, ref pguidPixelFormats.GetPinnableReference(), ref pcActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, char* wzColorManagementVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorManagementVersion(cchColorManagementVersion, wzColorManagementVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, Span<char> wzColorManagementVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorManagementVersion(cchColorManagementVersion, ref wzColorManagementVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, Span<char> wzColorManagementVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorManagementVersion(cchColorManagementVersion, ref wzColorManagementVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorManagementVersion(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorManagementVersion(cchColorManagementVersion, wzColorManagementVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, wzDeviceManufacturer, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, Span<char> wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, ref wzDeviceManufacturer.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, Span<char> wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, ref wzDeviceManufacturer.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, wzDeviceManufacturer, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, wzDeviceModels, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, Span<char> wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, ref wzDeviceModels.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, Span<char> wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, ref wzDeviceModels.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, wzDeviceModels, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, char* wzMimeTypes, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMimeTypes(cchMimeTypes, wzMimeTypes, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, Span<char> wzMimeTypes, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMimeTypes(cchMimeTypes, ref wzMimeTypes.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, Span<char> wzMimeTypes, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMimeTypes(cchMimeTypes, ref wzMimeTypes.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMimeTypes(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMimeTypes(cchMimeTypes, wzMimeTypes, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, char* wzFileExtensions, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileExtensions(cchFileExtensions, wzFileExtensions, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, Span<char> wzFileExtensions, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileExtensions(cchFileExtensions, ref wzFileExtensions.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, Span<char> wzFileExtensions, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileExtensions(cchFileExtensions, ref wzFileExtensions.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFileExtensions(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileExtensions(cchFileExtensions, wzFileExtensions, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportAnimation(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<int> pfSupportAnimation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportAnimation(ref pfSupportAnimation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportChromakey(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<int> pfSupportChromakey)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportChromakey(ref pfSupportChromakey.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportLossless(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<int> pfSupportLossless)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportLossless(ref pfSupportLossless.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportMultiframe(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, Span<int> pfSupportMultiframe)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportMultiframe(ref pfSupportMultiframe.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesMimeType(wzMimeType, ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzMimeType, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesMimeType(in wzMimeType.GetPinnableReference(), pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzMimeType, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesMimeType(in wzMimeType.GetPinnableReference(), ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MatchesMimeType(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesMimeType(wzMimeType, ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<IWICBitmapEncoderInfo> thisVtbl, ref ComPtr<TI0> ppIBitmapEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((IWICBitmapEncoder**) ppIBitmapEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapEncoderInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
