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

public unsafe static class D3D12Device7VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppCommandQueuePtr = &ppCommandQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, ref CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, ref CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, ref CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue<TThis>(this TThis thisVtbl, ref CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandQueueDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator<TThis>(this TThis thisVtbl, CommandListType type, Guid* riid, void** ppCommandAllocator) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator<TThis>(this TThis thisVtbl, CommandListType type, Guid* riid, ref void* ppCommandAllocator) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator<TThis>(this TThis thisVtbl, CommandListType type, ref Guid riid, void** ppCommandAllocator) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator<TThis>(this TThis thisVtbl, CommandListType type, ref Guid riid, ref void* ppCommandAllocator) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState<TThis>(this TThis thisVtbl, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState<TThis>(this TThis thisVtbl, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
        {
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport<TThis>(this TThis thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap<TThis>(this TThis thisVtbl, ref DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDescriptorHandleIncrementSize<TThis>(this TThis thisVtbl, DescriptorHeapType DescriptorHeapType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TThis>(this TThis thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TThis>(this TThis thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TThis>(this TThis thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<TThis>(this TThis thisVtbl, uint nodeMask, void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0, TThis>(this TThis thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0, TThis>(this TThis thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0, TThis>(this TThis thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature<T0, TThis>(this TThis thisVtbl, uint nodeMask, ref T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateConstantBufferView<TThis>(this TThis thisVtbl, ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateConstantBufferView<TThis>(this TThis thisVtbl, ref ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateShaderResourceView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateUnorderedAccessView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, ref UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateRenderTargetView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CreateDepthStencilView<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateSampler<TThis>(this TThis thisVtbl, SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void CreateSampler<TThis>(this TThis thisVtbl, ref SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (SamplerDesc* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDescPtr, DestDescriptor);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, CpuDescriptorHandle* pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, CpuDescriptorHandle* pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptors<TThis>(this TThis thisVtbl, uint NumDestDescriptorRanges, ref CpuDescriptorHandle pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref CpuDescriptorHandle pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
        {
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptorsSimple<TThis>(this TThis thisVtbl, uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static HeapProperties GetCustomHeapProperties<TThis>(this TThis thisVtbl, uint nodeMask, HeapType heapType) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        HeapProperties silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        HeapProperties* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, HeapDesc* pDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, HeapDesc* pDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource<TThis>(this TThis thisVtbl, ref ID3D12Heap pHeap, ulong HeapOffset, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ID3D12DeviceChild* pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, char* Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, ref char Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
            }
        SilkMarshal.Free((nint)NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, char* Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, ref char Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle<TThis>(this TThis thisVtbl, ref ID3D12DeviceChild pObject, ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
        SilkMarshal.Free((nint)NamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TThis>(this TThis thisVtbl, void* NTHandle, Guid* riid, void** ppvObj) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TThis>(this TThis thisVtbl, void* NTHandle, Guid* riid, ref void* ppvObj) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TThis>(this TThis thisVtbl, void* NTHandle, ref Guid riid, void** ppvObj) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<TThis>(this TThis thisVtbl, void* NTHandle, ref Guid riid, ref void* ppvObj) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0, TThis>(this TThis thisVtbl, ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0, TThis>(this TThis thisVtbl, ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0, TThis>(this TThis thisVtbl, ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle<T0, TThis>(this TThis thisVtbl, ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* NTHandlePtr = &NTHandle)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, char* Name, uint Access, void** pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, char* Name, uint Access, ref void* pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, ref char Name, uint Access, void** pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, ref char Name, uint Access, ref void* pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, void** pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, ref void* pNTHandle) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        fixed (void** pNTHandlePtr = &pNTHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident<TThis>(this TThis thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident<TThis>(this TThis thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict<TThis>(this TThis thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict<TThis>(this TThis thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence<TThis>(this TThis thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence<TThis>(this TThis thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppFencePtr = &ppFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence<TThis>(this TThis thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence<TThis>(this TThis thisVtbl, ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceRemovedReason<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, int>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRowsPtr = &pNumRows)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetCopyableFootprints<TThis>(this TThis thisVtbl, ref ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, ref QueryHeapDesc pDesc, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, ref QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, ref QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap<TThis>(this TThis thisVtbl, ref QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueryHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStablePowerState<TThis>(this TThis thisVtbl, int Enable) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, int, int>)@this->LpVtbl[40])(@this, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature<TThis>(this TThis thisVtbl, ref CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (CommandSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetResourceTiling<TThis>(this TThis thisVtbl, ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static Luid GetAdapterLuid<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        Luid ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Luid>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<TThis>(this TThis thisVtbl, void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<TThis>(this TThis thisVtbl, void* pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibraryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<TThis>(this TThis thisVtbl, void* pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibrary);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<TThis>(this TThis thisVtbl, void* pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibraryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0, TThis>(this TThis thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibrary);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0, TThis>(this TThis thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibraryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0, TThis>(this TThis thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibrary);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary<T0, TThis>(this TThis thisVtbl, ref T0 pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pLibraryBlobPtr = &pLibraryBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibraryPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TThis>(this TThis thisVtbl, ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0, TThis>(this TThis thisVtbl, ID3D12Fence** ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEventPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TThis>(this TThis thisVtbl, ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pFenceValuesPtr = &pFenceValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEvent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0, TThis>(this TThis thisVtbl, ID3D12Fence** ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pFenceValuesPtr = &pFenceValues)
        {
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEventPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TThis>(this TThis thisVtbl, ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEvent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0, TThis>(this TThis thisVtbl, ref ID3D12Fence* ppFences, ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEventPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<TThis>(this TThis thisVtbl, ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEvent);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion<T0, TThis>(this TThis thisVtbl, ref ID3D12Fence* ppFences, ref ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence** ppFencesPtr = &ppFences)
        {
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority<TThis>(this TThis thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects, ResidencyPriority* pPriorities) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPriorities);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority<TThis>(this TThis thisVtbl, uint NumObjects, ID3D12Pageable** ppObjects, ref ResidencyPriority pPriorities) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPrioritiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority<TThis>(this TThis thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects, ResidencyPriority* pPriorities) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPriorities);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority<TThis>(this TThis thisVtbl, uint NumObjects, ref ID3D12Pageable* ppObjects, ref ResidencyPriority pPriorities) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPrioritiesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState<TThis>(this TThis thisVtbl, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<TThis>(this TThis thisVtbl, void* pAddress, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<TThis>(this TThis thisVtbl, void* pAddress, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<TThis>(this TThis thisVtbl, void* pAddress, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<TThis>(this TThis thisVtbl, void* pAddress, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0, TThis>(this TThis thisVtbl, ref T0 pAddress, Guid* riid, void** ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0, TThis>(this TThis thisVtbl, ref T0 pAddress, Guid* riid, ref void* ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0, TThis>(this TThis thisVtbl, ref T0 pAddress, ref Guid riid, void** ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress<T0, TThis>(this TThis thisVtbl, ref T0 pAddress, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pAddressPtr = &pAddress)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<TThis>(this TThis thisVtbl, void* hFileMapping, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<TThis>(this TThis thisVtbl, void* hFileMapping, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<TThis>(this TThis thisVtbl, void* hFileMapping, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<TThis>(this TThis thisVtbl, void* hFileMapping, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0, TThis>(this TThis thisVtbl, ref T0 hFileMapping, Guid* riid, void** ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0, TThis>(this TThis thisVtbl, ref T0 hFileMapping, Guid* riid, ref void* ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0, TThis>(this TThis thisVtbl, ref T0 hFileMapping, ref Guid riid, void** ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping<T0, TThis>(this TThis thisVtbl, ref T0 hFileMapping, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hFileMappingPtr = &hFileMapping)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident<TThis>(this TThis thisVtbl, ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident<TThis>(this TThis thisVtbl, ResidencyFlags Flags, uint NumObjects, ID3D12Pageable** ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignalPtr, FenceValueToSignal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident<TThis>(this TThis thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignal, FenceValueToSignal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident<TThis>(this TThis thisVtbl, ResidencyFlags Flags, uint NumObjects, ref ID3D12Pageable* ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
        {
            fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignalPtr, FenceValueToSignal);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, void** ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1<TThis>(this TThis thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, ref void* ppCommandList) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc* pDesc, Guid* riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc* pDesc, Guid* riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc* pDesc, ref Guid riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc* pDesc, ref Guid riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc pDesc, Guid* riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc pDesc, Guid* riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc pDesc, ref Guid riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc pDesc, ref Guid riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, HeapProperties* pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ResourceDesc* pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1<TThis>(this TThis thisVtbl, ref HeapProperties pHeapProperties, HeapFlags HeapFlags, ref ResourceDesc pDesc, ResourceStates InitialResourceState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
        {
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvHeapPtr = &ppvHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1<TThis>(this TThis thisVtbl, ref HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (HeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ResourceDesc* pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1<TThis>(this TThis thisVtbl, ref ResourceDesc pDesc, ResourceStates InitialState, ref ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ResourceDesc* pDescPtr = &pDesc)
        {
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ResourceDesc* pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1Ptr);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1);
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static ResourceAllocationInfo GetResourceAllocationInfo1<TThis>(this TThis thisVtbl, uint visibleMask, uint numResourceDescs, ref ResourceDesc pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
        {
            fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1Ptr);
            }
        }
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ID3D12LifetimeOwner* pOwner, Guid* riid, void** ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTracker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ID3D12LifetimeOwner* pOwner, Guid* riid, ref void* ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvTrackerPtr = &ppvTracker)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTrackerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ID3D12LifetimeOwner* pOwner, ref Guid riid, void** ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTracker);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ID3D12LifetimeOwner* pOwner, ref Guid riid, ref void* ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTrackerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ref ID3D12LifetimeOwner pOwner, Guid* riid, void** ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTracker);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ref ID3D12LifetimeOwner pOwner, Guid* riid, ref void* ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTrackerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ref ID3D12LifetimeOwner pOwner, ref Guid riid, void** ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTracker);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker<TThis>(this TThis thisVtbl, ref ID3D12LifetimeOwner pOwner, ref Guid riid, ref void* ppvTracker) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTrackerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void RemoveDevice<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands<TThis>(this TThis thisVtbl, uint* pNumMetaCommands, MetaCommandDesc* pDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands<TThis>(this TThis thisVtbl, uint* pNumMetaCommands, ref MetaCommandDesc pDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MetaCommandDesc* pDescsPtr = &pDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands<TThis>(this TThis thisVtbl, ref uint pNumMetaCommands, MetaCommandDesc* pDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommands<TThis>(this TThis thisVtbl, ref uint pNumMetaCommands, ref MetaCommandDesc pDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
        {
            fixed (MetaCommandDesc* pDescsPtr = &pDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pParameterCountPtr = &pParameterCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pParameterCountPtr = &pParameterCount)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumerateMetaCommandParameters<TThis>(this TThis thisVtbl, ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppMetaCommandPtr = &ppMetaCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, Guid* CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand<T0, TThis>(this TThis thisVtbl, ref Guid CommandId, uint NodeMask, ref T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* CommandIdPtr = &CommandId)
        {
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pDesc, Guid* riid, void** ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pDesc, Guid* riid, ref void* ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppStateObjectPtr = &ppStateObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pDesc, ref Guid riid, void** ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pDesc, ref Guid riid, ref void* ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pDesc, Guid* riid, void** ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pDesc, Guid* riid, ref void* ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pDesc, ref Guid riid, void** ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pDesc, ref Guid riid, ref void* ppStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo<TThis>(this TThis thisVtbl, BuildRaytracingAccelerationStructureInputs* pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo<TThis>(this TThis thisVtbl, BuildRaytracingAccelerationStructureInputs* pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfoPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo<TThis>(this TThis thisVtbl, ref BuildRaytracingAccelerationStructureInputs pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfo);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetRaytracingAccelerationStructurePrebuildInfo<TThis>(this TThis thisVtbl, ref BuildRaytracingAccelerationStructureInputs pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
        {
            fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfoPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier<TThis>(this TThis thisVtbl, SerializedDataType SerializedDataType, SerializedDataDriverMatchingIdentifier* pIdentifierToCheck) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        DriverMatchingIdentifierStatus ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheck);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier<TThis>(this TThis thisVtbl, SerializedDataType SerializedDataType, ref SerializedDataDriverMatchingIdentifier pIdentifierToCheck) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        DriverMatchingIdentifierStatus ret = default;
        fixed (SerializedDataDriverMatchingIdentifier* pIdentifierToCheckPtr = &pIdentifierToCheck)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheckPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode<TThis>(this TThis thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode<TThis>(this TThis thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesiredPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode<T0, TThis>(this TThis thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesired);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundProcessingMode<T0, TThis>(this TThis thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired) where T0 : unmanaged where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
        {
            fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesiredPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, StateObjectDesc* pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riid, ppNewStateObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ID3D12StateObject* pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFrom, riidPtr, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, Guid* riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riid, ppNewStateObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, void** ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObject);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject<TThis>(this TThis thisVtbl, ref StateObjectDesc pAddition, ref ID3D12StateObject pStateObjectToGrowFrom, ref Guid riid, ref void* ppNewStateObject) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (StateObjectDesc* pAdditionPtr = &pAddition)
        {
            fixed (ID3D12StateObject* pStateObjectToGrowFromPtr = &pStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewStateObjectPtr = &ppNewStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAdditionPtr, pStateObjectToGrowFromPtr, riidPtr, ppNewStateObjectPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc1* pDesc, Guid* riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc1* pDesc, Guid* riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riid, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc1* pDesc, ref Guid riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riidPtr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ProtectedResourceSessionDesc1* pDesc, ref Guid riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riidPtr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riid, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, Guid* riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riid, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, void** ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riidPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1<TThis>(this TThis thisVtbl, ref ProtectedResourceSessionDesc1 pDesc, ref Guid riid, ref void* ppSession) where TThis : IComVtbl<ID3D12Device7>
    {
        var @this = (ID3D12Device7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ProtectedResourceSessionDesc1* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device7*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDescPtr, riidPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

}
