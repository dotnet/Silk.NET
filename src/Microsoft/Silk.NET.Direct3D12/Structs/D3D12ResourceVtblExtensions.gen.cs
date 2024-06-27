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

public unsafe static class D3D12ResourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12Resource> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Resource> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Resource> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pReadRange, void** ppData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pReadRange, ref void* ppData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDataPtr = &ppData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRange, ppDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pReadRange, void** ppData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Range* pReadRangePtr = &pReadRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pReadRange, ref void* ppData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Range* pReadRangePtr = &pReadRange)
        {
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void**, int>)@this->LpVtbl[8])(@this, Subresource, pReadRangePtr, ppDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Range* pWrittenRange)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRange);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Range pWrittenRange)
    {
        var @this = thisVtbl.Handle;
        fixed (Range* pWrittenRangePtr = &pWrittenRange)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Range*, void>)@this->LpVtbl[9])(@this, Subresource, pWrittenRangePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ResourceDesc GetDesc(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ResourceDesc silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, ResourceDesc*, ResourceDesc*>)@this->LpVtbl[10])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetGPUVirtualAddress(this ComPtr<ID3D12Resource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, ulong>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteToSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)@this->LpVtbl[12])(@this, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource(this ComPtr<ID3D12Resource> thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource(this ComPtr<ID3D12Resource> thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDstDataPtr = &pDstData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReadFromSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, ref T0 pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDstDataPtr = &pDstData)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)@this->LpVtbl[13])(@this, pDstDataPtr, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBoxPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, HeapProperties* pHeapProperties, ref HeapFlags pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapProperties, pHeapFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, ref HeapProperties pHeapProperties, HeapFlags* pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, ref HeapProperties pHeapProperties, ref HeapFlags pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (HeapFlags* pHeapFlagsPtr = &pHeapFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)@this->LpVtbl[14])(@this, pHeapPropertiesPtr, pHeapFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12Resource> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12Resource> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Resource> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12Resource> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12Resource> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Range> pReadRange, void** ppData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(Subresource, in pReadRange.GetPinnableReference(), ppData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Range> pReadRange, ref void* ppData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(Subresource, in pReadRange.GetPinnableReference(), ref ppData);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap(this ComPtr<ID3D12Resource> thisVtbl, uint Subresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Range> pWrittenRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Unmap(Subresource, in pWrittenRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, pDstBox, in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteToSubresource(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, in pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static int WriteToSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteToSubresource(DstSubresource, in pDstBox.GetPinnableReference(), in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource(this ComPtr<ID3D12Resource> thisVtbl, void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadFromSubresource(pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadFromSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, Span<T0> pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadFromSubresource(ref pDstData.GetPinnableReference(), DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static int ReadFromSubresource<T0>(this ComPtr<ID3D12Resource> thisVtbl, Span<T0> pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadFromSubresource(ref pDstData.GetPinnableReference(), DstRowPitch, DstDepthPitch, SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, HeapProperties* pHeapProperties, Span<HeapFlags> pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetHeapProperties(pHeapProperties, ref pHeapFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, Span<HeapProperties> pHeapProperties, HeapFlags* pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetHeapProperties(ref pHeapProperties.GetPinnableReference(), pHeapFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetHeapProperties(this ComPtr<ID3D12Resource> thisVtbl, Span<HeapProperties> pHeapProperties, Span<HeapFlags> pHeapFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetHeapProperties(ref pHeapProperties.GetPinnableReference(), ref pHeapFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12Resource> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12Resource> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
