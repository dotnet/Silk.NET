// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_D3D12_enable")]
    public abstract unsafe partial class KhrD3D12Enable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_D3D12_enable";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetD3D12GraphicsRequirementsKHR")]
        public abstract unsafe Result GetD3D12GraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsD3D12KHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetD3D12GraphicsRequirementsKHR")]
        public abstract Result GetD3D12GraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsD3D12KHR graphicsRequirements);

        public KhrD3D12Enable(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

