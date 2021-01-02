// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public unsafe partial class D3D11 : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace(void* pSrcData, uint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace(void* pSrcData, uint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace(void* pSrcData, uint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace(void* pSrcData, uint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace<T0>(ref T0 pSrcData, uint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace<T0>(ref T0 pSrcData, uint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace<T0>(ref T0 pSrcData, uint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace")]
        public unsafe partial int D3DDisassemble11Trace<T0>(ref T0 pSrcData, uint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14447, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 14521, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain")]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);


        public D3D11(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

