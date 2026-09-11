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

public unsafe static class MFMediaEngineClassFactory3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
        {
            fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
        {
            fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<char> keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem.GetPinnableReference(), ppSupportedConfigurationsArray, uSize, ppKeyAccess);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<char> keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem.GetPinnableReference(), ppSupportedConfigurationsArray, uSize, ref ppKeyAccess);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<char> keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem.GetPinnableReference(), ref ppSupportedConfigurationsArray, uSize, ppKeyAccess);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, Span<char> keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeySystemAccess(ref keySystem.GetPinnableReference(), ref ppSupportedConfigurationsArray, uSize, ref ppKeyAccess);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeySystemAccess<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeySystemAccess(keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
