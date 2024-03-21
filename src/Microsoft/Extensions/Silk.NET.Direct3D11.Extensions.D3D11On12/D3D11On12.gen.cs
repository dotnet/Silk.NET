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
using Silk.NET.Direct3D11;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11.Extensions.D3D11On12
{
    [Extension("d3d11on12.h")]
    public unsafe partial class D3D11On12 : NativeExtension<D3D11>
    {
        public const string ExtensionName = "d3d11on12.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ID3D11Device** ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ID3D11DeviceContext** ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        [NativeApi(EntryPoint = "D3D11On12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int On12CreateDevice(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ComPtr<TI3> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ComPtr<TI3> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ComPtr<TI3> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2, TI3>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ComPtr<TI3> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI2> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ComPtr<TI0> pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI0> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI0> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1, TI2>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ComPtr<TI2> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI1> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, (Silk.NET.Core.Native.IUnknown**) ppCommandQueues.GetAddressOf(), NumQueues, NodeMask, ref ppDevice, ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ComPtr<TI1> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0, TI1>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ComPtr<TI1> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ComPtr<TI0> ppDevice, ref ID3D11DeviceContext* ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, (ID3D11Device**) ppDevice.GetAddressOf(), ref ppImmediateContext, ref pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI0> ppImmediateContext, Silk.NET.Core.Native.D3DFeatureLevel* pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), pChosenFeatureLevel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 16 in d3d11on12.h")]
        public unsafe int On12CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown* ppCommandQueues, uint NumQueues, uint NodeMask, ref ID3D11Device* ppDevice, ref ComPtr<TI0> ppImmediateContext, ref Silk.NET.Core.Native.D3DFeatureLevel pChosenFeatureLevel) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return On12CreateDevice(ref pDevice, Flags, in pFeatureLevels, FeatureLevels, in ppCommandQueues, NumQueues, NodeMask, ref ppDevice, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf(), ref pChosenFeatureLevel);
        }

        public D3D11On12(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

