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
    [Extension("VK_EXT_discard_rectangles")]
    public abstract unsafe partial class ExtDiscardRectangles : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_discard_rectangles";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        public abstract unsafe void CmdSetDiscardRectangle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Count = 0)] uint discardRectangleCount, [Count(Computed = "discardRectangleCount"), Flow(FlowDirection.In)] Rect2D* pDiscardRectangles);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        public abstract void CmdSetDiscardRectangle([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstDiscardRectangle, [Count(Count = 0)] uint discardRectangleCount, [Count(Computed = "discardRectangleCount"), Flow(FlowDirection.In)] ref Rect2D pDiscardRectangles);

        public ExtDiscardRectangles(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

