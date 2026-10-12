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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaEngineClassFactoryExVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTimeRange(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, IMFMediaTimeRange** ppTimeRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTimeRange(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref IMFMediaTimeRange* ppTimeRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppTimeRangePtr = &ppTimeRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateError(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, IMFMediaError** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateError(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref IMFMediaError* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaError** ppErrorPtr = &ppError)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttr, ppMSE);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttr, ppMSEPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttrPtr, ppMSE);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttrPtr, ppMSEPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePath, ppKeys);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePath, ppKeysPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* cdmStorePathPtr = &cdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* cdmStorePathPtr = &cdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)cdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)cdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)cdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
            }
        SilkMarshal.Free((nint)cdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeys);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeysPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* cdmStorePathPtr = &cdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* cdmStorePathPtr = &cdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)cdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)cdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, char* keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystem, isSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, char* keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedPtr = &isSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystem, isSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, ref char keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, ref char keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupported);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (int* isSupportedPtr = &isSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupportedPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, char* keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, char* keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, ref char keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, ref char keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (int* isSupportedPtr = &isSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
        SilkMarshal.Free((nint)keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
            }
        SilkMarshal.Free((nint)keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupported);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (int* isSupportedPtr = &isSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupportedPtr);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
            }
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
        SilkMarshal.Free((nint)keySystemPtr);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (int* isSupportedPtr = &isSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance(dwFlags, pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(dwFlags, ref pAttr.GetPinnableReference(), ppPlayer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance(dwFlags, ref pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(dwFlags, ref pAttr.GetPinnableReference(), ref ppPlayer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTimeRange<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref ComPtr<TI0> ppTimeRange) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTimeRange((IMFMediaTimeRange**) ppTimeRange.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateError<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateError((IMFMediaError**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaSourceExtension(dwFlags, pAttr, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, IMFMediaSourceExtension** ppMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaSourceExtension(dwFlags, ref pAttr.GetPinnableReference(), ppMSE);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaSourceExtension<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaSourceExtension(dwFlags, ref pAttr, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaSourceExtension(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, ref IMFMediaSourceExtension* ppMSE)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaSourceExtension(dwFlags, ref pAttr.GetPinnableReference(), ref ppMSE);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, Span<char> cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, Span<char> cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), cdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(ref keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), cdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, Span<char> cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), ref cdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(ref keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, Span<char> cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), ref cdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), cdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(ref keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref keySystem.GetPinnableReference(), cdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> cdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> cdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(keySystem, ref cdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, char* keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, Span<char> keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, ref keySystem.GetPinnableReference(), isSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, Span<char> keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, ref keySystem.GetPinnableReference(), ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, char* keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), keySystem, isSupported);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, char* keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, Span<char> keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), ref keySystem.GetPinnableReference(), isSupported);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, Span<char> keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), ref keySystem.GetPinnableReference(), ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), keySystem, isSupported);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, Span<char> type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference(), keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<char> keySystem, int* isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, ref keySystem.GetPinnableReference(), isSupported);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<char> keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, ref keySystem.GetPinnableReference(), ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupported(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<int> isSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(type, keySystem, ref isSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactoryEx> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
