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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_metal_objects")]
    public unsafe partial class ExtMetalObjects : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_metal_objects";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkExportMetalObjectsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExportMetalObjects([Count(Count = 0)] Device device, [Count(Count = 0)] ExportMetalObjectsInfoEXT* pMetalObjectsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkExportMetalObjectsEXT", Convention = CallingConvention.Winapi)]
        public partial void ExportMetalObjects([Count(Count = 0)] Device device, [Count(Count = 0)] ref ExportMetalObjectsInfoEXT pMetalObjectsInfo);

        public ExtMetalObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

