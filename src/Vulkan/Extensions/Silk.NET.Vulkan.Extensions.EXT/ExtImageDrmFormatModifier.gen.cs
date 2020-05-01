// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_image_drm_format_modifier")]
    public abstract unsafe partial class ExtImageDrmFormatModifier : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_image_drm_format_modifier";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
        public abstract unsafe Result GetImageDrmFormatModifierProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] ImageDrmFormatModifierPropertiesEXT* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
        public abstract Result GetImageDrmFormatModifierProperties([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageDrmFormatModifierPropertiesEXT pProperties);

        public ExtImageDrmFormatModifier(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

