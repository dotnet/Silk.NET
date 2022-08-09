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

public unsafe static class D3D11CryptoSessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ID3D11Device** ppDevice) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ref ID3D11Device* ppDevice) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCryptoType<TThis>(this TThis thisVtbl, Guid* pCryptoType) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)@this->LpVtbl[7])(@this, pCryptoType);
    }

    /// <summary>To be documented.</summary>
    public static void GetCryptoType<TThis>(this TThis thisVtbl, ref Guid pCryptoType) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)@this->LpVtbl[7])(@this, pCryptoTypePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDecoderProfile<TThis>(this TThis thisVtbl, Guid* pDecoderProfile) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)@this->LpVtbl[8])(@this, pDecoderProfile);
    }

    /// <summary>To be documented.</summary>
    public static void GetDecoderProfile<TThis>(this TThis thisVtbl, ref Guid pDecoderProfile) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)@this->LpVtbl[8])(@this, pDecoderProfilePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificateSize<TThis>(this TThis thisVtbl, uint* pCertificateSize) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint*, int>)@this->LpVtbl[9])(@this, pCertificateSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, ref uint pCertificateSize) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCertificateSizePtr = &pCertificateSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint*, int>)@this->LpVtbl[9])(@this, pCertificateSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCertificate<TThis>(this TThis thisVtbl, uint CertificateSize, byte* pCertificate) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)@this->LpVtbl[10])(@this, CertificateSize, pCertificate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertificateSize, ref byte pCertificate) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pCertificatePtr = &pCertificate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)@this->LpVtbl[10])(@this, CertificateSize, pCertificatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertificateSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pCertificate) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pCertificatePtr = (byte*) SilkMarshal.StringToPtr(pCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)@this->LpVtbl[10])(@this, CertificateSize, pCertificatePtr);
        SilkMarshal.Free((nint)pCertificatePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCryptoSessionHandle<TThis>(this TThis thisVtbl, void** pCryptoSessionHandle) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, void**, void>)@this->LpVtbl[11])(@this, pCryptoSessionHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCryptoSessionHandle<TThis>(this TThis thisVtbl, ref void* pCryptoSessionHandle) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        fixed (void** pCryptoSessionHandlePtr = &pCryptoSessionHandle)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, void**, void>)@this->LpVtbl[11])(@this, pCryptoSessionHandlePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetCryptoType<TThis>(this TThis thisVtbl, Span<Guid> pCryptoType) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetCryptoType(ref pCryptoType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetDecoderProfile<TThis>(this TThis thisVtbl, Span<Guid> pDecoderProfile) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetDecoderProfile(ref pDecoderProfile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificateSize<TThis>(this TThis thisVtbl, Span<uint> pCertificateSize) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificateSize(ref pCertificateSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCertificate<TThis>(this TThis thisVtbl, uint CertificateSize, Span<byte> pCertificate) where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCertificate(CertificateSize, ref pCertificate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11CryptoSession>
    {
        var @this = (ID3D11CryptoSession*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
