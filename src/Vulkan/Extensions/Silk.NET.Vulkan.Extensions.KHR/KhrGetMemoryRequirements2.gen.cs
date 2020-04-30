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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_get_memory_requirements2")]
    public abstract unsafe partial class KhrGetMemoryRequirements2 : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
        public abstract unsafe void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
        public abstract void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR")]
        public abstract unsafe void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR")]
        public abstract void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
        public abstract unsafe void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
        public abstract void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Computed = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        public KhrGetMemoryRequirements2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

