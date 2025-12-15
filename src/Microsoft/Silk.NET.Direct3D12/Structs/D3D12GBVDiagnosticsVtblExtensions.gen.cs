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

public unsafe static class D3D12GBVDiagnosticsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12GBVDiagnostics> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12GBVDiagnostics> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, int* pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResource, pData, DataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref int pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResource, pDataPtr, DataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, int* pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResourcePtr, pData, DataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref int pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResourcePtr, pDataPtr, DataSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, uint Subresource, int* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResource, Subresource, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, uint Subresource, ref int pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResource, Subresource, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, uint Subresource, int* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, uint Subresource, ref int pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, int* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResource, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref int pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResource, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, int* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResourcePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref int pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResourcePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffsetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pResourceHashPtr = &pResourceHash)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pResourceHashPtr = &pResourceHash)
        {
            fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
        {
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHash, pSubresourceStatesByteOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void GBVReserved0(this ComPtr<ID3D12GBVDiagnostics> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, void>)@this->LpVtbl[7])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void GBVReserved1(this ComPtr<ID3D12GBVDiagnostics> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, void>)@this->LpVtbl[8])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, int* pData, uint DataSize) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVEntireSubresourceStatesData((ID3D12Resource*) pResource.Handle, pData, DataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<int> pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVEntireSubresourceStatesData(pResource, ref pData.GetPinnableReference(), DataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVEntireSubresourceStatesData<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref int pData, uint DataSize) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVEntireSubresourceStatesData((ID3D12Resource*) pResource.Handle, ref pData, DataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, int* pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVEntireSubresourceStatesData(ref pResource.GetPinnableReference(), pData, DataSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVEntireSubresourceStatesData(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<int> pData, uint DataSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVEntireSubresourceStatesData(ref pResource.GetPinnableReference(), ref pData.GetPinnableReference(), DataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, uint Subresource, int* pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVSubresourceState((ID3D12Resource*) pResource.Handle, Subresource, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, uint Subresource, Span<int> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVSubresourceState(pResource, Subresource, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVSubresourceState<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, uint Subresource, ref int pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVSubresourceState((ID3D12Resource*) pResource.Handle, Subresource, ref pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, int* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVSubresourceState(ref pResource.GetPinnableReference(), Subresource, pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVSubresourceState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, uint Subresource, Span<int> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVSubresourceState(ref pResource.GetPinnableReference(), Subresource, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, int* pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceUniformState((ID3D12Resource*) pResource.Handle, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<int> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceUniformState(pResource, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceUniformState<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref int pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceUniformState((ID3D12Resource*) pResource.Handle, ref pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, int* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceUniformState(ref pResource.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceUniformState(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<int> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceUniformState(ref pResource.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, Span<uint> pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, pResourceDesc, ref pResourceHash.GetPinnableReference(), pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, ref pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, ResourceDesc* pResourceDesc, Span<uint> pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, pResourceDesc, ref pResourceHash.GetPinnableReference(), ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, ref pResourceHash, ref pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<ResourceDesc> pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, ref pResourceDesc.GetPinnableReference(), pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<ResourceDesc> pResourceDesc, uint* pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, ref pResourceDesc.GetPinnableReference(), pResourceHash, ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<ResourceDesc> pResourceDesc, Span<uint> pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, ref pResourceDesc.GetPinnableReference(), ref pResourceHash.GetPinnableReference(), pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, ref pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ID3D12Resource* pResource, Span<ResourceDesc> pResourceDesc, Span<uint> pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(pResource, ref pResourceDesc.GetPinnableReference(), ref pResourceHash.GetPinnableReference(), ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceInfo<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, ref pResourceHash, ref pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, ResourceDesc* pResourceDesc, Span<uint> pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), pResourceDesc, ref pResourceHash.GetPinnableReference(), pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, ResourceDesc* pResourceDesc, Span<uint> pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), pResourceDesc, ref pResourceHash.GetPinnableReference(), ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<ResourceDesc> pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), ref pResourceDesc.GetPinnableReference(), pResourceHash, pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<ResourceDesc> pResourceDesc, uint* pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), ref pResourceDesc.GetPinnableReference(), pResourceHash, ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<ResourceDesc> pResourceDesc, Span<uint> pResourceHash, uint* pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), ref pResourceDesc.GetPinnableReference(), ref pResourceHash.GetPinnableReference(), pSubresourceStatesByteOffset);
    }

    /// <summary>To be documented.</summary>
    public static int GetGBVResourceInfo(this ComPtr<ID3D12GBVDiagnostics> thisVtbl, Span<ID3D12Resource> pResource, Span<ResourceDesc> pResourceDesc, Span<uint> pResourceHash, Span<uint> pSubresourceStatesByteOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGBVResourceInfo(ref pResource.GetPinnableReference(), ref pResourceDesc.GetPinnableReference(), ref pResourceHash.GetPinnableReference(), ref pSubresourceStatesByteOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12GBVDiagnostics> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
