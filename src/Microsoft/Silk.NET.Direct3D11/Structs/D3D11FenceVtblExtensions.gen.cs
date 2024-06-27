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

public unsafe static class D3D11FenceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11Fence> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11Fence> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11Fence> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11Fence> thisVtbl, ref ID3D11Device* ppDevice)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* lpNamePtr = &lpName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* lpNamePtr = &lpName)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
        SilkMarshal.Free((nint)lpNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
        }
        SilkMarshal.Free((nint)lpNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* lpNamePtr = &lpName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* lpNamePtr = &lpName)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
        SilkMarshal.Free((nint)lpNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)lpNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetCompletedValue(this ComPtr<ID3D11Fence> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnCompletion(this ComPtr<ID3D11Fence> thisVtbl, ulong Value, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong, void*, int>)@this->LpVtbl[9])(@this, Value, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEventOnCompletion<T0>(this ComPtr<ID3D11Fence> thisVtbl, ulong Value, ref T0 hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong, void*, int>)@this->LpVtbl[9])(@this, Value, hEventPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11Fence> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0>(this ComPtr<ID3D11Fence> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11Fence> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11Fence> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pAttributes, dwAccess, in lpName.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pAttributes, dwAccess, in lpName.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, lpName, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, lpName, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, in lpName.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, in lpName.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, lpName, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D11Fence> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint dwAccess, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(in pAttributes.GetPinnableReference(), dwAccess, lpName, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static int SetEventOnCompletion<T0>(this ComPtr<ID3D11Fence> thisVtbl, ulong Value, Span<T0> hEvent) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEventOnCompletion(Value, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11Fence> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
