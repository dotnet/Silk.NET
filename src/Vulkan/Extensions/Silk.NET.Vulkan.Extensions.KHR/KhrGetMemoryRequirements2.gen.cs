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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_get_memory_requirements2")]
    public unsafe partial class KhrGetMemoryRequirements2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_memory_requirements2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2KHR", Convention = CallingConvention.Winapi)]
        public partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetBufferMemoryRequirements2(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferMemoryRequirementsInfo2 pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetBufferMemoryRequirements2(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetImageMemoryRequirements2(device, pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public unsafe MemoryRequirements2 GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageMemoryRequirementsInfo2 pInfo)
        {
            // NonKhrReturnTypeOverloader
            GetImageMemoryRequirements2(device, in pInfo, out MemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public unsafe SparseImageMemoryRequirements2 GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount)
        {
            // NonKhrReturnTypeOverloader
            GetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, out SparseImageMemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public unsafe SparseImageMemoryRequirements2 GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount)
        {
            // NonKhrReturnTypeOverloader
            GetImageSparseMemoryRequirements2(device, pInfo, ref pSparseMemoryRequirementCount, out SparseImageMemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public unsafe SparseImageMemoryRequirements2 GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount)
        {
            // NonKhrReturnTypeOverloader
            GetImageSparseMemoryRequirements2(device, in pInfo, pSparseMemoryRequirementCount, out SparseImageMemoryRequirements2 silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public unsafe SparseImageMemoryRequirements2 GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount)
        {
            // NonKhrReturnTypeOverloader
            GetImageSparseMemoryRequirements2(device, in pInfo, ref pSparseMemoryRequirementCount, out SparseImageMemoryRequirements2 silkRet);
            return silkRet;
        }

        public KhrGetMemoryRequirements2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

