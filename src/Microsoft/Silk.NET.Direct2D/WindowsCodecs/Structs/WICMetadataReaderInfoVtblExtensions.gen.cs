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

public unsafe static class WICMetadataReaderInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICMetadataReaderInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICMetadataReaderInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComponentType(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ComponentType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref ComponentType pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComponentType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCLSID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid pclsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pclsidPtr = &pclsid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSigningStatus(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, ref char wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzAuthorPtr = &wzAuthor)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzAuthorPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVendorGUID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid pguidVendor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidVendorPtr = &pguidVendor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, char* wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, char* wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, ref char wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, ref char wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzVersionPtr = &wzVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzSpecVersionPtr = &wzSpecVersion)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzSpecVersionPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzFriendlyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataFormat(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidMetadataFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidMetadataFormatPtr = &pguidMetadataFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidMetadataFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormats, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, Guid* pguidContainerFormats, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormats, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, ref Guid pguidContainerFormats, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatsPtr = &pguidContainerFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormatsPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, ref Guid pguidContainerFormats, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatsPtr = &pguidContainerFormats)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormatsPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, ref char wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, ref char wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
        SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModels, pcchActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModels, pcchActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, ref char wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, ref char wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
        {
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
        SilkMarshal.Free((nint)wzDeviceModelsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, ref uint pcchActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualPtr = &pcchActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
        }
        SilkMarshal.Free((nint)wzDeviceModelsPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesRequireFullStream(this ComPtr<IWICMetadataReaderInfo> thisVtbl, int* pfRequiresFullStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[15])(@this, pfRequiresFullStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesRequireFullStream(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref int pfRequiresFullStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfRequiresFullStreamPtr = &pfRequiresFullStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[15])(@this, pfRequiresFullStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportPadding(this ComPtr<IWICMetadataReaderInfo> thisVtbl, int* pfSupportsPadding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsPadding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportPadding(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref int pfSupportsPadding)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfSupportsPaddingPtr = &pfSupportsPadding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsPaddingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesRequireFixedSize(this ComPtr<IWICMetadataReaderInfo> thisVtbl, int* pfFixedSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[17])(@this, pfFixedSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesRequireFixedSize(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref int pfFixedSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfFixedSizePtr = &pfFixedSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[17])(@this, pfFixedSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbActualPtr = &pcbActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCount, pcbActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCountPtr, pcbActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCountPtr, pcbActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetadataPattern* pPatternPtr = &pPattern)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCount, pcbActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetadataPattern* pPatternPtr = &pPattern)
        {
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCount, pcbActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetadataPattern* pPatternPtr = &pPattern)
        {
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCountPtr, pcbActual);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MetadataPattern* pPatternPtr = &pPattern)
        {
            fixed (uint* pcCountPtr = &pcCount)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCountPtr, pcbActualPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCount, pcbActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCount, pcbActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCountPtr, pcbActual);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (uint* pcCountPtr = &pcCount)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCountPtr, pcbActualPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCount, pcbActual);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCount, pcbActualPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCountPtr, pcbActual);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    fixed (uint* pcbActualPtr = &pcbActual)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCountPtr, pcbActualPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStream, pfMatches);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfMatchesPtr = &pfMatches)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStream, pfMatchesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStreamPtr, pfMatches);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStreamPtr, pfMatchesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStream, pfMatches);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStream, pfMatchesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStreamPtr, pfMatches);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref int pfMatches)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
        {
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStreamPtr, pfMatchesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IWICMetadataReaderInfo> thisVtbl, IWICMetadataReader** ppIReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)@this->LpVtbl[20])(@this, ppIReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref IWICMetadataReader* ppIReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)@this->LpVtbl[20])(@this, ppIReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetComponentType(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<ComponentType> pType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComponentType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCLSID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> pclsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCLSID(ref pclsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSigningStatus(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSigningStatus(ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, char* wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, Span<char> wzAuthor, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, Span<char> wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, ref wzAuthor.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAuthor(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAuthor(cchAuthor, wzAuthor, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVendorGUID(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> pguidVendor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVendorGUID(ref pguidVendor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, char* wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, Span<char> wzVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, Span<char> wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, ref wzVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVersion(cchVersion, wzVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, char* wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, Span<char> wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, ref wzSpecVersion.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSpecVersion(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSpecVersion(cchSpecVersion, wzSpecVersion, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, char* wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, Span<char> wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, ref wzFriendlyName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFriendlyName(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFriendlyName(cchFriendlyName, wzFriendlyName, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataFormat(ref pguidMetadataFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, Guid* pguidContainerFormats, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormats(cContainerFormats, pguidContainerFormats, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, Span<Guid> pguidContainerFormats, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormats(cContainerFormats, ref pguidContainerFormats.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormats(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cContainerFormats, Span<Guid> pguidContainerFormats, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormats(cContainerFormats, ref pguidContainerFormats.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, char* wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, wzDeviceManufacturer, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, Span<char> wzDeviceManufacturer, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, ref wzDeviceManufacturer.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, Span<char> wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, ref wzDeviceManufacturer.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceManufacturer(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceManufacturer(cchDeviceManufacturer, wzDeviceManufacturer, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, char* wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, wzDeviceModels, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, Span<char> wzDeviceModels, uint* pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, ref wzDeviceModels.GetPinnableReference(), pcchActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, Span<char> wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, ref wzDeviceModels.GetPinnableReference(), ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceModels(this ComPtr<IWICMetadataReaderInfo> thisVtbl, uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, Span<uint> pcchActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceModels(cchDeviceModels, wzDeviceModels, ref pcchActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesRequireFullStream(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<int> pfRequiresFullStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesRequireFullStream(ref pfRequiresFullStream.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportPadding(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<int> pfSupportsPadding)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportPadding(ref pfSupportsPadding.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesRequireFixedSize(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<int> pfFixedSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesRequireFixedSize(ref pfFixedSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetPatterns(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPatterns(ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, ComPtr<TI0> pIStream, int* pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MatchesPattern(guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(guidContainerFormat, pIStream, ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, ComPtr<TI0> pIStream, ref int pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MatchesPattern(guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(guidContainerFormat, ref pIStream.GetPinnableReference(), pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Guid* guidContainerFormat, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(guidContainerFormat, ref pIStream.GetPinnableReference(), ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(ref guidContainerFormat.GetPinnableReference(), pIStream, pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, ComPtr<TI0> pIStream, int* pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MatchesPattern(ref guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(ref guidContainerFormat.GetPinnableReference(), pIStream, ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MatchesPattern<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref Guid guidContainerFormat, ComPtr<TI0> pIStream, ref int pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MatchesPattern(ref guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, int* pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(ref guidContainerFormat.GetPinnableReference(), ref pIStream.GetPinnableReference(), pfMatches);
    }

    /// <summary>To be documented.</summary>
    public static int MatchesPattern(this ComPtr<IWICMetadataReaderInfo> thisVtbl, Span<Guid> guidContainerFormat, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<int> pfMatches)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MatchesPattern(ref guidContainerFormat.GetPinnableReference(), ref pIStream.GetPinnableReference(), ref pfMatches.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance((IWICMetadataReader**) ppIReader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICMetadataReaderInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
