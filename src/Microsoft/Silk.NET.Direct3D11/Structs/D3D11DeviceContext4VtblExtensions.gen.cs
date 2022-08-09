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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void PSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11PixelShader* pPixelShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetShader(pPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11PixelShader> pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetShader(ref pPixelShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11PixelShader pPixelShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetShader(ref pPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11PixelShader> pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetShader(ref pPixelShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11VertexShader* pVertexShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetShader(pVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11VertexShader> pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetShader(ref pVertexShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void VSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11VertexShader pVertexShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetShader(ref pVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11VertexShader> pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetShader(ref pVertexShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, Span<MappedSubresource> pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Map(pResource, Subresource, MapType, MapFlags, ref pMappedResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Map(ref pResource.GetPinnableReference(), Subresource, MapType, MapFlags, pMappedResource);
    }

    /// <summary>To be documented.</summary>
    public static int Map<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource, uint Subresource, Map MapType, uint MapFlags, Span<MappedSubresource> pMappedResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Map(ref pResource.GetPinnableReference(), Subresource, MapType, MapFlags, ref pMappedResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Unmap<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource, uint Subresource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Unmap(ref pResource.GetPinnableReference(), Subresource);
    }

    /// <summary>To be documented.</summary>
    public static void PSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void IASetInputLayout<TThis>(this TThis thisVtbl, Span<ID3D11InputLayout> pInputLayout) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetInputLayout(ref pInputLayout.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IASetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IASetIndexBuffer<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IASetIndexBuffer(ref pIndexBuffer.GetPinnableReference(), Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11GeometryShader* pShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetShader(pShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11GeometryShader> pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetShader(ref pShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11GeometryShader pShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetShader(ref pShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11GeometryShader> pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetShader(ref pShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void VSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void Begin<TThis>(this TThis thisVtbl, Span<ID3D11Asynchronous> pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Begin(ref pAsync.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void End<TThis>(this TThis thisVtbl, Span<ID3D11Asynchronous> pAsync) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->End(ref pAsync.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<T0, TThis>(this TThis thisVtbl, ID3D11Asynchronous* pAsync, Span<T0> pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetData(pAsync, ref pData.GetPinnableReference(), DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<TThis>(this TThis thisVtbl, Span<ID3D11Asynchronous> pAsync, void* pData, uint DataSize, uint GetDataFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetData(ref pAsync.GetPinnableReference(), pData, DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0, TThis>(this TThis thisVtbl, Span<ID3D11Asynchronous> pAsync, Span<T0> pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetData(ref pAsync.GetPinnableReference(), ref pData.GetPinnableReference(), DataSize, GetDataFlags);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TThis>(this TThis thisVtbl, Span<ID3D11Predicate> pPredicate, int PredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetPredication(ref pPredicate.GetPinnableReference(), PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static void GSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TI0, TThis>(this TThis thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargets(NumViews, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargets<TI0, TThis>(this TThis thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets<TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargets(NumViews, ref ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, Span<ID3D11DepthStencilView> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref pDepthStencilView.GetPinnableReference(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetBlendState(pBlendState, ref BlendFactor.GetPinnableReference(), SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState<TThis>(this TThis thisVtbl, Span<ID3D11BlendState> pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetBlendState(ref pBlendState.GetPinnableReference(), BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetBlendState<TThis>(this TThis thisVtbl, Span<ID3D11BlendState> pBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint SampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetBlendState(ref pBlendState.GetPinnableReference(), ref BlendFactor.GetPinnableReference(), SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthStencilState<TThis>(this TThis thisVtbl, Span<ID3D11DepthStencilState> pDepthStencilState, uint StencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMSetDepthStencilState(ref pDepthStencilState.GetPinnableReference(), StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TI0, TThis>(this TThis thisVtbl, uint NumBuffers, ref ComPtr<TI0> ppSOTargets, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SOSetTargets(NumBuffers, ppSOTargets, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SOSetTargets<TI0, TThis>(this TThis thisVtbl, uint NumBuffers, ref ComPtr<TI0> ppSOTargets, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets<TThis>(this TThis thisVtbl, uint NumBuffers, ref ID3D11Buffer* ppSOTargets, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SOSetTargets(NumBuffers, ref ppSOTargets, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstancedIndirect<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DrawIndexedInstancedIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstancedIndirect<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DrawInstancedIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void DispatchIndirect<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pBufferForArgs, uint AlignedByteOffsetForArgs) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DispatchIndirect(ref pBufferForArgs.GetPinnableReference(), AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void RSSetState<TThis>(this TThis thisVtbl, Span<ID3D11RasterizerState> pRasterizerState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSSetState(ref pRasterizerState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RSSetViewports<TThis>(this TThis thisVtbl, uint NumViewports, Span<Viewport> pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSSetViewports(NumViewports, ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void RSSetScissorRects<TThis>(this TThis thisVtbl, uint NumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSSetScissorRects(NumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Span<Box> pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Span<Box> pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Span<Box> pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Box* pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Span<Box> pSrcBox) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcBox.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, Span<ID3D11Resource> pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyResource(pDstResource, ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, ID3D11Resource* pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static void CopyResource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, Span<ID3D11Resource> pSrcResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyResource(ref pDstResource.GetPinnableReference(), ref pSrcResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, pDstBox, ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<Box> pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, ref pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<Box> pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(pDstResource, DstSubresource, ref pDstBox.GetPinnableReference(), ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Box* pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<Box> pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, ref pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<Box> pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, ref pDstBox.GetPinnableReference(), ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount<TThis>(this TThis thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, Span<ID3D11UnorderedAccessView> pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyStructureCount(pDstBuffer, DstAlignedByteOffset, ref pSrcView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyStructureCount(ref pDstBuffer.GetPinnableReference(), DstAlignedByteOffset, pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static void CopyStructureCount<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pDstBuffer, uint DstAlignedByteOffset, Span<ID3D11UnorderedAccessView> pSrcView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyStructureCount(ref pDstBuffer.GetPinnableReference(), DstAlignedByteOffset, ref pSrcView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearRenderTargetView(pRenderTargetView, ref ColorRGBA.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView<TThis>(this TThis thisVtbl, Span<ID3D11RenderTargetView> pRenderTargetView, [Count(Count = 4)] float* ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearRenderTargetView(ref pRenderTargetView.GetPinnableReference(), ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static void ClearRenderTargetView<TThis>(this TThis thisVtbl, Span<ID3D11RenderTargetView> pRenderTargetView, [Count(Count = 4)] Span<float> ColorRGBA) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearRenderTargetView(ref pRenderTargetView.GetPinnableReference(), ref ColorRGBA.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] Span<uint> Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(pUnorderedAccessView, ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] uint* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ref pUnorderedAccessView.GetPinnableReference(), Values);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewUint<TThis>(this TThis thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] Span<uint> Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewUint(ref pUnorderedAccessView.GetPinnableReference(), ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] Span<float> Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(pUnorderedAccessView, ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] float* Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ref pUnorderedAccessView.GetPinnableReference(), Values);
    }

    /// <summary>To be documented.</summary>
    public static void ClearUnorderedAccessViewFloat<TThis>(this TThis thisVtbl, Span<ID3D11UnorderedAccessView> pUnorderedAccessView, [Count(Count = 4)] Span<float> Values) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearUnorderedAccessViewFloat(ref pUnorderedAccessView.GetPinnableReference(), ref Values.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ClearDepthStencilView<TThis>(this TThis thisVtbl, Span<ID3D11DepthStencilView> pDepthStencilView, uint ClearFlags, float Depth, byte Stencil) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearDepthStencilView(ref pDepthStencilView.GetPinnableReference(), ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMips<TThis>(this TThis thisVtbl, Span<ID3D11ShaderResourceView> pShaderResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GenerateMips(ref pShaderResourceView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetResourceMinLOD<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource, float MinLOD) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetResourceMinLOD(ref pResource.GetPinnableReference(), MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static float GetResourceMinLOD<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetResourceMinLOD(ref pResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveSubresource(pDstResource, DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveSubresource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveSubresource(ref pDstResource.GetPinnableReference(), DstSubresource, ref pSrcResource.GetPinnableReference(), SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandList<TThis>(this TThis thisVtbl, Span<ID3D11CommandList> pCommandList, int RestoreContextState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ExecuteCommandList(ref pCommandList.GetPinnableReference(), RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11HullShader* pHullShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetShader(pHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11HullShader> pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetShader(ref pHullShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11HullShader pHullShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetShader(ref pHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11HullShader> pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetShader(ref pHullShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void HSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void HSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11DomainShader* pDomainShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetShader(pDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11DomainShader> pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetShader(ref pDomainShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void DSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11DomainShader pDomainShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetShader(ref pDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11DomainShader> pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetShader(ref pDomainShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void DSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews, ref uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), ref pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews<TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, Span<uint> pUAVInitialCounts) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TI0, TThis>(this TThis thisVtbl, ID3D11ComputeShader* pComputeShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetShader(pComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11ComputeShader> pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetShader(ref pComputeShader.GetPinnableReference(), ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void CSSetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11ComputeShader pComputeShader, ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetShader(ref pComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader<TThis>(this TThis thisVtbl, Span<ID3D11ComputeShader> pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetShader(ref pComputeShader.GetPinnableReference(), ref ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void CSSetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetShader(ppPixelShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetShader(ppPixelShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetShader(ref ppPixelShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader<TThis>(this TThis thisVtbl, ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetShader(ref ppPixelShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetShader(ppVertexShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetShader(ppVertexShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetShader(ref ppVertexShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader<TThis>(this TThis thisVtbl, ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetShader(ref ppVertexShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetInputLayout<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppInputLayout) where TI0 : unmanaged, IComVtbl<ID3D11InputLayout>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetInputLayout((ID3D11InputLayout**) ppInputLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetVertexBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, ref pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, pStrides, ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, uint* pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, Span<uint> pStrides, Span<uint> pOffsets) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetVertexBuffers(StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides.GetPinnableReference(), ref pOffsets.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, Span<uint> Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, Format, ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, ref Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, ref Format.GetPinnableReference(), Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ID3D11Buffer** pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, Span<uint> Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(pIndexBuffer, ref Format.GetPinnableReference(), ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetIndexBuffer<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, ref Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, Span<uint> Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, Format, ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, uint* Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, ref Format.GetPinnableReference(), Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer<TThis>(this TThis thisVtbl, ref ID3D11Buffer* pIndexBuffer, Span<Silk.NET.DXGI.Format> Format, Span<uint> Offset) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetIndexBuffer(ref pIndexBuffer, ref Format.GetPinnableReference(), ref Offset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetShader(ppGeometryShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetShader(ppGeometryShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetShader(ref ppGeometryShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader<TThis>(this TThis thisVtbl, ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetShader(ref ppGeometryShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void IAGetPrimitiveTopology<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.D3DPrimitiveTopology> pTopology) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->IAGetPrimitiveTopology(ref pTopology.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPredicate, int* pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ID3D11Predicate** ppPredicate, Span<int> pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetPredication(ppPredicate, ref pPredicateValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetPredication<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppPredicate, ref int pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), ref pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication<TThis>(this TThis thisVtbl, ref ID3D11Predicate* ppPredicate, Span<int> pPredicateValue) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetPredication(ref ppPredicate, ref pPredicateValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetRenderTargets<TI0, TI1, TThis>(this TThis thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TI0, TThis>(this TThis thisVtbl, uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets<TI0, TThis>(this TThis thisVtbl, uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargets(NumViews, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI2> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, Span<uint> pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, BlendFactor, ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, ref pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, ref BlendFactor.GetPinnableReference(), pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, Span<uint> pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ppBlendState, ref BlendFactor.GetPinnableReference(), ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetBlendState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, ref pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, Span<uint> pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, BlendFactor, ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, uint* pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, ref BlendFactor.GetPinnableReference(), pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState<TThis>(this TThis thisVtbl, ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] Span<float> BlendFactor, Span<uint> pSampleMask) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetBlendState(ref ppBlendState, ref BlendFactor.GetPinnableReference(), ref pSampleMask.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDepthStencilState, uint* pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, Span<uint> pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetDepthStencilState(ppDepthStencilState, ref pStencilRef.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OMGetDepthStencilState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDepthStencilState, ref uint pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), ref pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState<TThis>(this TThis thisVtbl, ref ID3D11DepthStencilState* ppDepthStencilState, Span<uint> pStencilRef) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->OMGetDepthStencilState(ref ppDepthStencilState, ref pStencilRef.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SOGetTargets<TI0, TThis>(this TThis thisVtbl, uint NumBuffers, ref ComPtr<TI0> ppSOTargets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->SOGetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void RSGetState<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppRasterizerState) where TI0 : unmanaged, IComVtbl<ID3D11RasterizerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->RSGetState((ID3D11RasterizerState**) ppRasterizerState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports<TThis>(this TThis thisVtbl, uint* pNumViewports, Span<Viewport> pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetViewports(pNumViewports, ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports<TThis>(this TThis thisVtbl, Span<uint> pNumViewports, Viewport* pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetViewports(ref pNumViewports.GetPinnableReference(), pViewports);
    }

    /// <summary>To be documented.</summary>
    public static void RSGetViewports<TThis>(this TThis thisVtbl, Span<uint> pNumViewports, Span<Viewport> pViewports) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetViewports(ref pNumViewports.GetPinnableReference(), ref pViewports.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects<TThis>(this TThis thisVtbl, uint* pNumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetScissorRects(pNumRects, ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects<TThis>(this TThis thisVtbl, Span<uint> pNumRects, Silk.NET.Maths.Rectangle<int>* pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetScissorRects(ref pNumRects.GetPinnableReference(), pRects);
    }

    /// <summary>To be documented.</summary>
    public static void RSGetScissorRects<TThis>(this TThis thisVtbl, Span<uint> pNumRects, Span<Silk.NET.Maths.Rectangle<int>> pRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->RSGetScissorRects(ref pNumRects.GetPinnableReference(), ref pRects.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetShader(ppHullShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetShader(ppHullShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetShader(ref ppHullShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader<TThis>(this TThis thisVtbl, ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetShader(ref ppHullShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetShader(ppDomainShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetShader(ppDomainShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetShader(ref ppDomainShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader<TThis>(this TThis thisVtbl, ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetShader(ref ppDomainShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetShaderResources<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetUnorderedAccessViews<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetShader(ppComputeShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetShader<TI0, TI1, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetShader(ppComputeShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetShader(ref ppComputeShader, ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TI0, TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader<TThis>(this TThis thisVtbl, ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, Span<uint> pNumClassInstances) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetShader(ref ppComputeShader, ref ppClassInstances, ref pNumClassInstances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetSamplers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetConstantBuffers<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int FinishCommandList<TI0, TThis>(this TThis thisVtbl, int RestoreDeferredContextState, ref ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D11CommandList>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->FinishCommandList(RestoreDeferredContextState, (ID3D11CommandList**) ppCommandList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Span<Box> pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox.GetPinnableReference(), CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Span<Box> pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(pDstResource, DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcBox.GetPinnableReference(), CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Span<Box> pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox.GetPinnableReference(), CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, pSrcBox, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static void CopySubresourceRegion1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, Span<ID3D11Resource> pSrcResource, uint SrcSubresource, Span<Box> pSrcBox, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopySubresourceRegion1(ref pDstResource.GetPinnableReference(), DstSubresource, DstX, DstY, DstZ, ref pSrcResource.GetPinnableReference(), SrcSubresource, ref pSrcBox.GetPinnableReference(), CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(pDstResource, DstSubresource, pDstBox, ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<Box> pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(pDstResource, DstSubresource, ref pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, Span<Box> pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(pDstResource, DstSubresource, ref pDstBox.GetPinnableReference(), ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Box* pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(ref pDstResource.GetPinnableReference(), DstSubresource, pDstBox, ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<Box> pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(ref pDstResource.GetPinnableReference(), DstSubresource, ref pDstBox.GetPinnableReference(), pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateSubresource1<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDstResource, uint DstSubresource, Span<Box> pDstBox, Span<T0> pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateSubresource1(ref pDstResource.GetPinnableReference(), DstSubresource, ref pDstBox.GetPinnableReference(), ref pSrcData.GetPinnableReference(), SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pResource) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DiscardView<TThis>(this TThis thisVtbl, Span<ID3D11View> pResourceView) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardView(ref pResourceView.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSSetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSSetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void VSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->VSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void HSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->HSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void PSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->PSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void CSGetConstantBuffers1<TI0, TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, pFirstConstant, ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, uint* pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1<TThis>(this TThis thisVtbl, uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, Span<uint> pFirstConstant, Span<uint> pNumConstants) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CSGetConstantBuffers1(StartSlot, NumBuffers, ref ppConstantBuffers, ref pFirstConstant.GetPinnableReference(), ref pNumConstants.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TI0, TThis>(this TThis thisVtbl, ID3DDeviceContextState* pState, ref ComPtr<TI0> ppPreviousState) where TI0 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->SwapDeviceContextState(pState, (ID3DDeviceContextState**) ppPreviousState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, Span<ID3DDeviceContextState> pState, ID3DDeviceContextState** ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SwapDeviceContextState(ref pState.GetPinnableReference(), ppPreviousState);
    }

    /// <summary>To be documented.</summary>
    public static void SwapDeviceContextState<TI0, TThis>(this TThis thisVtbl, ref ID3DDeviceContextState pState, ref ComPtr<TI0> ppPreviousState) where TI0 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        @this->SwapDeviceContextState(ref pState, (ID3DDeviceContextState**) ppPreviousState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState<TThis>(this TThis thisVtbl, Span<ID3DDeviceContextState> pState, ref ID3DDeviceContextState* ppPreviousState) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SwapDeviceContextState(ref pState.GetPinnableReference(), ref ppPreviousState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] float* Color, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(pView, Color, ref pRect.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] Span<float> Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(pView, ref Color.GetPinnableReference(), pRect, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, ID3D11View* pView, [Count(Count = 4)] Span<float> Color, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(pView, ref Color.GetPinnableReference(), ref pRect.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, Span<ID3D11View> pView, [Count(Count = 4)] float* Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(ref pView.GetPinnableReference(), Color, pRect, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, Span<ID3D11View> pView, [Count(Count = 4)] float* Color, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(ref pView.GetPinnableReference(), Color, ref pRect.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView<TThis>(this TThis thisVtbl, Span<ID3D11View> pView, [Count(Count = 4)] Span<float> Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(ref pView.GetPinnableReference(), ref Color.GetPinnableReference(), pRect, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static void ClearView<TThis>(this TThis thisVtbl, Span<ID3D11View> pView, [Count(Count = 4)] Span<float> Color, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ClearView(ref pView.GetPinnableReference(), ref Color.GetPinnableReference(), ref pRect.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1<TThis>(this TThis thisVtbl, ID3D11View* pResourceView, Span<Silk.NET.Maths.Rectangle<int>> pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardView1(pResourceView, ref pRects.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1<TThis>(this TThis thisVtbl, Span<ID3D11View> pResourceView, Silk.NET.Maths.Rectangle<int>* pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardView1(ref pResourceView.GetPinnableReference(), pRects, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardView1<TThis>(this TThis thisVtbl, Span<ID3D11View> pResourceView, Span<Silk.NET.Maths.Rectangle<int>> pRects, uint NumRects) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardView1(ref pResourceView.GetPinnableReference(), ref pRects.GetPinnableReference(), NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(pTiledResource, NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), pTiledResourceRegionSizes, ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), pTilePool, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, uint* pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, pRangeFlags, ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, uint* pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pTilePoolStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, uint NumTiledResourceRegions, Span<TiledResourceCoordinate> pTiledResourceRegionStartCoordinates, Span<TileRegionSize> pTiledResourceRegionSizes, Span<ID3D11Buffer> pTilePool, uint NumRanges, Span<uint> pRangeFlags, Span<uint> pTilePoolStartOffsets, Span<uint> pRangeTileCounts, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTileMappings(ref pTiledResource.GetPinnableReference(), NumTiledResourceRegions, ref pTiledResourceRegionStartCoordinates.GetPinnableReference(), ref pTiledResourceRegionSizes.GetPinnableReference(), ref pTilePool.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pTilePoolStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(pDestTiledResource, ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), pDestRegionStartCoordinate, ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), pSourceTiledResource, ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), pSourceRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestRegionStartCoordinate, Span<ID3D11Resource> pSourceTiledResource, Span<TiledResourceCoordinate> pSourceRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CopyTileMappings(ref pDestTiledResource.GetPinnableReference(), ref pDestRegionStartCoordinate.GetPinnableReference(), ref pSourceTiledResource.GetPinnableReference(), ref pSourceRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(pTiledResource, ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), pTileRegionStartCoordinate, ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), pTileRegionSize, ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pTiledResource, Span<TiledResourceCoordinate> pTileRegionStartCoordinate, Span<TileRegionSize> pTileRegionSize, Span<ID3D11Buffer> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTiles(ref pTiledResource.GetPinnableReference(), ref pTileRegionStartCoordinate.GetPinnableReference(), ref pTileRegionSize.GetPinnableReference(), ref pBuffer.GetPinnableReference(), BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, pDestTileRegionStartCoordinate, ref pDestTileRegionSize.GetPinnableReference(), pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, pDestTileRegionStartCoordinate, ref pDestTileRegionSize.GetPinnableReference(), ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, ref pDestTileRegionStartCoordinate.GetPinnableReference(), pDestTileRegionSize, pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, ref pDestTileRegionStartCoordinate.GetPinnableReference(), pDestTileRegionSize, ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, ref pDestTileRegionStartCoordinate.GetPinnableReference(), ref pDestTileRegionSize.GetPinnableReference(), pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, ID3D11Resource* pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(pDestTiledResource, ref pDestTileRegionStartCoordinate.GetPinnableReference(), ref pDestTileRegionSize.GetPinnableReference(), ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), pDestTileRegionStartCoordinate, pDestTileRegionSize, ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), pDestTileRegionStartCoordinate, ref pDestTileRegionSize.GetPinnableReference(), pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), pDestTileRegionStartCoordinate, ref pDestTileRegionSize.GetPinnableReference(), ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), ref pDestTileRegionStartCoordinate.GetPinnableReference(), pDestTileRegionSize, pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), ref pDestTileRegionStartCoordinate.GetPinnableReference(), pDestTileRegionSize, ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTiles<TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, void* pSourceTileData, uint Flags) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), ref pDestTileRegionStartCoordinate.GetPinnableReference(), ref pDestTileRegionSize.GetPinnableReference(), pSourceTileData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTiles<T0, TThis>(this TThis thisVtbl, Span<ID3D11Resource> pDestTiledResource, Span<TiledResourceCoordinate> pDestTileRegionStartCoordinate, Span<TileRegionSize> pDestTileRegionSize, Span<T0> pSourceTileData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTiles(ref pDestTiledResource.GetPinnableReference(), ref pDestTileRegionStartCoordinate.GetPinnableReference(), ref pDestTileRegionSize.GetPinnableReference(), ref pSourceTileData.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTilePool<TThis>(this TThis thisVtbl, Span<ID3D11Buffer> pTilePool, ulong NewSizeInBytes) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResizeTilePool(ref pTilePool.GetPinnableReference(), NewSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void TiledResourceBarrier<TThis>(this TThis thisVtbl, ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, Span<ID3D11DeviceChild> pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->TiledResourceBarrier(pTiledResourceOrViewAccessBeforeBarrier, ref pTiledResourceOrViewAccessAfterBarrier.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void TiledResourceBarrier<TThis>(this TThis thisVtbl, Span<ID3D11DeviceChild> pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->TiledResourceBarrier(ref pTiledResourceOrViewAccessBeforeBarrier.GetPinnableReference(), pTiledResourceOrViewAccessAfterBarrier);
    }

    /// <summary>To be documented.</summary>
    public static void TiledResourceBarrier<TThis>(this TThis thisVtbl, Span<ID3D11DeviceChild> pTiledResourceOrViewAccessBeforeBarrier, Span<ID3D11DeviceChild> pTiledResourceOrViewAccessAfterBarrier) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->TiledResourceBarrier(ref pTiledResourceOrViewAccessBeforeBarrier.GetPinnableReference(), ref pTiledResourceOrViewAccessAfterBarrier.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetMarkerInt<TThis>(this TThis thisVtbl, Span<char> pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetMarkerInt(ref pLabel.GetPinnableReference(), Data);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEventInt<TThis>(this TThis thisVtbl, Span<char> pLabel, int Data) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->BeginEventInt(ref pLabel.GetPinnableReference(), Data);
    }

    /// <summary>To be documented.</summary>
    public static void Flush1<T0, TThis>(this TThis thisVtbl, ContextType ContextType, Span<T0> hEvent) where T0 : unmanaged where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->Flush1(ContextType, ref hEvent.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetHardwareProtectionState<TThis>(this TThis thisVtbl, Span<int> pHwProtectionEnable) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetHardwareProtectionState(ref pHwProtectionEnable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Signal<TThis>(this TThis thisVtbl, Span<ID3D11Fence> pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Signal(ref pFence.GetPinnableReference(), Value);
    }

    /// <summary>To be documented.</summary>
    public static int Wait<TThis>(this TThis thisVtbl, Span<ID3D11Fence> pFence, ulong Value) where TThis : IComVtbl<ID3D11DeviceContext4>
    {
        var @this = (ID3D11DeviceContext4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Wait(ref pFence.GetPinnableReference(), Value);
    }

}
