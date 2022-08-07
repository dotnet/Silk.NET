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

public unsafe static class D3D12GraphicsCommandList5VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset<TThis>(this TThis thisVtbl, ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset<TThis>(this TThis thisVtbl, ID3D12CommandAllocator* pAllocator, ref ID3D12PipelineState pInitialState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset<TThis>(this TThis thisVtbl, ref ID3D12CommandAllocator pAllocator, ID3D12PipelineState* pInitialState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TThis>(this TThis thisVtbl, ref ID3D12CommandAllocator pAllocator, ref ID3D12PipelineState pInitialState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearState<TThis>(this TThis thisVtbl, ID3D12PipelineState* pPipelineState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static void ClearState<TThis>(this TThis thisVtbl, ref ID3D12PipelineState pPipelineState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced<TThis>(this TThis thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, uint, uint, void>)@this->LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced<TThis>(this TThis thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, uint, int, uint, void>)@this->LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch<TThis>(this TThis thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, uint, void>)@this->LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyBufferRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pSrcPtr = &pSrc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pSrcPtr = &pSrc)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion<TThis>(this TThis thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTextureRegion<TThis>(this TThis thisVtbl, ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TextureCopyLocation* pDstPtr = &pDst)
        {
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref ID3D12Resource pSrcResource) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ID3D12Resource* pSrcResource) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref ID3D12Resource pSrcResource) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[20])(@this, PrimitiveTopology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports<TThis>(this TThis thisVtbl, uint NumViewports, Viewport* pViewports) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports<TThis>(this TThis thisVtbl, uint NumViewports, ref Viewport pViewports) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects<TThis>(this TThis thisVtbl, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects<TThis>(this TThis thisVtbl, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendFactor<TThis>(this TThis thisVtbl, [Count(Count = 4)] float* BlendFactor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, float*, void>)@this->LpVtbl[23])(@this, BlendFactor);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendFactor<TThis>(this TThis thisVtbl, [Count(Count = 4)] ref float BlendFactor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, float*, void>)@this->LpVtbl[23])(@this, BlendFactorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetStencilRef<TThis>(this TThis thisVtbl, uint StencilRef) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void>)@this->LpVtbl[24])(@this, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPipelineState<TThis>(this TThis thisVtbl, ID3D12PipelineState* pPipelineState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineState<TThis>(this TThis thisVtbl, ref ID3D12PipelineState pPipelineState) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier<TThis>(this TThis thisVtbl, uint NumBarriers, ResourceBarrier* pBarriers) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier<TThis>(this TThis thisVtbl, uint NumBarriers, ref ResourceBarrier pBarriers) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteBundle<TThis>(this TThis thisVtbl, ID3D12GraphicsCommandList* pCommandList) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandList);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteBundle<TThis>(this TThis thisVtbl, ref ID3D12GraphicsCommandList pCommandList) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12GraphicsCommandList* pCommandListPtr = &pCommandList)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandListPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescriptorHeaps<TThis>(this TThis thisVtbl, uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescriptorHeaps<TThis>(this TThis thisVtbl, uint NumDescriptorHeaps, ref ID3D12DescriptorHeap* ppDescriptorHeaps) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12DescriptorHeap** ppDescriptorHeapsPtr = &ppDescriptorHeaps)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRootSignature<TThis>(this TThis thisVtbl, ID3D12RootSignature* pRootSignature) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootSignature<TThis>(this TThis thisVtbl, ref ID3D12RootSignature pRootSignature) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignaturePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRootSignature<TThis>(this TThis thisVtbl, ID3D12RootSignature* pRootSignature) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootSignature<TThis>(this TThis thisVtbl, ref ID3D12RootSignature pRootSignature) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignaturePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootDescriptorTable<TThis>(this TThis thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootDescriptorTable<TThis>(this TThis thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstant<TThis>(this TThis thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, uint, void>)@this->LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstant<TThis>(this TThis thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, uint, void>)@this->LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRoot32BitConstants<TThis>(this TThis thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstants<T0, TThis>(this TThis thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRoot32BitConstants<TThis>(this TThis thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstants<T0, TThis>(this TThis thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootConstantBufferView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootConstantBufferView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootShaderResourceView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootShaderResourceView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootUnorderedAccessView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootUnorderedAccessView<TThis>(this TThis thisVtbl, uint RootParameterIndex, ulong BufferLocation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, ulong, void>)@this->LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer<TThis>(this TThis thisVtbl, IndexBufferView* pView) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pView);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer<TThis>(this TThis thisVtbl, ref IndexBufferView pView) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (IndexBufferView* pViewPtr = &pView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, VertexBufferView* pViews) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref VertexBufferView pViews) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (VertexBufferView* pViewsPtr = &pViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, StreamOutputBufferView* pViews) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static void SOSetTargets<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref StreamOutputBufferView pViews) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (StreamOutputBufferView* pViewsPtr = &pViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
        {
            fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView<TThis>(this TThis thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView<TThis>(this TThis thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView<TThis>(this TThis thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (uint* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (uint* ValuesPtr = &Values)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (float* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (float* ValuesPtr = &Values)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (float* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, DiscardRegion* pRegion) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref DiscardRegion pRegion) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, DiscardRegion* pRegion) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref DiscardRegion pRegion) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication<TThis>(this TThis thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TThis>(this TThis thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
        {
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect<TThis>(this TThis thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteIndirect<TThis>(this TThis thisVtbl, ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
        {
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthBounds<TThis>(this TThis thisVtbl, float Min, float Max) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, float, float, void>)@this->LpVtbl[62])(@this, Min, Max);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSamplePositions<TThis>(this TThis thisVtbl, uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
    }

    /// <summary>To be documented.</summary>
    public static void SetSamplePositions<TThis>(this TThis thisVtbl, uint NumSamplesPerPixel, uint NumPixels, ref SamplePosition pSamplePositions) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (SamplePosition* pSamplePositionsPtr = &pSamplePositions)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetViewInstanceMask<TThis>(this TThis thisVtbl, uint Mask) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, void>)@this->LpVtbl[65])(@this, Mask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetProtectedResourceSession<TThis>(this TThis thisVtbl, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[67])(@this, pProtectedResourceSession);
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession<TThis>(this TThis thisVtbl, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[67])(@this, pProtectedResourceSessionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginRenderPass<TThis>(this TThis thisVtbl, uint NumRenderTargets, RenderPassRenderTargetDesc* pRenderTargets, RenderPassDepthStencilDesc* pDepthStencil, RenderPassFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, RenderPassRenderTargetDesc*, RenderPassDepthStencilDesc*, RenderPassFlags, void>)@this->LpVtbl[68])(@this, NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginRenderPass<TThis>(this TThis thisVtbl, uint NumRenderTargets, RenderPassRenderTargetDesc* pRenderTargets, ref RenderPassDepthStencilDesc pDepthStencil, RenderPassFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RenderPassDepthStencilDesc* pDepthStencilPtr = &pDepthStencil)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, RenderPassRenderTargetDesc*, RenderPassDepthStencilDesc*, RenderPassFlags, void>)@this->LpVtbl[68])(@this, NumRenderTargets, pRenderTargets, pDepthStencilPtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginRenderPass<TThis>(this TThis thisVtbl, uint NumRenderTargets, ref RenderPassRenderTargetDesc pRenderTargets, RenderPassDepthStencilDesc* pDepthStencil, RenderPassFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RenderPassRenderTargetDesc* pRenderTargetsPtr = &pRenderTargets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, RenderPassRenderTargetDesc*, RenderPassDepthStencilDesc*, RenderPassFlags, void>)@this->LpVtbl[68])(@this, NumRenderTargets, pRenderTargetsPtr, pDepthStencil, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BeginRenderPass<TThis>(this TThis thisVtbl, uint NumRenderTargets, ref RenderPassRenderTargetDesc pRenderTargets, ref RenderPassDepthStencilDesc pDepthStencil, RenderPassFlags Flags) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RenderPassRenderTargetDesc* pRenderTargetsPtr = &pRenderTargets)
        {
            fixed (RenderPassDepthStencilDesc* pDepthStencilPtr = &pDepthStencil)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, uint, RenderPassRenderTargetDesc*, RenderPassDepthStencilDesc*, RenderPassFlags, void>)@this->LpVtbl[68])(@this, NumRenderTargets, pRenderTargetsPtr, pDepthStencilPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndRenderPass<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, void>)@this->LpVtbl[69])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeMetaCommand<TThis>(this TThis thisVtbl, ID3D12MetaCommand* pMetaCommand, void* pInitializationParametersData, nuint InitializationParametersDataSizeInBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[70])(@this, pMetaCommand, pInitializationParametersData, InitializationParametersDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeMetaCommand<T0, TThis>(this TThis thisVtbl, ID3D12MetaCommand* pMetaCommand, ref T0 pInitializationParametersData, nuint InitializationParametersDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pInitializationParametersDataPtr = &pInitializationParametersData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[70])(@this, pMetaCommand, pInitializationParametersDataPtr, InitializationParametersDataSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeMetaCommand<TThis>(this TThis thisVtbl, ref ID3D12MetaCommand pMetaCommand, void* pInitializationParametersData, nuint InitializationParametersDataSizeInBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12MetaCommand* pMetaCommandPtr = &pMetaCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[70])(@this, pMetaCommandPtr, pInitializationParametersData, InitializationParametersDataSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void InitializeMetaCommand<T0, TThis>(this TThis thisVtbl, ref ID3D12MetaCommand pMetaCommand, ref T0 pInitializationParametersData, nuint InitializationParametersDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12MetaCommand* pMetaCommandPtr = &pMetaCommand)
        {
            fixed (void* pInitializationParametersDataPtr = &pInitializationParametersData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[70])(@this, pMetaCommandPtr, pInitializationParametersDataPtr, InitializationParametersDataSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteMetaCommand<TThis>(this TThis thisVtbl, ID3D12MetaCommand* pMetaCommand, void* pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[71])(@this, pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteMetaCommand<T0, TThis>(this TThis thisVtbl, ID3D12MetaCommand* pMetaCommand, ref T0 pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (void* pExecutionParametersDataPtr = &pExecutionParametersData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[71])(@this, pMetaCommand, pExecutionParametersDataPtr, ExecutionParametersDataSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteMetaCommand<TThis>(this TThis thisVtbl, ref ID3D12MetaCommand pMetaCommand, void* pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12MetaCommand* pMetaCommandPtr = &pMetaCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[71])(@this, pMetaCommandPtr, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteMetaCommand<T0, TThis>(this TThis thisVtbl, ref ID3D12MetaCommand pMetaCommand, ref T0 pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12MetaCommand* pMetaCommandPtr = &pMetaCommand)
        {
            fixed (void* pExecutionParametersDataPtr = &pExecutionParametersData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[71])(@this, pMetaCommandPtr, pExecutionParametersDataPtr, ExecutionParametersDataSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BuildRaytracingAccelerationStructure<TThis>(this TThis thisVtbl, BuildRaytracingAccelerationStructureDesc* pDesc, uint NumPostbuildInfoDescs, RaytracingAccelerationStructurePostbuildInfoDesc* pPostbuildInfoDescs) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, BuildRaytracingAccelerationStructureDesc*, uint, RaytracingAccelerationStructurePostbuildInfoDesc*, void>)@this->LpVtbl[72])(@this, pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BuildRaytracingAccelerationStructure<TThis>(this TThis thisVtbl, BuildRaytracingAccelerationStructureDesc* pDesc, uint NumPostbuildInfoDescs, ref RaytracingAccelerationStructurePostbuildInfoDesc pPostbuildInfoDescs) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RaytracingAccelerationStructurePostbuildInfoDesc* pPostbuildInfoDescsPtr = &pPostbuildInfoDescs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, BuildRaytracingAccelerationStructureDesc*, uint, RaytracingAccelerationStructurePostbuildInfoDesc*, void>)@this->LpVtbl[72])(@this, pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BuildRaytracingAccelerationStructure<TThis>(this TThis thisVtbl, ref BuildRaytracingAccelerationStructureDesc pDesc, uint NumPostbuildInfoDescs, RaytracingAccelerationStructurePostbuildInfoDesc* pPostbuildInfoDescs) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (BuildRaytracingAccelerationStructureDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, BuildRaytracingAccelerationStructureDesc*, uint, RaytracingAccelerationStructurePostbuildInfoDesc*, void>)@this->LpVtbl[72])(@this, pDescPtr, NumPostbuildInfoDescs, pPostbuildInfoDescs);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BuildRaytracingAccelerationStructure<TThis>(this TThis thisVtbl, ref BuildRaytracingAccelerationStructureDesc pDesc, uint NumPostbuildInfoDescs, ref RaytracingAccelerationStructurePostbuildInfoDesc pPostbuildInfoDescs) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (BuildRaytracingAccelerationStructureDesc* pDescPtr = &pDesc)
        {
            fixed (RaytracingAccelerationStructurePostbuildInfoDesc* pPostbuildInfoDescsPtr = &pPostbuildInfoDescs)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, BuildRaytracingAccelerationStructureDesc*, uint, RaytracingAccelerationStructurePostbuildInfoDesc*, void>)@this->LpVtbl[72])(@this, pDescPtr, NumPostbuildInfoDescs, pPostbuildInfoDescsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EmitRaytracingAccelerationStructurePostbuildInfo<TThis>(this TThis thisVtbl, RaytracingAccelerationStructurePostbuildInfoDesc* pDesc, uint NumSourceAccelerationStructures, ulong* pSourceAccelerationStructureData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, RaytracingAccelerationStructurePostbuildInfoDesc*, uint, ulong*, void>)@this->LpVtbl[73])(@this, pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EmitRaytracingAccelerationStructurePostbuildInfo<TThis>(this TThis thisVtbl, RaytracingAccelerationStructurePostbuildInfoDesc* pDesc, uint NumSourceAccelerationStructures, ref ulong pSourceAccelerationStructureData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ulong* pSourceAccelerationStructureDataPtr = &pSourceAccelerationStructureData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, RaytracingAccelerationStructurePostbuildInfoDesc*, uint, ulong*, void>)@this->LpVtbl[73])(@this, pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureDataPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EmitRaytracingAccelerationStructurePostbuildInfo<TThis>(this TThis thisVtbl, ref RaytracingAccelerationStructurePostbuildInfoDesc pDesc, uint NumSourceAccelerationStructures, ulong* pSourceAccelerationStructureData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RaytracingAccelerationStructurePostbuildInfoDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, RaytracingAccelerationStructurePostbuildInfoDesc*, uint, ulong*, void>)@this->LpVtbl[73])(@this, pDescPtr, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EmitRaytracingAccelerationStructurePostbuildInfo<TThis>(this TThis thisVtbl, ref RaytracingAccelerationStructurePostbuildInfoDesc pDesc, uint NumSourceAccelerationStructures, ref ulong pSourceAccelerationStructureData) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (RaytracingAccelerationStructurePostbuildInfoDesc* pDescPtr = &pDesc)
        {
            fixed (ulong* pSourceAccelerationStructureDataPtr = &pSourceAccelerationStructureData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, RaytracingAccelerationStructurePostbuildInfoDesc*, uint, ulong*, void>)@this->LpVtbl[73])(@this, pDescPtr, NumSourceAccelerationStructures, pSourceAccelerationStructureDataPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyRaytracingAccelerationStructure<TThis>(this TThis thisVtbl, ulong DestAccelerationStructureData, ulong SourceAccelerationStructureData, RaytracingAccelerationStructureCopyMode Mode) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ulong, ulong, RaytracingAccelerationStructureCopyMode, void>)@this->LpVtbl[74])(@this, DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPipelineState1<TThis>(this TThis thisVtbl, ID3D12StateObject* pStateObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12StateObject*, void>)@this->LpVtbl[75])(@this, pStateObject);
    }

    /// <summary>To be documented.</summary>
    public static void SetPipelineState1<TThis>(this TThis thisVtbl, ref ID3D12StateObject pStateObject) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12StateObject* pStateObjectPtr = &pStateObject)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12StateObject*, void>)@this->LpVtbl[75])(@this, pStateObjectPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DispatchRays<TThis>(this TThis thisVtbl, DispatchRaysDesc* pDesc) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, DispatchRaysDesc*, void>)@this->LpVtbl[76])(@this, pDesc);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchRays<TThis>(this TThis thisVtbl, ref DispatchRaysDesc pDesc) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (DispatchRaysDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, DispatchRaysDesc*, void>)@this->LpVtbl[76])(@this, pDescPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetShadingRate<TThis>(this TThis thisVtbl, ShadingRate baseShadingRate, ShadingRateCombiner* combiners) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ShadingRate, ShadingRateCombiner*, void>)@this->LpVtbl[77])(@this, baseShadingRate, combiners);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetShadingRate<TThis>(this TThis thisVtbl, ShadingRate baseShadingRate, ref ShadingRateCombiner combiners) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ShadingRateCombiner* combinersPtr = &combiners)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ShadingRate, ShadingRateCombiner*, void>)@this->LpVtbl[77])(@this, baseShadingRate, combinersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetShadingRateImage<TThis>(this TThis thisVtbl, ID3D12Resource* shadingRateImage) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, void>)@this->LpVtbl[78])(@this, shadingRateImage);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetShadingRateImage<TThis>(this TThis thisVtbl, ref ID3D12Resource shadingRateImage) where TThis : IComVtbl<ID3D12GraphicsCommandList5>
    {
        var @this = (ID3D12GraphicsCommandList5*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* shadingRateImagePtr = &shadingRateImage)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList5*, ID3D12Resource*, void>)@this->LpVtbl[78])(@this, shadingRateImagePtr);
        }
    }

}
