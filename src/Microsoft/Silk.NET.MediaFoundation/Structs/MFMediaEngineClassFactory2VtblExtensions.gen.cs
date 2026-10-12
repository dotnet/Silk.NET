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

public unsafe static class MFMediaEngineClassFactory2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePath, ppKeysPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystem, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePath, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
                fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
                fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
                {
                    fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
            {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
                }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
            }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
            }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
                }
            }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, char*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePath, ppKeysPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePath, inprivateCdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
            fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
                }
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (char* defaultCdmStorePathPtr = &defaultCdmStorePath)
        {
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeys);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePath, ppKeysPtr);
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        fixed (char* inprivateCdmStorePathPtr = &inprivateCdmStorePath)
        {
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
            }
        }
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeys);
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        var defaultCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(defaultCdmStorePath, NativeStringEncoding.BStr);
        var inprivateCdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(inprivateCdmStorePath, NativeStringEncoding.BStr);
        fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory2*, byte*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[3])(@this, keySystemPtr, defaultCdmStorePathPtr, inprivateCdmStorePathPtr, ppKeysPtr);
        }
        SilkMarshal.Free((nint)inprivateCdmStorePathPtr);
        SilkMarshal.Free((nint)defaultCdmStorePathPtr);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, ref defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(ref keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, Span<char> keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(ref keySystem.GetPinnableReference(), defaultCdmStorePath, inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, char* inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<char> defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, ref defaultCdmStorePath.GetPinnableReference(), inprivateCdmStorePath, ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, char* inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, IMFMediaKeys** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, ref char inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys2(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, Span<char> inprivateCdmStorePath, ref IMFMediaKeys* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, ref inprivateCdmStorePath.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys2<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string defaultCdmStorePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string inprivateCdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys2(keySystem, defaultCdmStorePath, inprivateCdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
