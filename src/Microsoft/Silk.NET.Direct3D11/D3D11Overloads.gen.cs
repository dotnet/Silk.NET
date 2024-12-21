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
    public static class D3D11Overloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public static unsafe int CreateDirect3D11DeviceFromDXGIDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, Silk.NET.Core.Native.IInspectable** graphicsDevice)
        {
            // SpanOverloader
            return thisApi.CreateDirect3D11DeviceFromDXGIDevice(ref dxgiDevice.GetPinnableReference(), graphicsDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public static unsafe int CreateDirect3D11DeviceFromDXGIDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, ref Silk.NET.Core.Native.IInspectable* graphicsDevice)
        {
            // SpanOverloader
            return thisApi.CreateDirect3D11DeviceFromDXGIDevice(ref dxgiDevice.GetPinnableReference(), ref graphicsDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public static unsafe int CreateDirect3D11SurfaceFromDXGISurface(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGISurface> dgxiSurface, Silk.NET.Core.Native.IInspectable** graphicsSurface)
        {
            // SpanOverloader
            return thisApi.CreateDirect3D11SurfaceFromDXGISurface(ref dgxiSurface.GetPinnableReference(), graphicsSurface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public static unsafe int CreateDirect3D11SurfaceFromDXGISurface(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGISurface> dgxiSurface, ref Silk.NET.Core.Native.IInspectable* graphicsSurface)
        {
            // SpanOverloader
            return thisApi.CreateDirect3D11SurfaceFromDXGISurface(ref dgxiSurface.GetPinnableReference(), ref graphicsSurface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Span<ID3D11ShaderTrace> pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly)
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(pSrcData, SrcDataSize, ref pTrace.GetPinnableReference(), StartStep, NumSteps, Flags, ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Span<ID3D11ShaderTrace> pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly)
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(pSrcData, SrcDataSize, ref pTrace.GetPinnableReference(), StartStep, NumSteps, Flags, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace<T0>(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(in pSrcData.GetPinnableReference(), SrcDataSize, pTrace, StartStep, NumSteps, Flags, ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace<T0>(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(in pSrcData.GetPinnableReference(), SrcDataSize, pTrace, StartStep, NumSteps, Flags, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace<T0>(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSize, Span<ID3D11ShaderTrace> pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(in pSrcData.GetPinnableReference(), SrcDataSize, ref pTrace.GetPinnableReference(), StartStep, NumSteps, Flags, ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public static unsafe int D3DDisassemble11Trace<T0>(this D3D11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSize, Span<ID3D11ShaderTrace> pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.D3DDisassemble11Trace(in pSrcData.GetPinnableReference(), SrcDataSize, ref pTrace.GetPinnableReference(), StartStep, NumSteps, Flags, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public static unsafe int CreateDevice(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(pAdapter, DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ID3D11DeviceContext** ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public static unsafe int CreateDeviceAndSwapChain(this D3D11 thisApi, Span<Silk.NET.DXGI.IDXGIAdapter> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.SwapChainDesc> pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Span<Silk.NET.Core.Native.D3DFeatureLevel> pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext)
        {
            // SpanOverloader
            return thisApi.CreateDeviceAndSwapChain(ref pAdapter.GetPinnableReference(), DriverType, Software, Flags, in pFeatureLevels.GetPinnableReference(), FeatureLevels, SDKVersion, in pSwapChainDesc.GetPinnableReference(), ref ppSwapChain, ref ppDevice, ref pFeatureLevel.GetPinnableReference(), ref ppImmediateContext);
        }

    }
}

