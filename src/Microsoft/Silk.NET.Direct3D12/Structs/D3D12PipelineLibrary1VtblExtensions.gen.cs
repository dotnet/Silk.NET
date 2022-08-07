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

public unsafe static class D3D12PipelineLibrary1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline<TThis>(this TThis thisVtbl, char* pName, ID3D12PipelineState* pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipeline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline<TThis>(this TThis thisVtbl, char* pName, ref ID3D12PipelineState pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipelinePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline<TThis>(this TThis thisVtbl, ref char pName, ID3D12PipelineState* pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline<TThis>(this TThis thisVtbl, ref char pName, ref ID3D12PipelineState pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ID3D12PipelineState* pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ID3D12PipelineState pPipeline) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetSerializedSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, nuint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize<TThis>(this TThis thisVtbl, void* pData, nuint DataSizeInBytes) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)@this->LpVtbl[12])(@this, pData, DataSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Serialize<T0, TThis>(this TThis thisVtbl, ref T0 pData, nuint DataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)@this->LpVtbl[12])(@this, pDataPtr, DataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, char* pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, ref char pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadPipeline<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState) where TThis : IComVtbl<ID3D12PipelineLibrary1>
    {
        var @this = (ID3D12PipelineLibrary1*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

}
