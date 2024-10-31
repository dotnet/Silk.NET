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

public unsafe static class D3D12DeviceConfigurationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DeviceConfiguration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DeviceConfiguration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DeviceConfigurationDesc GetDesc(this ComPtr<ID3D12DeviceConfiguration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DeviceConfigurationDesc silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        DeviceConfigurationDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, DeviceConfigurationDesc*, DeviceConfigurationDesc*>)@this->LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnabledExperimentalFeatures(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Guid* pGuids, uint NumGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, uint, int>)@this->LpVtbl[4])(@this, pGuids, NumGuids);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEnabledExperimentalFeatures(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, ref Guid pGuids, uint NumGuids)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pGuidsPtr = &pGuids)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, Guid*, uint, int>)@this->LpVtbl[4])(@this, pGuidsPtr, NumGuids);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResult, ppError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResult, ppErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResultPtr, ppError);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResultPtr, ppErrorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResult, ppError);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResult, ppErrorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResultPtr, ppError);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResultPtr, ppErrorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Guid* riid, void** ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riid, ppvDeserializer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Guid* riid, ref void* ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDeserializerPtr = &ppvDeserializer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riid, ppvDeserializerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, ref Guid riid, void** ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riidPtr, ppvDeserializer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, ref Guid riid, ref void* ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDeserializerPtr = &ppvDeserializer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riidPtr, ppvDeserializerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riid, ppvDeserializer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobPtr = &pBlob)
        {
            fixed (void** ppvDeserializerPtr = &ppvDeserializer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riid, ppvDeserializerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, ref Guid riid, void** ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobPtr = &pBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riidPtr, ppvDeserializer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, ref Guid riid, ref void* ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pBlobPtr = &pBlob)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riidPtr, ppvDeserializerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetEnabledExperimentalFeatures(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, Span<Guid> pGuids, uint NumGuids)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEnabledExperimentalFeatures(ref pGuids.GetPinnableReference(), NumGuids);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature<TI0, TI1>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref ComPtr<TI0> ppResult, ref ComPtr<TI1> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref ComPtr<TI0> ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), ref ppError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(pDesc, ref ppResult, (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SerializeVersionedRootSignature(in pDesc.GetPinnableReference(), ppResult, ppError);
    }

    /// <summary>To be documented.</summary>
    public static int SerializeVersionedRootSignature<TI0, TI1>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref ComPtr<TI0> ppResult, ref ComPtr<TI1> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(in pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SerializeVersionedRootSignature(in pDesc.GetPinnableReference(), ppResult, ref ppError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref ComPtr<TI0> ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(in pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), ref ppError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SerializeVersionedRootSignature(in pDesc.GetPinnableReference(), ref ppResult, ppError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SerializeVersionedRootSignature(in pDesc, ref ppResult, (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeVersionedRootSignature(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SerializeVersionedRootSignature(in pDesc.GetPinnableReference(), ref ppResult, ref ppError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, out ComPtr<TI0> ppvDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDeserializer = default;
        return @this->CreateVersionedRootSignatureDeserializer(pBlob, Size, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Span<Guid> riid, void** ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(pBlob, Size, ref riid.GetPinnableReference(), ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Span<Guid> riid, ref void* ppvDeserializer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(pBlob, Size, ref riid.GetPinnableReference(), ref ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlob, nuint Size, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(in pBlob.GetPinnableReference(), Size, riid, ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVersionedRootSignatureDeserializer<T0, TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, out ComPtr<TI0> ppvDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDeserializer = default;
        return @this->CreateVersionedRootSignatureDeserializer(in pBlob, Size, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlob, nuint Size, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(in pBlob.GetPinnableReference(), Size, riid, ref ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlob, nuint Size, Span<Guid> riid, void** ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(in pBlob.GetPinnableReference(), Size, ref riid.GetPinnableReference(), ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pBlob, nuint Size, Span<Guid> riid, ref void* ppvDeserializer) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVersionedRootSignatureDeserializer(in pBlob.GetPinnableReference(), Size, ref riid.GetPinnableReference(), ref ppvDeserializer);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializer<TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializer(pBlob, Size, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVersionedRootSignatureDeserializer<T0, TI0>(this ComPtr<ID3D12DeviceConfiguration> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializer(in pBlob, Size, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
