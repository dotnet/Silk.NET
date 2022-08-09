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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12ProtectedResourceSession1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, Guid* riid, void** ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[8])(@this, riid, ppFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppFencePtr = &ppFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[8])(@this, riid, ppFencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, ref Guid riid, void** ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[8])(@this, riidPtr, ppFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[8])(@this, riidPtr, ppFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ProtectedSessionStatus GetSessionStatus<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        ProtectedSessionStatus ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedSessionStatus>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ProtectedResourceSessionDesc GetDesc<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        ProtectedResourceSessionDesc ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedResourceSessionDesc>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ProtectedResourceSessionDesc1 GetDesc1<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        ProtectedResourceSessionDesc1 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedResourceSessionDesc1>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int GetStatusFence<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppFence) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppFence = default;
        return @this->GetStatusFence(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppFence.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStatusFence(ref riid.GetPinnableReference(), ppFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatusFence<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppFence) where TThis : IComVtbl<ID3D12ProtectedResourceSession1>
    {
        var @this = (ID3D12ProtectedResourceSession1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStatusFence(ref riid.GetPinnableReference(), ref ppFence);
    }

}
