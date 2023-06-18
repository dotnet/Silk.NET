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

namespace Silk.NET.Direct3D11
{
    [Guid("9d06dffa-d1e5-4d07-83a8-1bb123f2f841")]
    [NativeName("Name", "ID3D11Device2")]
    public unsafe partial struct ID3D11Device2 : IComVtbl<ID3D11Device2>, IComVtbl<ID3D11Device1>, IComVtbl<ID3D11Device>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9d06dffa-d1e5-4d07-83a8-1bb123f2f841");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11Device1(ID3D11Device2 val)
            => Unsafe.As<ID3D11Device2, ID3D11Device1>(ref val);

        public static implicit operator ID3D11Device(ID3D11Device2 val)
            => Unsafe.As<ID3D11Device2, ID3D11Device>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Device2 val)
            => Unsafe.As<ID3D11Device2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Device2
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceData* pInitialData, ID3D11Buffer** ppBuffer)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, BufferDesc*, SubresourceData*, ID3D11Buffer**, int>)@this->LpVtbl[3])(@this, pDesc, pInitialData, ppBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture1DDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceData* pInitialData, ID3D11Texture1D** ppTexture1D)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Texture1DDesc*, SubresourceData*, ID3D11Texture1D**, int>)@this->LpVtbl[4])(@this, pDesc, pInitialData, ppTexture1D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture2DDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceData* pInitialData, ID3D11Texture2D** ppTexture2D)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Texture2DDesc*, SubresourceData*, ID3D11Texture2D**, int>)@this->LpVtbl[5])(@this, pDesc, pInitialData, ppTexture2D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture3DDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceData* pInitialData, ID3D11Texture3D** ppTexture3D)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Texture3DDesc*, SubresourceData*, ID3D11Texture3D**, int>)@this->LpVtbl[6])(@this, pDesc, pInitialData, ppTexture3D);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateShaderResourceView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, ID3D11ShaderResourceView** ppSRView)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11Resource*, ShaderResourceViewDesc*, ID3D11ShaderResourceView**, int>)@this->LpVtbl[7])(@this, pResource, pDesc, ppSRView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateUnorderedAccessView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, ID3D11UnorderedAccessView** ppUAView)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11Resource*, UnorderedAccessViewDesc*, ID3D11UnorderedAccessView**, int>)@this->LpVtbl[8])(@this, pResource, pDesc, ppUAView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderTargetView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, ID3D11RenderTargetView** ppRTView)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11Resource*, RenderTargetViewDesc*, ID3D11RenderTargetView**, int>)@this->LpVtbl[9])(@this, pResource, pDesc, ppRTView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilView(ID3D11Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11Resource*, DepthStencilViewDesc*, ID3D11DepthStencilView**, int>)@this->LpVtbl[10])(@this, pResource, pDesc, ppDepthStencilView);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInputLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] InputElementDesc* pInputElementDescs, uint NumElements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecodeWithInputSignature, nuint BytecodeLength, ID3D11InputLayout** ppInputLayout)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, InputElementDesc*, uint, void*, nuint, ID3D11InputLayout**, int>)@this->LpVtbl[11])(@this, pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)@this->LpVtbl[12])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)@this->LpVtbl[13])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGeometryShaderWithStreamOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SODeclarationEntry* pSODeclaration, uint NumEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pBufferStrides, uint NumStrides, uint RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, SODeclarationEntry*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)@this->LpVtbl[14])(@this, pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePixelShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)@this->LpVtbl[15])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHullShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int>)@this->LpVtbl[16])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDomainShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)@this->LpVtbl[17])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)@this->LpVtbl[18])(@this, pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11ClassLinkage**, int>)@this->LpVtbl[19])(@this, ppLinkage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendState([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDesc* pBlendStateDesc, ID3D11BlendState** ppBlendState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, BlendDesc*, ID3D11BlendState**, int>)@this->LpVtbl[20])(@this, pBlendStateDesc, ppBlendState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDepthStencilState([Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilDesc* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, DepthStencilDesc*, ID3D11DepthStencilState**, int>)@this->LpVtbl[21])(@this, pDepthStencilDesc, ppDepthStencilState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRasterizerState([Flow(Silk.NET.Core.Native.FlowDirection.In)] RasterizerDesc* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, RasterizerDesc*, ID3D11RasterizerState**, int>)@this->LpVtbl[22])(@this, pRasterizerDesc, ppRasterizerState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSamplerState([Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDesc* pSamplerDesc, ID3D11SamplerState** ppSamplerState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, SamplerDesc*, ID3D11SamplerState**, int>)@this->LpVtbl[23])(@this, pSamplerDesc, ppSamplerState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryDesc* pQueryDesc, ID3D11Query** ppQuery)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, QueryDesc*, ID3D11Query**, int>)@this->LpVtbl[24])(@this, pQueryDesc, ppQuery);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePredicate([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryDesc* pPredicateDesc, ID3D11Predicate** ppPredicate)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, QueryDesc*, ID3D11Predicate**, int>)@this->LpVtbl[25])(@this, pPredicateDesc, ppPredicate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCounter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CounterDesc* pCounterDesc, ID3D11Counter** ppCounter)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, CounterDesc*, ID3D11Counter**, int>)@this->LpVtbl[26])(@this, pCounterDesc, ppCounter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeferredContext(uint ContextFlags, ID3D11DeviceContext** ppDeferredContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint, ID3D11DeviceContext**, int>)@this->LpVtbl[27])(@this, ContextFlags, ppDeferredContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedResource(void* hResource, Guid* ReturnedInterface, void** ppResource)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, Guid*, void**, int>)@this->LpVtbl[28])(@this, hResource, ReturnedInterface, ppResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFormatSupport(Silk.NET.DXGI.Format Format, uint* pFormatSupport)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[29])(@this, Format, pFormatSupport);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckMultisampleQualityLevels(Silk.NET.DXGI.Format Format, uint SampleCount, uint* pNumQualityLevels)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Silk.NET.DXGI.Format, uint, uint*, int>)@this->LpVtbl[30])(@this, Format, SampleCount, pNumQualityLevels);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CheckCounterInfo(CounterInfo* pCounterInfo)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Device2*, CounterInfo*, void>)@this->LpVtbl[31])(@this, pCounterInfo);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCounter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CounterDesc* pDesc, CounterType* pType, uint* pActiveCounters, byte* szName, uint* pNameLength, byte* szUnits, uint* pUnitsLength, byte* szDescription, uint* pDescriptionLength)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, CounterDesc*, CounterType*, uint*, byte*, uint*, byte*, uint*, byte*, uint*, int>)@this->LpVtbl[32])(@this, pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Feature, void*, uint, int>)@this->LpVtbl[33])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Guid*, uint*, void*, int>)@this->LpVtbl[34])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Guid*, uint, void*, int>)@this->LpVtbl[35])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[36])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Native.D3DFeatureLevel GetFeatureLevel()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Native.D3DFeatureLevel ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Silk.NET.Core.Native.D3DFeatureLevel>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCreationFlags()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint>)@this->LpVtbl[38])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceRemovedReason()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, int>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetImmediateContext(ID3D11DeviceContext** ppImmediateContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11DeviceContext**, void>)@this->LpVtbl[40])(@this, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetExceptionMode(uint RaiseFlags)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint, int>)@this->LpVtbl[41])(@this, RaiseFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetExceptionMode()
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetImmediateContext1(ID3D11DeviceContext1** ppImmediateContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11DeviceContext1**, void>)@this->LpVtbl[43])(@this, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeferredContext1(uint ContextFlags, ID3D11DeviceContext1** ppDeferredContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint, ID3D11DeviceContext1**, int>)@this->LpVtbl[44])(@this, ContextFlags, ppDeferredContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlendState1([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDesc1* pBlendStateDesc, ID3D11BlendState1** ppBlendState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, BlendDesc1*, ID3D11BlendState1**, int>)@this->LpVtbl[45])(@this, pBlendStateDesc, ppBlendState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRasterizerState1([Flow(Silk.NET.Core.Native.FlowDirection.In)] RasterizerDesc1* pRasterizerDesc, ID3D11RasterizerState1** ppRasterizerState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, RasterizerDesc1*, ID3D11RasterizerState1**, int>)@this->LpVtbl[46])(@this, pRasterizerDesc, ppRasterizerState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceContextState(uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Guid* EmulatedInterface, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel, ID3DDeviceContextState** ppContextState)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint, Silk.NET.Core.Native.D3DFeatureLevel*, uint, uint, Guid*, Silk.NET.Core.Native.D3DFeatureLevel*, ID3DDeviceContextState**, int>)@this->LpVtbl[47])(@this, Flags, pFeatureLevels, FeatureLevels, SDKVersion, EmulatedInterface, pChosenFeatureLevel, ppContextState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedResource1(void* hResource, Guid* returnedInterface, void** ppResource)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, hResource, returnedInterface, ppResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedResourceByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* lpName, uint dwDesiredAccess, Guid* returnedInterface, void** ppResource)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, char*, uint, Guid*, void**, int>)@this->LpVtbl[49])(@this, lpName, dwDesiredAccess, returnedInterface, ppResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetImmediateContext2(ID3D11DeviceContext2** ppImmediateContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11DeviceContext2**, void>)@this->LpVtbl[50])(@this, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeferredContext2(uint ContextFlags, ID3D11DeviceContext2** ppDeferredContext)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, uint, ID3D11DeviceContext2**, int>)@this->LpVtbl[51])(@this, ContextFlags, ppDeferredContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D11Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipDesc* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Device2*, ID3D11Resource*, uint*, PackedMipDesc*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[52])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckMultisampleQualityLevels1(Silk.NET.DXGI.Format Format, uint SampleCount, uint Flags, uint* pNumQualityLevels)
        {
            var @this = (ID3D11Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Device2*, Silk.NET.DXGI.Format, uint, uint, uint*, int>)@this->LpVtbl[53])(@this, Format, SampleCount, Flags, pNumQualityLevels);
            return ret;
        }

    }
}
