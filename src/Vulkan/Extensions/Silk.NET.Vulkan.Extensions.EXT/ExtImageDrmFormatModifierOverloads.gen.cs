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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtImageDrmFormatModifierOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.ImageDrmFormatModifierPropertiesExt);")]
        public static unsafe Result GetImageDrmFormatModifierProperties(this ExtImageDrmFormatModifier thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ImageDrmFormatModifierPropertiesEXT> pProperties)
        {
            // SpanOverloader
            return thisApi.GetImageDrmFormatModifierProperties(device, image, out pProperties.GetPinnableReference());
        }

    }
}

