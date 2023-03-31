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
    [Extension("VK_EXT_image_drm_format_modifier")]
    public unsafe partial class ExtImageDrmFormatModifier : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_image_drm_format_modifier";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetImageDrmFormatModifierProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ImageDrmFormatModifierPropertiesEXT* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ImageDrmFormatModifierPropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetImageDrmFormatModifierProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ImageDrmFormatModifierPropertiesEXT pProperties);

        public ExtImageDrmFormatModifier(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

