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

        public D3D11On12(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

