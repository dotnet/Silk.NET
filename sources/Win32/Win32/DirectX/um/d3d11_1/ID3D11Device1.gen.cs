// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("A04BFB29-08EF-43D6-A49C-A9BDBDCBE686")]
[NativeTypeName("struct ID3D11Device1 : ID3D11Device")]
[NativeInheritance("ID3D11Device")]
public unsafe partial struct ID3D11Device1 : ID3D11Device1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Device1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Device1, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11Device1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Device1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBuffer(
        [NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc,
        [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData,
        ID3D11Buffer* ppBuffer
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_BUFFER_DESC*,
                D3D11_SUBRESOURCE_DATA*,
                ID3D11Buffer*,
                int>)((*lpVtbl)[3])
        )(this, pDesc, pInitialData, ppBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTexture1D(
        [NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc,
        [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData,
        ID3D11Texture1D* ppTexture1D
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_TEXTURE1D_DESC*,
                D3D11_SUBRESOURCE_DATA*,
                ID3D11Texture1D*,
                int>)((*lpVtbl)[4])
        )(this, pDesc, pInitialData, ppTexture1D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateTexture2D(
        [NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc,
        [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData,
        ID3D11Texture2D* ppTexture2D
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_TEXTURE2D_DESC*,
                D3D11_SUBRESOURCE_DATA*,
                ID3D11Texture2D*,
                int>)((*lpVtbl)[5])
        )(this, pDesc, pInitialData, ppTexture2D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTexture3D(
        [NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc,
        [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData,
        ID3D11Texture3D* ppTexture3D
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_TEXTURE3D_DESC*,
                D3D11_SUBRESOURCE_DATA*,
                ID3D11Texture3D*,
                int>)((*lpVtbl)[6])
        )(this, pDesc, pInitialData, ppTexture3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateShaderResourceView(
        ID3D11Resource pResource,
        [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")]
            D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc,
        ID3D11ShaderResourceView* ppSRView
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                ID3D11Resource,
                D3D11_SHADER_RESOURCE_VIEW_DESC*,
                ID3D11ShaderResourceView*,
                int>)((*lpVtbl)[7])
        )(this, pResource, pDesc, ppSRView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateUnorderedAccessView(
        ID3D11Resource pResource,
        [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")]
            D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc,
        ID3D11UnorderedAccessView* ppUAView
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                ID3D11Resource,
                D3D11_UNORDERED_ACCESS_VIEW_DESC*,
                ID3D11UnorderedAccessView*,
                int>)((*lpVtbl)[8])
        )(this, pResource, pDesc, ppUAView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateRenderTargetView(
        ID3D11Resource pResource,
        [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")]
            D3D11_RENDER_TARGET_VIEW_DESC* pDesc,
        ID3D11RenderTargetView* ppRTView
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                ID3D11Resource,
                D3D11_RENDER_TARGET_VIEW_DESC*,
                ID3D11RenderTargetView*,
                int>)((*lpVtbl)[9])
        )(this, pResource, pDesc, ppRTView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDepthStencilView(
        ID3D11Resource pResource,
        [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")]
            D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc,
        ID3D11DepthStencilView* ppDepthStencilView
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                ID3D11Resource,
                D3D11_DEPTH_STENCIL_VIEW_DESC*,
                ID3D11DepthStencilView*,
                int>)((*lpVtbl)[10])
        )(this, pResource, pDesc, ppDepthStencilView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateInputLayout(
        [NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")]
            D3D11_INPUT_ELEMENT_DESC* pInputElementDescs,
        uint NumElements,
        [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11InputLayout* ppInputLayout
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_INPUT_ELEMENT_DESC*,
                uint,
                void*,
                nuint,
                ID3D11InputLayout*,
                int>)((*lpVtbl)[11])
        )(
            this,
            pInputElementDescs,
            NumElements,
            pShaderBytecodeWithInputSignature,
            BytecodeLength,
            ppInputLayout
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateVertexShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11VertexShader* ppVertexShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11VertexShader*,
                int>)((*lpVtbl)[12])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateGeometryShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11GeometryShader* ppGeometryShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11GeometryShader*,
                int>)((*lpVtbl)[13])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateGeometryShaderWithStreamOutput(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")]
            D3D11_SO_DECLARATION_ENTRY* pSODeclaration,
        uint NumEntries,
        [NativeTypeName("const UINT *")] uint* pBufferStrides,
        uint NumStrides,
        uint RasterizedStream,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11GeometryShader* ppGeometryShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                D3D11_SO_DECLARATION_ENTRY*,
                uint,
                uint*,
                uint,
                uint,
                ID3D11ClassLinkage,
                ID3D11GeometryShader*,
                int>)((*lpVtbl)[14])
        )(
            this,
            pShaderBytecode,
            BytecodeLength,
            pSODeclaration,
            NumEntries,
            pBufferStrides,
            NumStrides,
            RasterizedStream,
            pClassLinkage,
            ppGeometryShader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreatePixelShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11PixelShader* ppPixelShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11PixelShader*,
                int>)((*lpVtbl)[15])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateHullShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11HullShader* ppHullShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11HullShader*,
                int>)((*lpVtbl)[16])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDomainShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11DomainShader* ppDomainShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11DomainShader*,
                int>)((*lpVtbl)[17])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateComputeShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D11ClassLinkage pClassLinkage,
        ID3D11ComputeShader* ppComputeShader
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                void*,
                nuint,
                ID3D11ClassLinkage,
                ID3D11ComputeShader*,
                int>)((*lpVtbl)[18])
        )(this, pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateClassLinkage(ID3D11ClassLinkage* ppLinkage)
    {
        return ((delegate* unmanaged<ID3D11Device1, ID3D11ClassLinkage*, int>)((*lpVtbl)[19]))(
            this,
            ppLinkage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateBlendState(
        [NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc,
        ID3D11BlendState* ppBlendState
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_BLEND_DESC*, ID3D11BlendState*, int>)(
                (*lpVtbl)[20]
            )
        )(this, pBlendStateDesc, ppBlendState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateDepthStencilState(
        [NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")]
            D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc,
        ID3D11DepthStencilState* ppDepthStencilState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_DEPTH_STENCIL_DESC*,
                ID3D11DepthStencilState*,
                int>)((*lpVtbl)[21])
        )(this, pDepthStencilDesc, ppDepthStencilState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRasterizerState(
        [NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc,
        ID3D11RasterizerState* ppRasterizerState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_RASTERIZER_DESC*,
                ID3D11RasterizerState*,
                int>)((*lpVtbl)[22])
        )(this, pRasterizerDesc, ppRasterizerState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateSamplerState(
        [NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc,
        ID3D11SamplerState* ppSamplerState
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_SAMPLER_DESC*, ID3D11SamplerState*, int>)(
                (*lpVtbl)[23]
            )
        )(this, pSamplerDesc, ppSamplerState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateQuery(
        [NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc,
        ID3D11Query* ppQuery
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_QUERY_DESC*, ID3D11Query*, int>)(
                (*lpVtbl)[24]
            )
        )(this, pQueryDesc, ppQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreatePredicate(
        [NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc,
        ID3D11Predicate* ppPredicate
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_QUERY_DESC*, ID3D11Predicate*, int>)(
                (*lpVtbl)[25]
            )
        )(this, pPredicateDesc, ppPredicate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateCounter(
        [NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc,
        ID3D11Counter* ppCounter
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_COUNTER_DESC*, ID3D11Counter*, int>)(
                (*lpVtbl)[26]
            )
        )(this, pCounterDesc, ppCounter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateDeferredContext(uint ContextFlags, ID3D11DeviceContext* ppDeferredContext)
    {
        return (
            (delegate* unmanaged<ID3D11Device1, uint, ID3D11DeviceContext*, int>)((*lpVtbl)[27])
        )(this, ContextFlags, ppDeferredContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT OpenSharedResource(
        HANDLE hResource,
        [NativeTypeName("const IID &")] Guid* ReturnedInterface,
        void** ppResource
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, HANDLE, Guid*, void**, int>)((*lpVtbl)[28]))(
            this,
            hResource,
            ReturnedInterface,
            ppResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CheckFormatSupport(DXGI_FORMAT Format, uint* pFormatSupport)
    {
        return ((delegate* unmanaged<ID3D11Device1, DXGI_FORMAT, uint*, int>)((*lpVtbl)[29]))(
            this,
            Format,
            pFormatSupport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CheckMultisampleQualityLevels(
        DXGI_FORMAT Format,
        uint SampleCount,
        uint* pNumQualityLevels
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, DXGI_FORMAT, uint, uint*, int>)((*lpVtbl)[30]))(
            this,
            Format,
            SampleCount,
            pNumQualityLevels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void CheckCounterInfo(D3D11_COUNTER_INFO* pCounterInfo)
    {
        ((delegate* unmanaged<ID3D11Device1, D3D11_COUNTER_INFO*, void>)((*lpVtbl)[31]))(
            this,
            pCounterInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CheckCounter(
        [NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc,
        D3D11_COUNTER_TYPE* pType,
        uint* pActiveCounters,
        [NativeTypeName("LPSTR")] sbyte* szName,
        uint* pNameLength,
        [NativeTypeName("LPSTR")] sbyte* szUnits,
        uint* pUnitsLength,
        [NativeTypeName("LPSTR")] sbyte* szDescription,
        uint* pDescriptionLength
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_COUNTER_DESC*,
                D3D11_COUNTER_TYPE*,
                uint*,
                sbyte*,
                uint*,
                sbyte*,
                uint*,
                sbyte*,
                uint*,
                int>)((*lpVtbl)[32])
        )(
            this,
            pDesc,
            pType,
            pActiveCounters,
            szName,
            pNameLength,
            szUnits,
            pUnitsLength,
            szDescription,
            pDescriptionLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CheckFeatureSupport(
        D3D11_FEATURE Feature,
        void* pFeatureSupportData,
        uint FeatureSupportDataSize
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_FEATURE, void*, uint, int>)((*lpVtbl)[33])
        )(this, Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, Guid*, uint*, void*, int>)((*lpVtbl)[34]))(
            this,
            guid,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, Guid*, uint, void*, int>)((*lpVtbl)[35]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, Guid*, IUnknown, int>)((*lpVtbl)[36]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public D3D_FEATURE_LEVEL GetFeatureLevel()
    {
        return ((delegate* unmanaged<ID3D11Device1, D3D_FEATURE_LEVEL>)((*lpVtbl)[37]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public uint GetCreationFlags()
    {
        return ((delegate* unmanaged<ID3D11Device1, uint>)((*lpVtbl)[38]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetDeviceRemovedReason()
    {
        return ((delegate* unmanaged<ID3D11Device1, int>)((*lpVtbl)[39]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void GetImmediateContext(ID3D11DeviceContext* ppImmediateContext)
    {
        ((delegate* unmanaged<ID3D11Device1, ID3D11DeviceContext*, void>)((*lpVtbl)[40]))(
            this,
            ppImmediateContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetExceptionMode(uint RaiseFlags)
    {
        return ((delegate* unmanaged<ID3D11Device1, uint, int>)((*lpVtbl)[41]))(this, RaiseFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public uint GetExceptionMode()
    {
        return ((delegate* unmanaged<ID3D11Device1, uint>)((*lpVtbl)[42]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void GetImmediateContext1(ID3D11DeviceContext1* ppImmediateContext)
    {
        ((delegate* unmanaged<ID3D11Device1, ID3D11DeviceContext1*, void>)((*lpVtbl)[43]))(
            this,
            ppImmediateContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateDeferredContext1(
        uint ContextFlags,
        ID3D11DeviceContext1* ppDeferredContext
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, uint, ID3D11DeviceContext1*, int>)((*lpVtbl)[44])
        )(this, ContextFlags, ppDeferredContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT CreateBlendState1(
        [NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc,
        ID3D11BlendState1* ppBlendState
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, D3D11_BLEND_DESC1*, ID3D11BlendState1*, int>)(
                (*lpVtbl)[45]
            )
        )(this, pBlendStateDesc, ppBlendState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT CreateRasterizerState1(
        [NativeTypeName("const D3D11_RASTERIZER_DESC1 *")] D3D11_RASTERIZER_DESC1* pRasterizerDesc,
        ID3D11RasterizerState1* ppRasterizerState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                D3D11_RASTERIZER_DESC1*,
                ID3D11RasterizerState1*,
                int>)((*lpVtbl)[46])
        )(this, pRasterizerDesc, ppRasterizerState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT CreateDeviceContextState(
        uint Flags,
        [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels,
        uint FeatureLevels,
        uint SDKVersion,
        [NativeTypeName("const IID &")] Guid* EmulatedInterface,
        D3D_FEATURE_LEVEL* pChosenFeatureLevel,
        ID3DDeviceContextState* ppContextState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Device1,
                uint,
                D3D_FEATURE_LEVEL*,
                uint,
                uint,
                Guid*,
                D3D_FEATURE_LEVEL*,
                ID3DDeviceContextState*,
                int>)((*lpVtbl)[47])
        )(
            this,
            Flags,
            pFeatureLevels,
            FeatureLevels,
            SDKVersion,
            EmulatedInterface,
            pChosenFeatureLevel,
            ppContextState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT OpenSharedResource1(
        HANDLE hResource,
        [NativeTypeName("const IID &")] Guid* returnedInterface,
        void** ppResource
    )
    {
        return ((delegate* unmanaged<ID3D11Device1, HANDLE, Guid*, void**, int>)((*lpVtbl)[48]))(
            this,
            hResource,
            returnedInterface,
            ppResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT OpenSharedResourceByName(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("const IID &")] Guid* returnedInterface,
        void** ppResource
    )
    {
        return (
            (delegate* unmanaged<ID3D11Device1, ushort*, uint, Guid*, void**, int>)((*lpVtbl)[49])
        )(this, lpName, dwDesiredAccess, returnedInterface, ppResource);
    }

    public interface Interface : ID3D11Device.Interface
    {
        [VtblIndex(43)]
        void GetImmediateContext1(ID3D11DeviceContext1* ppImmediateContext);

        [VtblIndex(44)]
        HRESULT CreateDeferredContext1(uint ContextFlags, ID3D11DeviceContext1* ppDeferredContext);

        [VtblIndex(45)]
        HRESULT CreateBlendState1(
            [NativeTypeName("const D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pBlendStateDesc,
            ID3D11BlendState1* ppBlendState
        );

        [VtblIndex(46)]
        HRESULT CreateRasterizerState1(
            [NativeTypeName("const D3D11_RASTERIZER_DESC1 *")]
                D3D11_RASTERIZER_DESC1* pRasterizerDesc,
            ID3D11RasterizerState1* ppRasterizerState
        );

        [VtblIndex(47)]
        HRESULT CreateDeviceContextState(
            uint Flags,
            [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels,
            uint FeatureLevels,
            uint SDKVersion,
            [NativeTypeName("const IID &")] Guid* EmulatedInterface,
            D3D_FEATURE_LEVEL* pChosenFeatureLevel,
            ID3DDeviceContextState* ppContextState
        );

        [VtblIndex(48)]
        HRESULT OpenSharedResource1(
            HANDLE hResource,
            [NativeTypeName("const IID &")] Guid* returnedInterface,
            void** ppResource
        );

        [VtblIndex(49)]
        HRESULT OpenSharedResourceByName(
            [NativeTypeName("LPCWSTR")] ushort* lpName,
            [NativeTypeName("DWORD")] uint dwDesiredAccess,
            [NativeTypeName("const IID &")] Guid* returnedInterface,
            void** ppResource
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName(
            "HRESULT (const D3D11_BUFFER_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Buffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_BUFFER_DESC*,
            D3D11_SUBRESOURCE_DATA*,
            ID3D11Buffer*,
            int> CreateBuffer;

        [NativeTypeName(
            "HRESULT (const D3D11_TEXTURE1D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture1D **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_TEXTURE1D_DESC*,
            D3D11_SUBRESOURCE_DATA*,
            ID3D11Texture1D*,
            int> CreateTexture1D;

        [NativeTypeName(
            "HRESULT (const D3D11_TEXTURE2D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture2D **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_TEXTURE2D_DESC*,
            D3D11_SUBRESOURCE_DATA*,
            ID3D11Texture2D*,
            int> CreateTexture2D;

        [NativeTypeName(
            "HRESULT (const D3D11_TEXTURE3D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture3D **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_TEXTURE3D_DESC*,
            D3D11_SUBRESOURCE_DATA*,
            ID3D11Texture3D*,
            int> CreateTexture3D;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, const D3D11_SHADER_RESOURCE_VIEW_DESC *, ID3D11ShaderResourceView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_SHADER_RESOURCE_VIEW_DESC*,
            ID3D11ShaderResourceView*,
            int> CreateShaderResourceView;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, const D3D11_UNORDERED_ACCESS_VIEW_DESC *, ID3D11UnorderedAccessView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_UNORDERED_ACCESS_VIEW_DESC*,
            ID3D11UnorderedAccessView*,
            int> CreateUnorderedAccessView;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, const D3D11_RENDER_TARGET_VIEW_DESC *, ID3D11RenderTargetView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_RENDER_TARGET_VIEW_DESC*,
            ID3D11RenderTargetView*,
            int> CreateRenderTargetView;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, const D3D11_DEPTH_STENCIL_VIEW_DESC *, ID3D11DepthStencilView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_DEPTH_STENCIL_VIEW_DESC*,
            ID3D11DepthStencilView*,
            int> CreateDepthStencilView;

        [NativeTypeName(
            "HRESULT (const D3D11_INPUT_ELEMENT_DESC *, UINT, const void *, SIZE_T, ID3D11InputLayout **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_INPUT_ELEMENT_DESC*,
            uint,
            void*,
            nuint,
            ID3D11InputLayout*,
            int> CreateInputLayout;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11VertexShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11VertexShader*,
            int> CreateVertexShader;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11GeometryShader*,
            int> CreateGeometryShader;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, const D3D11_SO_DECLARATION_ENTRY *, UINT, const UINT *, UINT, UINT, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            D3D11_SO_DECLARATION_ENTRY*,
            uint,
            uint*,
            uint,
            uint,
            ID3D11ClassLinkage,
            ID3D11GeometryShader*,
            int> CreateGeometryShaderWithStreamOutput;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11PixelShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11PixelShader*,
            int> CreatePixelShader;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11HullShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11HullShader*,
            int> CreateHullShader;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11DomainShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11DomainShader*,
            int> CreateDomainShader;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11ComputeShader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            ID3D11ClassLinkage,
            ID3D11ComputeShader*,
            int> CreateComputeShader;

        [NativeTypeName("HRESULT (ID3D11ClassLinkage **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ClassLinkage*, int> CreateClassLinkage;

        [NativeTypeName(
            "HRESULT (const D3D11_BLEND_DESC *, ID3D11BlendState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_BLEND_DESC*,
            ID3D11BlendState*,
            int> CreateBlendState;

        [NativeTypeName(
            "HRESULT (const D3D11_DEPTH_STENCIL_DESC *, ID3D11DepthStencilState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_DEPTH_STENCIL_DESC*,
            ID3D11DepthStencilState*,
            int> CreateDepthStencilState;

        [NativeTypeName(
            "HRESULT (const D3D11_RASTERIZER_DESC *, ID3D11RasterizerState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_RASTERIZER_DESC*,
            ID3D11RasterizerState*,
            int> CreateRasterizerState;

        [NativeTypeName(
            "HRESULT (const D3D11_SAMPLER_DESC *, ID3D11SamplerState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_SAMPLER_DESC*,
            ID3D11SamplerState*,
            int> CreateSamplerState;

        [NativeTypeName(
            "HRESULT (const D3D11_QUERY_DESC *, ID3D11Query **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D11_QUERY_DESC*, ID3D11Query*, int> CreateQuery;

        [NativeTypeName(
            "HRESULT (const D3D11_QUERY_DESC *, ID3D11Predicate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_QUERY_DESC*,
            ID3D11Predicate*,
            int> CreatePredicate;

        [NativeTypeName(
            "HRESULT (const D3D11_COUNTER_DESC *, ID3D11Counter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D11_COUNTER_DESC*, ID3D11Counter*, int> CreateCounter;

        [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11DeviceContext*, int> CreateDeferredContext;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenSharedResource;

        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint*, int> CheckFormatSupport;

        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DXGI_FORMAT,
            uint,
            uint*,
            int> CheckMultisampleQualityLevels;

        [NativeTypeName("void (D3D11_COUNTER_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_COUNTER_INFO*, void> CheckCounterInfo;

        [NativeTypeName(
            "HRESULT (const D3D11_COUNTER_DESC *, D3D11_COUNTER_TYPE *, UINT *, LPSTR, UINT *, LPSTR, UINT *, LPSTR, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_COUNTER_DESC*,
            D3D11_COUNTER_TYPE*,
            uint*,
            sbyte*,
            uint*,
            sbyte*,
            uint*,
            sbyte*,
            uint*,
            int> CheckCounter;

        [NativeTypeName("HRESULT (D3D11_FEATURE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_FEATURE, void*, uint, int> CheckFeatureSupport;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("D3D_FEATURE_LEVEL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_FEATURE_LEVEL> GetFeatureLevel;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCreationFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetDeviceRemovedReason;

        [NativeTypeName("void (ID3D11DeviceContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11DeviceContext*, void> GetImmediateContext;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetExceptionMode;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetExceptionMode;

        [NativeTypeName("void (ID3D11DeviceContext1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11DeviceContext1*, void> GetImmediateContext1;

        [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11DeviceContext1*, int> CreateDeferredContext1;

        [NativeTypeName(
            "HRESULT (const D3D11_BLEND_DESC1 *, ID3D11BlendState1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_BLEND_DESC1*,
            ID3D11BlendState1*,
            int> CreateBlendState1;

        [NativeTypeName(
            "HRESULT (const D3D11_RASTERIZER_DESC1 *, ID3D11RasterizerState1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_RASTERIZER_DESC1*,
            ID3D11RasterizerState1*,
            int> CreateRasterizerState1;

        [NativeTypeName(
            "HRESULT (UINT, const D3D_FEATURE_LEVEL *, UINT, UINT, const IID &, D3D_FEATURE_LEVEL *, ID3DDeviceContextState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D_FEATURE_LEVEL*,
            uint,
            uint,
            Guid*,
            D3D_FEATURE_LEVEL*,
            ID3DDeviceContextState*,
            int> CreateDeviceContextState;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenSharedResource1;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            Guid*,
            void**,
            int> OpenSharedResourceByName;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Device1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Device1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11Device"/> to <see cref = "ID3D11Device1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11Device"/> instance to be converted </param>
    public static explicit operator ID3D11Device1(Silk.NET.DirectX.ID3D11Device value)
    {
        return new ID3D11Device1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Device1"/> to <see cref = "Silk.NET.DirectX.ID3D11Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Device1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11Device(ID3D11Device1 value)
    {
        return new Silk.NET.DirectX.ID3D11Device(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Device1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Device1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Device1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Device1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Device1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Device1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
