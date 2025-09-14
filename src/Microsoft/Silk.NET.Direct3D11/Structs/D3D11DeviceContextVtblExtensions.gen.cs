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

public unsafe static class D3D11DeviceContextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Device* ppDevice)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexed(this ComPtr<ID3D11DeviceContext> thisVtbl, uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, int, void>)@this->LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Draw(this ComPtr<ID3D11DeviceContext> thisVtbl, uint VertexCount, uint StartVertexLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, void>)@this->LpVtbl[13])(@this, VertexCount, StartVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource, uint Subresource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResource, Subresource);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pResource, uint Subresource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResourcePtr, Subresource);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetInputLayout(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11InputLayout* pInputLayout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static void IASetInputLayout(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11InputLayout pInputLayout)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11InputLayout* pInputLayoutPtr = &pInputLayout)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayoutPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pStridesPtr = &pStrides)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pStridesPtr = &pStrides)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pIndexBufferPtr = &pIndexBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced(this ComPtr<ID3D11DeviceContext> thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, uint, int, uint, void>)@this->LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced(this ComPtr<ID3D11DeviceContext> thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, uint, uint, void>)@this->LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology(this ComPtr<ID3D11DeviceContext> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[24])(@this, Topology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Begin(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Asynchronous* pAsync)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static void Begin(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Asynchronous pAsync)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsyncPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void End(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Asynchronous* pAsync)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static void End(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Asynchronous pAsync)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsyncPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Asynchronous* pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Asynchronous pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Predicate* pPredicate, Silk.NET.Core.Bool32 PredicateValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicate, PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Predicate pPredicate, Silk.NET.Core.Bool32 PredicateValue)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Predicate* pPredicatePtr = &pPredicate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilState, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DepthStencilState pDepthStencilState, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilState* pDepthStencilStatePtr = &pDepthStencilState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawAuto(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, void>)@this->LpVtbl[38])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawIndexedInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch(this ComPtr<ID3D11DeviceContext> thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, uint, void>)@this->LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DispatchIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11RasterizerState* pRasterizerState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11RasterizerState pRasterizerState)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RasterizerState* pRasterizerStatePtr = &pRasterizerState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Viewport pViewports)
    {
        var @this = thisVtbl.Handle;
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, ref ID3D11Resource pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, ID3D11Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, ref ID3D11Resource pSrcResource)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
        {
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] uint* Values)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref float Values)
    {
        var @this = thisVtbl.Handle;
        fixed (float* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] float* Values)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref float Values)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GenerateMips(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ShaderResourceView* pShaderResourceView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceView);
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMips(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ShaderResourceView pShaderResourceView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView* pShaderResourceViewPtr = &pShaderResourceView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource, float MinLOD)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResource, MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static void SetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pResource, float MinLOD)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResourcePtr, MinLOD);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe float GetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pResource)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandList(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11CommandList* pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandList, RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandList(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11CommandList pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11CommandList* pCommandListPtr = &pCommandList)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetInputLayout(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11InputLayout** ppInputLayout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetInputLayout(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11InputLayout* ppInputLayout)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11InputLayout** ppInputLayoutPtr = &ppInputLayout)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayoutPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pStridesPtr = &pStrides)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pStridesPtr = &pStrides)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* OffsetPtr = &Offset)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
        {
            fixed (uint* OffsetPtr = &Offset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (uint* OffsetPtr = &Offset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetPrimitiveTopology(this ComPtr<ID3D11DeviceContext> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopology);
    }

    /// <summary>To be documented.</summary>
    public static void IAGetPrimitiveTopology(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Silk.NET.Core.Native.D3DPrimitiveTopology pTopology)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Core.Native.D3DPrimitiveTopology* pTopologyPtr = &pTopology)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopologyPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Predicate** ppPredicate, int* pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Predicate** ppPredicate, ref int pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        fixed (int* pPredicateValuePtr = &pPredicateValue)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Predicate* ppPredicate, int* pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Predicate* ppPredicate, ref int pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
        {
            fixed (int* pPredicateValuePtr = &pPredicateValue)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pSampleMaskPtr = &pSampleMask)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, ref uint pStencilRef)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pStencilRefPtr = &pStencilRef)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, uint* pStencilRef)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, ref uint pStencilRef)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
        {
            fixed (uint* pStencilRefPtr = &pStencilRef)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOGetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOGetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, ref ID3D11Buffer* ppSOTargets)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11RasterizerState** ppRasterizerState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11RasterizerState* ppRasterizerState)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11RasterizerState** ppRasterizerStatePtr = &ppRasterizerState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumViewports, Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumViewports, ref Viewport pViewports)
    {
        var @this = thisVtbl.Handle;
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, ref uint pNumViewports, Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumViewportsPtr = &pNumViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
        }
    }

    /// <summary>To be documented.</summary>
    public static void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, ref uint pNumViewports, ref Viewport pViewports)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumViewportsPtr = &pNumViewports)
        {
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumRects, ref Silk.NET.Maths.Box2D<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, ref uint pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRectsPtr = &pNumRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, ref uint pNumRects, ref Silk.NET.Maths.Box2D<int> pRects)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumRectsPtr = &pNumRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShaderResources(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetSamplers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, void>)@this->LpVtbl[110])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void Flush(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, void>)@this->LpVtbl[111])(@this);
    }

    /// <summary>To be documented.</summary>
    public static DeviceContextType GetType(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DeviceContextType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, DeviceContextType>)@this->LpVtbl[112])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetContextFlags(this ComPtr<ID3D11DeviceContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, uint>)@this->LpVtbl[113])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishCommandList(this ComPtr<ID3D11DeviceContext> thisVtbl, Silk.NET.Core.Bool32 RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishCommandList(this ComPtr<ID3D11DeviceContext> thisVtbl, Silk.NET.Core.Bool32 RestoreDeferredContextState, ref ID3D11CommandList* ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11CommandList** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void PSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void PSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetShader((ID3D11PixelShader*) pPixelShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetShader((ID3D11PixelShader*) pPixelShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11PixelShader> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSSetShader(ref pPixelShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetShader(ref pPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11PixelShader> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSSetShader(ref pPixelShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetShader((ID3D11VertexShader*) pVertexShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetShader((ID3D11VertexShader*) pVertexShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11VertexShader> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSSetShader(ref pVertexShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void VSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetShader(ref pVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11VertexShader> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSSetShader(ref pVertexShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Map((ID3D11Resource*) pResource.Handle, Subresource, MapType, MapFlags, pMappedResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, Span<MappedSubresource> pMappedResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(pResource, Subresource, MapType, MapFlags, ref pMappedResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Map<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Map((ID3D11Resource*) pResource.Handle, Subresource, MapType, MapFlags, ref pMappedResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(ref pResource.GetPinnableReference(), Subresource, MapType, MapFlags, pMappedResource);
    }

    /// <summary>To be documented.</summary>
    public static int Map(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pResource, uint Subresource, Map MapType, uint MapFlags, Span<MappedSubresource> pMappedResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(ref pResource.GetPinnableReference(), Subresource, MapType, MapFlags, ref pMappedResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Unmap<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pResource, uint Subresource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->Unmap((ID3D11Resource*) pResource.Handle, Subresource);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pResource, uint Subresource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Unmap(ref pResource.GetPinnableReference(), Subresource);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void IASetInputLayout<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pInputLayout) where TI0 : unmanaged, IComVtbl<ID3D11InputLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetInputLayout((ID3D11InputLayout*) pInputLayout.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void IASetInputLayout(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11InputLayout> pInputLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetInputLayout(ref pInputLayout.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, pStrides, in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, in pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, in pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), in pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, in pStrides.GetPinnableReference(), in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IASetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), in pStrides, in pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, in ppVertexBuffers, pStrides, in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, in ppVertexBuffers, in pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, in ppVertexBuffers, in pStrides.GetPinnableReference(), in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IASetIndexBuffer((ID3D11Buffer*) pIndexBuffer.Handle, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IASetIndexBuffer(ref pIndexBuffer.GetPinnableReference(), Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetShader((ID3D11GeometryShader*) pShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetShader((ID3D11GeometryShader*) pShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11GeometryShader> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSSetShader(ref pShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetShader(ref pShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11GeometryShader> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSSetShader(ref pShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void VSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void Begin<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pAsync) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->Begin((ID3D11Asynchronous*) pAsync.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void Begin(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Asynchronous> pAsync)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Begin(ref pAsync.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void End<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pAsync) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->End((ID3D11Asynchronous*) pAsync.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void End(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Asynchronous> pAsync)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->End(ref pAsync.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pAsync, void* pData, uint DataSize, uint GetDataFlags) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetData((ID3D11Asynchronous*) pAsync.Handle, pData, DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Asynchronous* pAsync, Span<T0> pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(pAsync, ref pData.GetPinnableReference(), DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0, TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetData((ID3D11Asynchronous*) pAsync.Handle, ref pData, DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Asynchronous> pAsync, void* pData, uint DataSize, uint GetDataFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(ref pAsync.GetPinnableReference(), pData, DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Asynchronous> pAsync, Span<T0> pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetData(ref pAsync.GetPinnableReference(), ref pData.GetPinnableReference(), DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pPredicate, Silk.NET.Core.Bool32 PredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetPredication((ID3D11Predicate*) pPredicate.Handle, PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Predicate> pPredicate, Silk.NET.Core.Bool32 PredicateValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPredication(ref pPredicate.GetPinnableReference(), PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargets(NumViews, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargets(NumViews, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargets(NumViews, in ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI2> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI2> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetBlendState((ID3D11BlendState*) pBlendState.Handle, BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetBlendState(pBlendState, ref BlendFactor.GetPinnableReference(), SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetBlendState((ID3D11BlendState*) pBlendState.Handle, ref BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11BlendState> pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetBlendState(ref pBlendState.GetPinnableReference(), BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11BlendState> pBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetBlendState(ref pBlendState.GetPinnableReference(), ref BlendFactor.GetPinnableReference(), SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthStencilState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDepthStencilState, uint StencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMSetDepthStencilState((ID3D11DepthStencilState*) pDepthStencilState.Handle, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11DepthStencilState> pDepthStencilState, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMSetDepthStencilState(ref pDepthStencilState.GetPinnableReference(), StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SOSetTargets(NumBuffers, ppSOTargets, in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SOSetTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), in pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Buffer* ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SOSetTargets(NumBuffers, in ppSOTargets, in pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstancedIndirect<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawIndexedInstancedIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawIndexedInstancedIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstancedIndirect<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DrawInstancedIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstancedIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DrawInstancedIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchIndirect<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DispatchIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchIndirect(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DispatchIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pRasterizerState) where TI0 : unmanaged, IComVtbl<ID3D11RasterizerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->RSSetState((ID3D11RasterizerState*) pRasterizerState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetState(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11RasterizerState> pRasterizerState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSSetState(ref pRasterizerState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSSetViewports(NumViewports, in pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSSetScissorRects(NumRects, in pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, in pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopySubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pSrcBox)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, in pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, ComPtr<TI1> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource((ID3D11Resource*) pDstResource.Handle, (ID3D11Resource*) pSrcResource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, Span<ID3D11Resource> pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(pDstResource, ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, ref ID3D11Resource pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource((ID3D11Resource*) pDstResource.Handle, ref pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, ID3D11Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, ComPtr<TI0> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyResource(ref pDstResource, (ID3D11Resource*) pSrcResource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, Span<ID3D11Resource> pSrcResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, pDstBox, in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, in pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, in pDstBox.GetPinnableReference(), in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource<T0, TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, in pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource<T0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Box> pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, in pDstBox.GetPinnableReference(), in pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstBuffer, uint DstAlignedByteOffset, ComPtr<TI1> pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyStructureCount((ID3D11Buffer*) pDstBuffer.Handle, DstAlignedByteOffset, (ID3D11UnorderedAccessView*) pSrcView.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, Span<ID3D11UnorderedAccessView> pSrcView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyStructureCount(pDstBuffer, DstAlignedByteOffset, ref pSrcView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyStructureCount((ID3D11Buffer*) pDstBuffer.Handle, DstAlignedByteOffset, ref pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyStructureCount(ref pDstBuffer.GetPinnableReference(), DstAlignedByteOffset, pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ComPtr<TI0> pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyStructureCount(ref pDstBuffer, DstAlignedByteOffset, (ID3D11UnorderedAccessView*) pSrcView.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Buffer> pDstBuffer, uint DstAlignedByteOffset, Span<ID3D11UnorderedAccessView> pSrcView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyStructureCount(ref pDstBuffer.GetPinnableReference(), DstAlignedByteOffset, ref pSrcView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pRenderTargetView, [Count(Count = 4)] float* ColorRGBA) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearRenderTargetView((ID3D11RenderTargetView*) pRenderTargetView.Handle, ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(pRenderTargetView, ref ColorRGBA.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearRenderTargetView((ID3D11RenderTargetView*) pRenderTargetView.Handle, ref ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11RenderTargetView> pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(ref pRenderTargetView.GetPinnableReference(), ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11RenderTargetView> pRenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearRenderTargetView(ref pRenderTargetView.GetPinnableReference(), ref ColorRGBA.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] uint* Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] Span<uint> Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(pUnorderedAccessView, ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] ref uint Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewUint((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, ref Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] uint* Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ref pUnorderedAccessView.GetPinnableReference(), Values);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] Span<uint> Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ref pUnorderedAccessView.GetPinnableReference(), ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] float* Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] Span<float> Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(pUnorderedAccessView, ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] ref float Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearUnorderedAccessViewFloat((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, ref Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] float* Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ref pUnorderedAccessView.GetPinnableReference(), Values);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] Span<float> Values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ref pUnorderedAccessView.GetPinnableReference(), ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDepthStencilView, uint ClearFlags, float Depth, byte Stencil) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ClearDepthStencilView((ID3D11DepthStencilView*) pDepthStencilView.Handle, ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11DepthStencilView> pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ClearDepthStencilView(ref pDepthStencilView.GetPinnableReference(), ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMips<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pShaderResourceView) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GenerateMips((ID3D11ShaderResourceView*) pShaderResourceView.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMips(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11ShaderResourceView> pShaderResourceView)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GenerateMips(ref pShaderResourceView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetResourceMinLOD<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pResource, float MinLOD) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetResourceMinLOD((ID3D11Resource*) pResource.Handle, MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static void SetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pResource, float MinLOD)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetResourceMinLOD(ref pResource.GetPinnableReference(), MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static float GetResourceMinLOD<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetResourceMinLOD((ID3D11Resource*) pResource.Handle);
    }

    /// <summary>To be documented.</summary>
    public static float GetResourceMinLOD(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pResource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceMinLOD(ref pResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(pDstResource, DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, ref pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveSubresource(ref pDstResource, DstSubresource, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandList<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pCommandList, Silk.NET.Core.Bool32 RestoreContextState) where TI0 : unmanaged, IComVtbl<ID3D11CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteCommandList((ID3D11CommandList*) pCommandList.Handle, RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandList(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11CommandList> pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteCommandList(ref pCommandList.GetPinnableReference(), RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void HSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetShader((ID3D11HullShader*) pHullShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetShader((ID3D11HullShader*) pHullShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11HullShader> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSSetShader(ref pHullShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetShader(ref pHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11HullShader> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSSetShader(ref pHullShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void HSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetShader((ID3D11DomainShader*) pDomainShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetShader((ID3D11DomainShader*) pDomainShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11DomainShader> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSSetShader(ref pDomainShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void DSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetShader(ref pDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11DomainShader> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSSetShader(ref pDomainShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void DSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetShader((ID3D11ComputeShader*) pComputeShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ComPtr<TI0> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetShader((ID3D11ComputeShader*) pComputeShader.Handle, in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11ComputeShader> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSSetShader(ref pComputeShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void CSSetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetShader(ref pComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<ID3D11ComputeShader> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSSetShader(ref pComputeShader.GetPinnableReference(), in ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void CSSetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSGetShader(ppPixelShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSGetShader(ppPixelShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSGetShader(ref ppPixelShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->PSGetShader(ref ppPixelShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSGetShader(ppVertexShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSGetShader(ppVertexShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSGetShader(ref ppVertexShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->VSGetShader(ref ppVertexShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->PSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetInputLayout<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppInputLayout) where TI0 : unmanaged, IComVtbl<ID3D11InputLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetInputLayout((ID3D11InputLayout**) ppInputLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, Span<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetVertexBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, Span<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, Span<uint> Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, Format, ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, ref Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, ref Format.GetPinnableReference(), Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Buffer** pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, Span<uint> Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, ref Format.GetPinnableReference(), ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetIndexBuffer<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, ref Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, Span<uint> Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, Format, ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, ref Format.GetPinnableReference(), Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Buffer* pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, Span<uint> Offset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, ref Format.GetPinnableReference(), ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSGetShader(ppGeometryShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSGetShader(ppGeometryShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSGetShader(ref ppGeometryShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GSGetShader(ref ppGeometryShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetPrimitiveTopology(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<Silk.NET.Core.Native.D3DPrimitiveTopology> pTopology)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->IAGetPrimitiveTopology(ref pTopology.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->VSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPredicate, int* pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11Predicate** ppPredicate, Span<int> pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetPredication(ppPredicate, ref pPredicateValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetPredication<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppPredicate, ref int pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), ref pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11Predicate* ppPredicate, Span<int> pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetPredication(ref ppPredicate, ref pPredicateValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetRenderTargets<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI2> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, Span<uint> pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, BlendFactor, ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, ref pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, ref BlendFactor.GetPinnableReference(), pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, Span<uint> pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, ref BlendFactor.GetPinnableReference(), ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetBlendState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, ref pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, Span<uint> pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, BlendFactor, ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, ref BlendFactor.GetPinnableReference(), pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, Span<uint> pSampleMask)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, ref BlendFactor.GetPinnableReference(), ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDepthStencilState, uint* pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, Span<uint> pStencilRef)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetDepthStencilState(ppDepthStencilState, ref pStencilRef.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetDepthStencilState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDepthStencilState, ref uint pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), ref pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, Span<uint> pStencilRef)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OMGetDepthStencilState(ref ppDepthStencilState, ref pStencilRef.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SOGetTargets<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint NumBuffers, ref ComPtr<TI0> ppSOTargets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SOGetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void RSGetState<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppRasterizerState) where TI0 : unmanaged, IComVtbl<ID3D11RasterizerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->RSGetState((ID3D11RasterizerState**) ppRasterizerState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumViewports, Span<Viewport> pViewports)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetViewports(pNumViewports, ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<uint> pNumViewports, Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetViewports(ref pNumViewports.GetPinnableReference(), pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSGetViewports(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<uint> pNumViewports, Span<Viewport> pViewports)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetViewports(ref pNumViewports.GetPinnableReference(), ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, uint* pNumRects, Span<Silk.NET.Maths.Box2D<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetScissorRects(pNumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<uint> pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetScissorRects(ref pNumRects.GetPinnableReference(), pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSGetScissorRects(this ComPtr<ID3D11DeviceContext> thisVtbl, Span<uint> pNumRects, Span<Silk.NET.Maths.Box2D<int>> pRects)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->RSGetScissorRects(ref pNumRects.GetPinnableReference(), ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSGetShader(ppHullShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSGetShader(ppHullShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSGetShader(ref ppHullShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->HSGetShader(ref ppHullShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->HSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSGetShader(ppDomainShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSGetShader(ppDomainShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSGetShader(ref ppDomainShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DSGetShader(ref ppDomainShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetShaderResources<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetUnorderedAccessViews<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSGetShader(ppComputeShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetShader<TI0, TI1>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSGetShader(ppComputeShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSGetShader(ref ppComputeShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext> thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CSGetShader(ref ppComputeShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetSamplers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetConstantBuffers<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int FinishCommandList<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl, Silk.NET.Core.Bool32 RestoreDeferredContextState, ref ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D11CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FinishCommandList(RestoreDeferredContextState, (ID3D11CommandList**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11DeviceContext> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
