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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12
{
    public static class D3D11On12Overloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(pDevice, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public static unsafe int On12CreateDevice(this D3D11On12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Span<Silk.NET.Core.Native.D3DFeatureLevel> pChosenFeatureLevel)
        {
            // SpanOverloader
            return thisApi.On12CreateDevice(ref pDevice.GetPinnableReference(), Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel.GetPinnableReference());
        }

    }
}

