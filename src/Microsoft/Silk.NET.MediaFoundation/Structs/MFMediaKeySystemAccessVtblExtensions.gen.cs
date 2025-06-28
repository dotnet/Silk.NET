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

public unsafe static class MFMediaKeySystemAccessVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaKeySystemAccess> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaKeySystemAccess> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, IPropertyStore* pCdmCustomConfig, IMFMediaKeys2** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfig, ppKeys);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, IPropertyStore* pCdmCustomConfig, ref IMFMediaKeys2* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeys2** ppKeysPtr = &ppKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfig, ppKeysPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref IPropertyStore pCdmCustomConfig, IMFMediaKeys2** ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStore* pCdmCustomConfigPtr = &pCdmCustomConfig)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfigPtr, ppKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref IPropertyStore pCdmCustomConfig, ref IMFMediaKeys2* ppKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStore* pCdmCustomConfigPtr = &pCdmCustomConfig)
        {
            fixed (IMFMediaKeys2** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfigPtr, ppKeysPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSupportedConfiguration(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, IPropertyStore** ppSupportedConfiguration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore**, int>)@this->LpVtbl[4])(@this, ppSupportedConfiguration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSupportedConfiguration(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref IPropertyStore* ppSupportedConfiguration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStore** ppSupportedConfigurationPtr = &ppSupportedConfiguration)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore**, int>)@this->LpVtbl[4])(@this, ppSupportedConfigurationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, char** pKeySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, char**, int>)@this->LpVtbl[5])(@this, pKeySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref char* pKeySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pKeySystemPtr = &pKeySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, char**, int>)@this->LpVtbl[5])(@this, pKeySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys<TI0>(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, IPropertyStore* pCdmCustomConfig, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(pCdmCustomConfig, (IMFMediaKeys2**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Span<IPropertyStore> pCdmCustomConfig, IMFMediaKeys2** ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref pCdmCustomConfig.GetPinnableReference(), ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int CreateMediaKeys<TI0>(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, ref IPropertyStore pCdmCustomConfig, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMediaKeys(ref pCdmCustomConfig, (IMFMediaKeys2**) ppKeys.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMediaKeys(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, Span<IPropertyStore> pCdmCustomConfig, ref IMFMediaKeys2* ppKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMediaKeys(ref pCdmCustomConfig.GetPinnableReference(), ref ppKeys);
    }

    /// <summary>To be documented.</summary>
    public static int GetKeySystem(this ComPtr<IMFMediaKeySystemAccess> thisVtbl, string[] pKeySystemSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pKeySystem = (char**) SilkMarshal.StringArrayToPtr(pKeySystemSa);
        var ret = @this->GetKeySystem(pKeySystem);
        SilkMarshal.CopyPtrToStringArray((nint) pKeySystem, pKeySystemSa);
        SilkMarshal.Free((nint) pKeySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaKeySystemAccess> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
