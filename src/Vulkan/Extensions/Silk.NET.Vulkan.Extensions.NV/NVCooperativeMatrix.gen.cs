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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_cooperative_matrix")]
    public abstract unsafe partial class NVCooperativeMatrix : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public abstract unsafe Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] CooperativeMatrixPropertiesNV* pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public abstract Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out CooperativeMatrixPropertiesNV pProperties);

        public NVCooperativeMatrix(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

