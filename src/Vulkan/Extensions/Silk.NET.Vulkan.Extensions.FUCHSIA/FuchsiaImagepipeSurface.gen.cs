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

namespace Silk.NET.Vulkan.Extensions.FUCHSIA
{
    [Extension("VK_FUCHSIA_imagepipe_surface")]
    public abstract unsafe partial class FuchsiaImagepipeSurface : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateImagePipeSurfaceFUCHSIA")]
        public abstract unsafe Result CreateImagePipeSurfaceFuchsia([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateImagePipeSurfaceFUCHSIA")]
        public abstract Result CreateImagePipeSurfaceFuchsia([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref ImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        public FuchsiaImagepipeSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

