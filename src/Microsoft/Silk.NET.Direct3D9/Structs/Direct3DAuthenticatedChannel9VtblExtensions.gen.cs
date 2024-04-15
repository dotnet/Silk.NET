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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DAuthenticatedChannel9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificateSize(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint* pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, ref uint pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCertificateSizePtr = &pCertificateSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificate(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint CertifacteSize, byte* ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint CertifacteSize, ref byte ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* ppCertificatePtr = &ppCertificate)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint CertifacteSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ppCertificate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var ppCertificatePtr = (byte*) SilkMarshal.StringToPtr(ppCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
        SilkMarshal.Free((nint)ppCertificatePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateKeyExchange(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Query<T0, T1>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (void* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedchannelConfigureOutput* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInput, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, ref AuthenticatedchannelConfigureOutput pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInput, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, AuthenticatedchannelConfigureOutput* pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInputPtr, pOutput);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Configure<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, ref AuthenticatedchannelConfigureOutput pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pInputPtr = &pInput)
        {
            fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInputPtr, pOutputPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, Span<uint> pCertificateSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCertificateSize(ref pCertificateSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint CertifacteSize, Span<byte> ppCertificate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCertificate(CertifacteSize, ref ppCertificate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int NegotiateKeyExchange<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->NegotiateKeyExchange(DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, Span<T0> pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(InputSize, pInput, OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(InputSize, in pInput.GetPinnableReference(), OutputSize, pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int Query<T0, T1>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInput, uint OutputSize, Span<T1> pOutput) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(InputSize, in pInput.GetPinnableReference(), OutputSize, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, Span<AuthenticatedchannelConfigureOutput> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Configure(InputSize, pInput, ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Configure<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInput, AuthenticatedchannelConfigureOutput* pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Configure(InputSize, in pInput.GetPinnableReference(), pOutput);
    }

    /// <summary>To be documented.</summary>
    public static int Configure<T0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInput, Span<AuthenticatedchannelConfigureOutput> pOutput) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Configure(InputSize, in pInput.GetPinnableReference(), ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DAuthenticatedChannel9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
