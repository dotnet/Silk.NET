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

public unsafe static class D3D11DeviceContext4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ID3D11Device** ppDevice) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice<TThis>(this TThis thisVtbl, ref ID3D11Device* ppDevice) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader* pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader* pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader* pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader* pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexed<TThis>(this TThis thisVtbl, uint IndexCount, uint StartIndexLocation, int BaseVertexLocation) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, int, void>)@this->LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Draw<TThis>(this TThis thisVtbl, uint VertexCount, uint StartVertexLocation) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, void>)@this->LpVtbl[13])(@this, VertexCount, StartVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Map<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, uint Subresource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResource, Subresource);
    }

    /// <summary>To be documented.</summary>
    public static void Unmap<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, uint Subresource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResourcePtr, Subresource);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetInputLayout<TThis>(this TThis thisVtbl, ID3D11InputLayout* pInputLayout) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static void IASetInputLayout<TThis>(this TThis thisVtbl, ref ID3D11InputLayout pInputLayout) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11InputLayout* pInputLayoutPtr = &pInputLayout)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayoutPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pStridesPtr = &pStrides)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pStridesPtr = &pStrides)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pIndexBufferPtr = &pIndexBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced<TThis>(this TThis thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, uint, int, uint, void>)@this->LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced<TThis>(this TThis thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, uint, uint, void>)@this->LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader* pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader* pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology Topology) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[24])(@this, Topology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Begin<TThis>(this TThis thisVtbl, ID3D11Asynchronous* pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static void Begin<TThis>(this TThis thisVtbl, ref ID3D11Asynchronous pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsyncPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void End<TThis>(this TThis thisVtbl, ID3D11Asynchronous* pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static void End<TThis>(this TThis thisVtbl, ref ID3D11Asynchronous pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsyncPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<TThis>(this TThis thisVtbl, ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<T0, TThis>(this TThis thisVtbl, ID3D11Asynchronous* pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<TThis>(this TThis thisVtbl, ref ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0, TThis>(this TThis thisVtbl, ref ID3D11Asynchronous pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication<TThis>(this TThis thisVtbl, ID3D11Predicate* pPredicate, int PredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate*, int, void>)@this->LpVtbl[30])(@this, pPredicate, PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TThis>(this TThis thisVtbl, ref ID3D11Predicate pPredicate, int PredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Predicate* pPredicatePtr = &pPredicate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate*, int, void>)@this->LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetDepthStencilState<TThis>(this TThis thisVtbl, ID3D11DepthStencilState* pDepthStencilState, uint StencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilState, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthStencilState<TThis>(this TThis thisVtbl, ref ID3D11DepthStencilState pDepthStencilState, uint StencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilState* pDepthStencilStatePtr = &pDepthStencilState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ref ID3D11Buffer* ppSOTargets, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ref ID3D11Buffer* ppSOTargets, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DrawAuto<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, void>)@this->LpVtbl[38])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawIndexedInstancedIndirect<TThis>(this TThis thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstancedIndirect<TThis>(this TThis thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawInstancedIndirect<TThis>(this TThis thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstancedIndirect<TThis>(this TThis thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch<TThis>(this TThis thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, uint, void>)@this->LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DispatchIndirect<TThis>(this TThis thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchIndirect<TThis>(this TThis thisVtbl, ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetState<TThis>(this TThis thisVtbl, ID3D11RasterizerState* pRasterizerState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetState<TThis>(this TThis thisVtbl, ref ID3D11RasterizerState pRasterizerState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RasterizerState* pRasterizerStatePtr = &pRasterizerState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports<TThis>(this TThis thisVtbl, uint NumViewports, Viewport* pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports<TThis>(this TThis thisVtbl, uint NumViewports, ref Viewport pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects<TThis>(this TThis thisVtbl, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects<TThis>(this TThis thisVtbl, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, ref ID3D11Resource pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, ID3D11Resource* pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, ref ID3D11Resource pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount<TThis>(this TThis thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount<TThis>(this TThis thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount<TThis>(this TThis thisVtbl, ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount<TThis>(this TThis thisVtbl, ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
        {
            fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* ColorRGBAPtr = &ColorRGBA)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] float* ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView<TThis>(this TThis thisVtbl, ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
        {
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref uint Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] uint* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref uint Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref float Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* ValuesPtr = &Values)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] float* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref float Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
        {
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView<TThis>(this TThis thisVtbl, ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView<TThis>(this TThis thisVtbl, ref ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GenerateMips<TThis>(this TThis thisVtbl, ID3D11ShaderResourceView* pShaderResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceView);
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMips<TThis>(this TThis thisVtbl, ref ID3D11ShaderResourceView pShaderResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView* pShaderResourceViewPtr = &pShaderResourceView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetResourceMinLOD<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, float MinLOD) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResource, MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static void SetResourceMinLOD<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource, float MinLOD) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResourcePtr, MinLOD);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe float GetResourceMinLOD<TThis>(this TThis thisVtbl, ID3D11Resource* pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetResourceMinLOD<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        float ret = default;
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandList<TThis>(this TThis thisVtbl, ID3D11CommandList* pCommandList, int RestoreContextState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11CommandList*, int, void>)@this->LpVtbl[58])(@this, pCommandList, RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandList<TThis>(this TThis thisVtbl, ref ID3D11CommandList pCommandList, int RestoreContextState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11CommandList* pCommandListPtr = &pCommandList)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11CommandList*, int, void>)@this->LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, ID3D11HullShader* pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, ID3D11HullShader* pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader* pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader* pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader* pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader* pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetInputLayout<TThis>(this TThis thisVtbl, ID3D11InputLayout** ppInputLayout) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetInputLayout<TThis>(this TThis thisVtbl, ref ID3D11InputLayout* ppInputLayout) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11InputLayout** ppInputLayoutPtr = &ppInputLayout)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayoutPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pOffsetsPtr = &pOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pStridesPtr = &pStrides)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pStridesPtr = &pStrides)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
        {
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* OffsetPtr = &Offset)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
        {
            fixed (uint* OffsetPtr = &Offset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (uint* OffsetPtr = &Offset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
        {
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetPrimitiveTopology<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopology);
    }

    /// <summary>To be documented.</summary>
    public static void IAGetPrimitiveTopology<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.D3DPrimitiveTopology pTopology) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Core.Native.D3DPrimitiveTopology* pTopologyPtr = &pTopology)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopologyPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ID3D11Predicate** ppPredicate, int* pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ID3D11Predicate** ppPredicate, ref int pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (int* pPredicateValuePtr = &pPredicateValue)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ref ID3D11Predicate* ppPredicate, int* pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ref ID3D11Predicate* ppPredicate, ref int pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
        {
            fixed (int* pPredicateValuePtr = &pPredicateValue)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
        {
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pSampleMaskPtr = &pSampleMask)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* BlendFactorPtr = &BlendFactor)
        {
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
        {
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, ref uint pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pStencilRefPtr = &pStencilRef)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, uint* pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, ref uint pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
        {
            fixed (uint* pStencilRefPtr = &pStencilRef)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOGetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOGetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ref ID3D11Buffer* ppSOTargets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetState<TThis>(this TThis thisVtbl, ID3D11RasterizerState** ppRasterizerState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetState<TThis>(this TThis thisVtbl, ref ID3D11RasterizerState* ppRasterizerState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11RasterizerState** ppRasterizerStatePtr = &ppRasterizerState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports<TThis>(this TThis thisVtbl, uint* pNumViewports, Viewport* pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports<TThis>(this TThis thisVtbl, uint* pNumViewports, ref Viewport pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Viewport* pViewportsPtr = &pViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports<TThis>(this TThis thisVtbl, ref uint pNumViewports, Viewport* pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumViewportsPtr = &pNumViewports)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
        }
    }

    /// <summary>To be documented.</summary>
    public static void RSGetViewports<TThis>(this TThis thisVtbl, ref uint pNumViewports, ref Viewport pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumViewportsPtr = &pNumViewports)
        {
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects<TThis>(this TThis thisVtbl, uint* pNumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects<TThis>(this TThis thisVtbl, uint* pNumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRectsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects<TThis>(this TThis thisVtbl, ref uint pNumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRectsPtr = &pNumRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static void RSGetScissorRects<TThis>(this TThis thisVtbl, ref uint pNumRects, ref Silk.NET.Maths.Rectangle<int> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumRectsPtr = &pNumRects)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShaderResources<TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
        {
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetSamplers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearState<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, void>)@this->LpVtbl[110])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void Flush<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, void>)@this->LpVtbl[111])(@this);
    }

    /// <summary>To be documented.</summary>
    public static DeviceContextType GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        DeviceContextType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, DeviceContextType>)@this->LpVtbl[112])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetContextFlags<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint>)@this->LpVtbl[113])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishCommandList<TThis>(this TThis thisVtbl, int RestoreDeferredContextState, ID3D11CommandList** ppCommandList) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishCommandList<TThis>(this TThis thisVtbl, int RestoreDeferredContextState, ref ID3D11CommandList* ppCommandList) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11CommandList** ppCommandListPtr = &ppCommandList)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pSrcBoxPtr = &pSrcBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (void* pSrcDataPtr = &pSrcData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Box* pDstBoxPtr = &pDstBox)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D11Resource* pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResource);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TThis>(this TThis thisVtbl, ref ID3D11Resource pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResourcePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView<TThis>(this TThis thisVtbl, ID3D11View* pResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceView);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardView<TThis>(this TThis thisVtbl, ref ID3D11View pResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pResourceViewPtr = &pResourceView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceViewPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pNumConstantsPtr = &pNumConstants)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (uint* pFirstConstantPtr = &pFirstConstant)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
        {
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, ID3DDeviceContextState* pState, ref ID3DDeviceContextState* ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousStatePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, ref ID3DDeviceContextState pState, ID3DDeviceContextState** ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3DDeviceContextState* pStatePtr = &pState)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pStatePtr, ppPreviousState);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, ref ID3DDeviceContextState pState, ref ID3DDeviceContextState* ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3DDeviceContextState* pStatePtr = &pState)
        {
            fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] float* Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRect, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] float* Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] ref float Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* ColorPtr = &Color)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (float* ColorPtr = &Color)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ref ID3D11View pView, [Count(Count = 4)] float* Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pViewPtr = &pView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ref ID3D11View pView, [Count(Count = 4)] float* Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pViewPtr = &pView)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ref ID3D11View pView, [Count(Count = 4)] ref float Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pViewPtr = &pView)
        {
            fixed (float* ColorPtr = &Color)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ClearView<TThis>(this TThis thisVtbl, ref ID3D11View pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pViewPtr = &pView)
        {
            fixed (float* ColorPtr = &Color)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1<TThis>(this TThis thisVtbl, ID3D11View* pResourceView, Silk.NET.Maths.Rectangle<int>* pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRects, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1<TThis>(this TThis thisVtbl, ID3D11View* pResourceView, ref Silk.NET.Maths.Rectangle<int> pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1<TThis>(this TThis thisVtbl, ref ID3D11View pResourceView, Silk.NET.Maths.Rectangle<int>* pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pResourceViewPtr = &pResourceView)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardView1<TThis>(this TThis thisVtbl, ref ID3D11View pResourceView, ref Silk.NET.Maths.Rectangle<int> pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11View* pResourceViewPtr = &pResourceView)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
        {
            fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
        {
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (void* pSourceTileDataPtr = &pSourceTileData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
        {
            fixed (void* pSourceTileDataPtr = &pSourceTileData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
        {
            fixed (void* pSourceTileDataPtr = &pSourceTileData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
        {
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (void* pSourceTileDataPtr = &pSourceTileData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTiles<T0, TThis>(this TThis thisVtbl, ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
        {
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    fixed (void* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeTilePool<TThis>(this TThis thisVtbl, ID3D11Buffer* pTilePool, ulong NewSizeInBytes) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, ulong, int>)@this->LpVtbl[138])(@this, pTilePool, NewSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTilePool<TThis>(this TThis thisVtbl, ref ID3D11Buffer pTilePool, ulong NewSizeInBytes) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Buffer*, ulong, int>)@this->LpVtbl[138])(@this, pTilePoolPtr, NewSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void TiledResourceBarrier<TThis>(this TThis thisVtbl, ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void TiledResourceBarrier<TThis>(this TThis thisVtbl, ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrierPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void TiledResourceBarrier<TThis>(this TThis thisVtbl, ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrier);
        }
    }

    /// <summary>To be documented.</summary>
    public static void TiledResourceBarrier<TThis>(this TThis thisVtbl, ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
        {
            fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrierPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int IsAnnotationEnabled<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int>)@this->LpVtbl[140])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarkerInt<TThis>(this TThis thisVtbl, char* pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, char*, int, void>)@this->LpVtbl[141])(@this, pLabel, Data);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarkerInt<TThis>(this TThis thisVtbl, ref char pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (char* pLabelPtr = &pLabel)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, char*, int, void>)@this->LpVtbl[141])(@this, pLabelPtr, Data);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetMarkerInt<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        var pLabelPtr = (byte*) SilkMarshal.StringToPtr(pLabel, NativeStringEncoding.LPWStr);
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, byte*, int, void>)@this->LpVtbl[141])(@this, pLabelPtr, Data);
        SilkMarshal.Free((nint)pLabelPtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEventInt<TThis>(this TThis thisVtbl, char* pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, char*, int, void>)@this->LpVtbl[142])(@this, pLabel, Data);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEventInt<TThis>(this TThis thisVtbl, ref char pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (char* pLabelPtr = &pLabel)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, char*, int, void>)@this->LpVtbl[142])(@this, pLabelPtr, Data);
        }
    }

    /// <summary>To be documented.</summary>
    public static void BeginEventInt<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        var pLabelPtr = (byte*) SilkMarshal.StringToPtr(pLabel, NativeStringEncoding.LPWStr);
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, byte*, int, void>)@this->LpVtbl[142])(@this, pLabelPtr, Data);
        SilkMarshal.Free((nint)pLabelPtr);
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, void>)@this->LpVtbl[143])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Flush1<TThis>(this TThis thisVtbl, ContextType ContextType, void* hEvent) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ContextType, void*, void>)@this->LpVtbl[144])(@this, ContextType, hEvent);
    }

    /// <summary>To be documented.</summary>
    public static void Flush1<T0, TThis>(this TThis thisVtbl, ContextType ContextType, ref T0 hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (void* hEventPtr = &hEvent)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ContextType, void*, void>)@this->LpVtbl[144])(@this, ContextType, hEventPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetHardwareProtectionState<TThis>(this TThis thisVtbl, int HwProtectionEnable) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int, void>)@this->LpVtbl[145])(@this, HwProtectionEnable);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetHardwareProtectionState<TThis>(this TThis thisVtbl, int* pHwProtectionEnable) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int*, void>)@this->LpVtbl[146])(@this, pHwProtectionEnable);
    }

    /// <summary>To be documented.</summary>
    public static void GetHardwareProtectionState<TThis>(this TThis thisVtbl, ref int pHwProtectionEnable) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        fixed (int* pHwProtectionEnablePtr = &pHwProtectionEnable)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, int*, void>)@this->LpVtbl[146])(@this, pHwProtectionEnablePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Signal<TThis>(this TThis thisVtbl, ID3D11Fence* pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)@this->LpVtbl[147])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Signal<TThis>(this TThis thisVtbl, ref ID3D11Fence pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)@this->LpVtbl[147])(@this, pFencePtr, Value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Wait<TThis>(this TThis thisVtbl, ID3D11Fence* pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)@this->LpVtbl[148])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Wait<TThis>(this TThis thisVtbl, ref ID3D11Fence pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)@this->LpVtbl[148])(@this, pFencePtr, Value);
        }
        return ret;
    }

}
