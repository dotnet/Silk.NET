// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvStorageClass_")]
    public enum StorageClass : int
    {
        [NativeName("Name", "SpvStorageClassUniformConstant")]
        UniformConstant = 0x0,
        [NativeName("Name", "SpvStorageClassInput")]
        Input = 0x1,
        [NativeName("Name", "SpvStorageClassUniform")]
        Uniform = 0x2,
        [NativeName("Name", "SpvStorageClassOutput")]
        Output = 0x3,
        [NativeName("Name", "SpvStorageClassWorkgroup")]
        Workgroup = 0x4,
        [NativeName("Name", "SpvStorageClassCrossWorkgroup")]
        CrossWorkgroup = 0x5,
        [NativeName("Name", "SpvStorageClassPrivate")]
        Private = 0x6,
        [NativeName("Name", "SpvStorageClassFunction")]
        Function = 0x7,
        [NativeName("Name", "SpvStorageClassGeneric")]
        Generic = 0x8,
        [NativeName("Name", "SpvStorageClassPushConstant")]
        PushConstant = 0x9,
        [NativeName("Name", "SpvStorageClassAtomicCounter")]
        AtomicCounter = 0xA,
        [NativeName("Name", "SpvStorageClassImage")]
        Image = 0xB,
        [NativeName("Name", "SpvStorageClassStorageBuffer")]
        StorageBuffer = 0xC,
        [NativeName("Name", "SpvStorageClassTileImageEXT")]
        TileImageExt = 0x104C,
        [NativeName("Name", "SpvStorageClassNodePayloadAMDX")]
        NodePayloadAmdx = 0x13CC,
        [NativeName("Name", "SpvStorageClassNodeOutputPayloadAMDX")]
        NodeOutputPayloadAmdx = 0x13D4,
        [NativeName("Name", "SpvStorageClassCallableDataKHR")]
        CallableDataKhr = 0x14D0,
        [NativeName("Name", "SpvStorageClassCallableDataNV")]
        CallableDataNV = 0x14D0,
        [NativeName("Name", "SpvStorageClassIncomingCallableDataKHR")]
        IncomingCallableDataKhr = 0x14D1,
        [NativeName("Name", "SpvStorageClassIncomingCallableDataNV")]
        IncomingCallableDataNV = 0x14D1,
        [NativeName("Name", "SpvStorageClassRayPayloadKHR")]
        RayPayloadKhr = 0x14DA,
        [NativeName("Name", "SpvStorageClassRayPayloadNV")]
        RayPayloadNV = 0x14DA,
        [NativeName("Name", "SpvStorageClassHitAttributeKHR")]
        HitAttributeKhr = 0x14DB,
        [NativeName("Name", "SpvStorageClassHitAttributeNV")]
        HitAttributeNV = 0x14DB,
        [NativeName("Name", "SpvStorageClassIncomingRayPayloadKHR")]
        IncomingRayPayloadKhr = 0x14DE,
        [NativeName("Name", "SpvStorageClassIncomingRayPayloadNV")]
        IncomingRayPayloadNV = 0x14DE,
        [NativeName("Name", "SpvStorageClassShaderRecordBufferKHR")]
        ShaderRecordBufferKhr = 0x14DF,
        [NativeName("Name", "SpvStorageClassShaderRecordBufferNV")]
        ShaderRecordBufferNV = 0x14DF,
        [NativeName("Name", "SpvStorageClassPhysicalStorageBuffer")]
        PhysicalStorageBuffer = 0x14E5,
        [NativeName("Name", "SpvStorageClassPhysicalStorageBufferEXT")]
        PhysicalStorageBufferExt = 0x14E5,
        [NativeName("Name", "SpvStorageClassHitObjectAttributeNV")]
        HitObjectAttributeNV = 0x1509,
        [NativeName("Name", "SpvStorageClassTaskPayloadWorkgroupEXT")]
        TaskPayloadWorkgroupExt = 0x151A,
        [NativeName("Name", "SpvStorageClassCodeSectionINTEL")]
        CodeSectionIntel = 0x15E5,
        [NativeName("Name", "SpvStorageClassDeviceOnlyINTEL")]
        DeviceOnlyIntel = 0x1730,
        [NativeName("Name", "SpvStorageClassHostOnlyINTEL")]
        HostOnlyIntel = 0x1731,
        [NativeName("Name", "SpvStorageClassMax")]
        Max = 0x7FFFFFFF,
    }
}
