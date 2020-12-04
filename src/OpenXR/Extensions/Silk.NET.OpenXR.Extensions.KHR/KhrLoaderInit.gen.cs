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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_loader_init")]
    public unsafe partial class KhrLoaderInit : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_loader_init";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrInitializeLoaderKHR")]
        public unsafe partial Result InitializeLoader([Count(Count = 0), Flow(FlowDirection.In)] LoaderInitInfoBaseHeaderKHR* loaderInitInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrInitializeLoaderKHR")]
        public partial Result InitializeLoader([Count(Count = 0), Flow(FlowDirection.In)] in LoaderInitInfoBaseHeaderKHR loaderInitInfo);

        public KhrLoaderInit(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

