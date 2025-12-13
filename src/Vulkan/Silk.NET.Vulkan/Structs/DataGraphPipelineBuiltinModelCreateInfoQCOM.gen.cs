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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDataGraphPipelineBuiltinModelCreateInfoQCOM")]
    public unsafe partial struct DataGraphPipelineBuiltinModelCreateInfoQCOM : IExtendsChain<DataGraphPipelineCreateInfoARM>
    {
        public DataGraphPipelineBuiltinModelCreateInfoQCOM
        (
            StructureType? sType = StructureType.DataGraphPipelineBuiltinModelCreateInfoQCom,
            void* pNext = null,
            PhysicalDeviceDataGraphOperationSupportARM* pOperation = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (pOperation is not null)
            {
                POperation = pOperation;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceDataGraphOperationSupportARM*")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphOperationSupportARM")]
        [NativeName("Name", "pOperation")]
        public PhysicalDeviceDataGraphOperationSupportARM* POperation;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineBuiltinModelCreateInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
