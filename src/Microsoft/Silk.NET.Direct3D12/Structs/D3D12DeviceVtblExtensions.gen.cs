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

public unsafe static class D3D12DeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeCount(this ComPtr<ID3D12Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandQueuePtr = &ppCommandQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, Guid* riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, Guid* riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, ref Guid riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, ref Guid riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID3D12Device> thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12Device> thisVtbl, Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDescriptorHandleIncrementSize(this ComPtr<ID3D12Device> thisVtbl, DescriptorHeapType DescriptorHeapType)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateConstantBufferView(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateConstantBufferView(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateSampler(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateSampler(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        fixed (SamplerDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptorsSimple(this ComPtr<ID3D12Device> thisVtbl, uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static HeapProperties GetCustomHeapProperties(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, HeapType heapType)
    {
        var @this = thisVtbl.Handle;
        HeapProperties silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        HeapProperties* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D12Pageable* ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D12Pageable* ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppFencePtr = &ppFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceRemovedReason(this ComPtr<ID3D12Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, int>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStablePowerState(this ComPtr<ID3D12Device> thisVtbl, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[40])(@this, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static Luid GetAdapterLuid(this ComPtr<ID3D12Device> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Luid silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Luid* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Luid*, Luid*>)@this->LpVtbl[43])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12Device> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12Device> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandQueue = default;
        return @this->CreateCommandQueue(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Span<Guid> riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(pDesc, ref riid.GetPinnableReference(), ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Span<Guid> riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(pDesc, ref riid.GetPinnableReference(), ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandQueueDesc> pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(in pDesc.GetPinnableReference(), riid, ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandQueue<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandQueue = default;
        return @this->CreateCommandQueue(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandQueueDesc> pDesc, Guid* riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(in pDesc.GetPinnableReference(), riid, ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandQueueDesc> pDesc, Span<Guid> riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandQueueDesc> pDesc, Span<Guid> riid, ref void* ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandQueue(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandQueue);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandAllocator<TI0>(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, out ComPtr<TI0> ppCommandAllocator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandAllocator = default;
        return @this->CreateCommandAllocator(type, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandAllocator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, Span<Guid> riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandAllocator(type, ref riid.GetPinnableReference(), ppCommandAllocator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device> thisVtbl, CommandListType type, Span<Guid> riid, ref void* ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandAllocator(type, ref riid.GetPinnableReference(), ref ppCommandAllocator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateGraphicsPipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(in pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateGraphicsPipelineState(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(in pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGraphicsPipelineState(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateComputePipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(in pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->CreateComputePipelineState(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(in pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateComputePipelineState(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0, TI1, TI2>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, out ComPtr<TI2> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI1> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, ref riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, ref riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, out ComPtr<TI1> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, ID3D12PipelineState* pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), pInitialState, ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), riid, ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCommandList = default;
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Guid* riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), riid, ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, Span<ID3D12CommandAllocator> pCommandAllocator, Span<ID3D12PipelineState> pInitialState, Span<Guid> riid, ref void* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator.GetPinnableReference(), ref pInitialState.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppCommandList);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12Device> thisVtbl, Feature Feature, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckFeatureSupport(Feature, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(pDescriptorHeapDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorHeapDesc> pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(in pDescriptorHeapDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateDescriptorHeap(in pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorHeapDesc> pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(in pDescriptorHeapDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorHeapDesc> pDescriptorHeapDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(in pDescriptorHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorHeapDesc> pDescriptorHeapDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDescriptorHeap(in pDescriptorHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, ref void* ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, riid, ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static int CreateRootSignature<T0, TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvRootSignature = default;
        return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, riid, ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, void** ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, ref riid.GetPinnableReference(), ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlobWithRootSignature, nuint blobLengthInBytes, Span<Guid> riid, ref void* ppvRootSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature.GetPinnableReference(), blobLengthInBytes, ref riid.GetPinnableReference(), ref ppvRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void CreateConstantBufferView(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ConstantBufferViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateConstantBufferView(in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateShaderResourceView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderResourceViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(pResource, in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateShaderResourceView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderResourceViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateShaderResourceView(ref pResource.GetPinnableReference(), in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, (ID3D12Resource*) pCounterResource.Handle, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, pCounterResource, in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, ComPtr<TI1> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, (ID3D12Resource*) pCounterResource.Handle, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, Span<ID3D12Resource> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, ref pCounterResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, ref pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, Span<ID3D12Resource> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(pResource, ref pCounterResource.GetPinnableReference(), in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, ref pCounterResource, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ComPtr<TI0> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView(ref pResource, (ID3D12Resource*) pCounterResource.Handle, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), pCounterResource, in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Resource pResource, ComPtr<TI0> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateUnorderedAccessView(ref pResource, (ID3D12Resource*) pCounterResource.Handle, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, Span<ID3D12Resource> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), ref pCounterResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, Span<ID3D12Resource> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UnorderedAccessViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateUnorderedAccessView(ref pResource.GetPinnableReference(), ref pCounterResource.GetPinnableReference(), in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateRenderTargetView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(pResource, in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateRenderTargetView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderTargetViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateRenderTargetView(ref pResource.GetPinnableReference(), in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateDepthStencilView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DepthStencilViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(pResource, in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CreateDepthStencilView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(ref pResource.GetPinnableReference(), pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DepthStencilViewDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateDepthStencilView(ref pResource.GetPinnableReference(), in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateSampler(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerDesc> pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CreateSampler(in pDesc.GetPinnableReference(), DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), pDestDescriptorRangeSizes, NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptors(this ComPtr<ID3D12Device> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CpuDescriptorHandle> pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyDescriptors(NumDestDescriptorRanges, in pDestDescriptorRangeStarts.GetPinnableReference(), in pDestDescriptorRangeSizes.GetPinnableReference(), NumSrcDescriptorRanges, in pSrcDescriptorRangeStarts.GetPinnableReference(), in pSrcDescriptorRangeSizes.GetPinnableReference(), DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceAllocationInfo(visibleMask, numResourceDescs, in pResourceDescs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, pOptimizedClearValue, ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), riidResource, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapProperties> pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riidResource, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommittedResource(in pHeapProperties.GetPinnableReference(), HeapFlags, in pDesc.GetPinnableReference(), InitialResourceState, in pOptimizedClearValue.GetPinnableReference(), ref riidResource.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(pDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(pDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapDesc> pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(in pDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateHeap(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapDesc> pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(in pDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapDesc> pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HeapDesc> pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateHeap(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, ref riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, ref riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, ref riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, ref riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, ref riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(pHeap, HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, ref riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Heap> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePlacedResource(ref pHeap.GetPinnableReference(), HeapOffset, in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, pOptimizedClearValue, ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static int CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResource = default;
        return @this->CreateReservedResource(in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Guid* riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), riid, ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ClearValue> pOptimizedClearValue, Span<Guid> riid, ref void* ppvResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateReservedResource(in pDesc.GetPinnableReference(), InitialState, in pOptimizedClearValue.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, pAttributes, Access, in Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, in Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, pAttributes, Access, in Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, in Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, in Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, in Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, in Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, in Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(pObject, in pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, in Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, in Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), pAttributes, Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, in Name.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, in Name.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, Name, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12DeviceChild> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.SecurityAttributes> pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSharedHandle(ref pObject.GetPinnableReference(), in pAttributes.GetPinnableReference(), Access, Name, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->OpenSharedHandle(NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(NTHandle, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(NTHandle, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<T0> NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int OpenSharedHandle<T0, TI0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle, out ComPtr<TI0> ppvObj) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->OpenSharedHandle(ref NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<T0> NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<T0> NTHandle, Span<Guid> riid, void** ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0>(this ComPtr<ID3D12Device> thisVtbl, Span<T0> NTHandle, Span<Guid> riid, ref void* ppvObj) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandle(ref NTHandle.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandleByName(in Name.GetPinnableReference(), Access, pNTHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name, uint Access, ref void* pNTHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OpenSharedHandleByName(in Name.GetPinnableReference(), Access, ref pNTHandle);
    }

    /// <summary>To be documented.</summary>
    public static int MakeResident<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MakeResident(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Evict<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Evict(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFence<TI0>(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, out ComPtr<TI0> ppFence) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppFence = default;
        return @this->CreateFence(InitialValue, Flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppFence.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, Span<Guid> riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFence(InitialValue, Flags, ref riid.GetPinnableReference(), ppFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags, Span<Guid> riid, ref void* ppFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFence(InitialValue, Flags, ref riid.GetPinnableReference(), ref ppFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, pLayouts, ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, uint* pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), pNumRows, ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, ulong* pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), pRowSizeInBytes, ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static void GetCopyableFootprints(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, Span<PlacedSubresourceFootprint> pLayouts, Span<uint> pNumRows, Span<ulong> pRowSizeInBytes, Span<ulong> pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCopyableFootprints(in pResourceDesc.GetPinnableReference(), FirstSubresource, NumSubresources, BaseOffset, ref pLayouts.GetPinnableReference(), ref pNumRows.GetPinnableReference(), ref pRowSizeInBytes.GetPinnableReference(), ref pTotalBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateQueryHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(pDesc, ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(pDesc, ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryHeapDesc> pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(in pDesc.GetPinnableReference(), riid, ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueryHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvHeap = default;
        return @this->CreateQueryHeap(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryHeapDesc> pDesc, Guid* riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(in pDesc.GetPinnableReference(), riid, ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryHeapDesc> pDesc, Span<Guid> riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QueryHeapDesc> pDesc, Span<Guid> riid, ref void* ppvHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateQueryHeap(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, out ComPtr<TI1> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, pRootSignature, ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, void** ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, pRootSignature, ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(pDesc, ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), pRootSignature, riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandSignature<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, out ComPtr<TI1> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), pRootSignature, riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), pRootSignature, ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, void** ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, ID3D12RootSignature* pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), pRootSignature, ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), riid, ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvCommandSignature = default;
        return @this->CreateCommandSignature(in pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Guid* riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), riid, ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandSignatureDesc> pDesc, Span<ID3D12RootSignature> pRootSignature, Span<Guid> riid, ref void* ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCommandSignature(in pDesc.GetPinnableReference(), ref pRootSignature.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvCommandSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, ID3D12Resource* pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(pTiledResource, ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling<TI0>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, uint* pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), pNumTilesForEntireResource, ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), pPackedMipDesc, ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling(this ComPtr<ID3D12Device> thisVtbl, Span<ID3D12Resource> pTiledResource, Span<uint> pNumTilesForEntireResource, Span<PackedMipInfo> pPackedMipDesc, Span<TileShape> pStandardTileShapeForNonPackedMips, Span<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Span<SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetResourceTiling(ref pTiledResource.GetPinnableReference(), ref pNumTilesForEntireResource.GetPinnableReference(), ref pPackedMipDesc.GetPinnableReference(), ref pStandardTileShapeForNonPackedMips.GetPinnableReference(), ref pNumSubresourceTilings.GetPinnableReference(), FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12Device> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandQueue<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandQueue(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandQueue<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandQueueDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandQueue(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandAllocator<TI0>(this ComPtr<ID3D12Device> thisVtbl, CommandListType type) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandAllocator(type, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateGraphicsPipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateComputePipelineState<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI2> CreateCommandList<TI0, TI1, TI2>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, out ComPtr<TI2> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateCommandList<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, pInitialState, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandList<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDescriptorHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DescriptorHeapDesc pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(in pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateRootSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateRootSignature<T0, TI0>(this ComPtr<ID3D12Device> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pBlobWithRootSignature, nuint blobLengthInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, in pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommittedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly HeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateHeap(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreatePlacedResource<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreatePlacedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateReservedResource<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateReservedResource(in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenSharedHandle<TI0>(this ComPtr<ID3D12Device> thisVtbl, void* NTHandle) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenSharedHandle(NTHandle, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenSharedHandle<T0, TI0>(this ComPtr<ID3D12Device> thisVtbl, ref T0 NTHandle) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenSharedHandle(ref NTHandle, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateFence<TI0>(this ComPtr<ID3D12Device> thisVtbl, ulong InitialValue, FenceFlags Flags) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateFence(InitialValue, Flags, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateQueryHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryHeap(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateQueryHeap<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly QueryHeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueryHeap(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateCommandSignature<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, pRootSignature, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateCommandSignature<TI0, TI1>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(in pDesc, pRootSignature, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateCommandSignature<TI0>(this ComPtr<ID3D12Device> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateCommandSignature(in pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
