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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11TracingDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetShaderTrackingOptionsByType<TThis>(this TThis thisVtbl, uint ResourceTypeFlags, uint Options) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint, uint, int>)@this->LpVtbl[3])(@this, ResourceTypeFlags, Options);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetShaderTrackingOptions<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pShader, uint Options) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[4])(@this, pShader, Options);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetShaderTrackingOptions<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pShader, uint Options) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[4])(@this, pShaderPtr, Options);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetShaderTrackingOptions<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pShader, uint Options) where TThis : IComVtbl<ID3D11TracingDevice>
    {
        var @this = (ID3D11TracingDevice*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetShaderTrackingOptions(ref pShader.GetPinnableReference(), Options);
    }

}
