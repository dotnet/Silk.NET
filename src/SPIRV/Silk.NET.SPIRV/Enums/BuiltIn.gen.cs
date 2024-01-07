// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvBuiltIn_")]
    public enum BuiltIn : int
    {
        [NativeName("Name", "SpvBuiltInPosition")]
        Position = 0x0,
        [NativeName("Name", "SpvBuiltInPointSize")]
        PointSize = 0x1,
        [NativeName("Name", "SpvBuiltInClipDistance")]
        ClipDistance = 0x3,
        [NativeName("Name", "SpvBuiltInCullDistance")]
        CullDistance = 0x4,
        [NativeName("Name", "SpvBuiltInVertexId")]
        VertexId = 0x5,
        [NativeName("Name", "SpvBuiltInInstanceId")]
        InstanceId = 0x6,
        [NativeName("Name", "SpvBuiltInPrimitiveId")]
        PrimitiveId = 0x7,
        [NativeName("Name", "SpvBuiltInInvocationId")]
        InvocationId = 0x8,
        [NativeName("Name", "SpvBuiltInLayer")]
        Layer = 0x9,
        [NativeName("Name", "SpvBuiltInViewportIndex")]
        ViewportIndex = 0xA,
        [NativeName("Name", "SpvBuiltInTessLevelOuter")]
        TessLevelOuter = 0xB,
        [NativeName("Name", "SpvBuiltInTessLevelInner")]
        TessLevelInner = 0xC,
        [NativeName("Name", "SpvBuiltInTessCoord")]
        TessCoord = 0xD,
        [NativeName("Name", "SpvBuiltInPatchVertices")]
        PatchVertices = 0xE,
        [NativeName("Name", "SpvBuiltInFragCoord")]
        FragCoord = 0xF,
        [NativeName("Name", "SpvBuiltInPointCoord")]
        PointCoord = 0x10,
        [NativeName("Name", "SpvBuiltInFrontFacing")]
        FrontFacing = 0x11,
        [NativeName("Name", "SpvBuiltInSampleId")]
        SampleId = 0x12,
        [NativeName("Name", "SpvBuiltInSamplePosition")]
        SamplePosition = 0x13,
        [NativeName("Name", "SpvBuiltInSampleMask")]
        SampleMask = 0x14,
        [NativeName("Name", "SpvBuiltInFragDepth")]
        FragDepth = 0x16,
        [NativeName("Name", "SpvBuiltInHelperInvocation")]
        HelperInvocation = 0x17,
        [NativeName("Name", "SpvBuiltInNumWorkgroups")]
        NumWorkgroups = 0x18,
        [NativeName("Name", "SpvBuiltInWorkgroupSize")]
        WorkgroupSize = 0x19,
        [NativeName("Name", "SpvBuiltInWorkgroupId")]
        WorkgroupId = 0x1A,
        [NativeName("Name", "SpvBuiltInLocalInvocationId")]
        LocalInvocationId = 0x1B,
        [NativeName("Name", "SpvBuiltInGlobalInvocationId")]
        GlobalInvocationId = 0x1C,
        [NativeName("Name", "SpvBuiltInLocalInvocationIndex")]
        LocalInvocationIndex = 0x1D,
        [NativeName("Name", "SpvBuiltInWorkDim")]
        WorkDim = 0x1E,
        [NativeName("Name", "SpvBuiltInGlobalSize")]
        GlobalSize = 0x1F,
        [NativeName("Name", "SpvBuiltInEnqueuedWorkgroupSize")]
        EnqueuedWorkgroupSize = 0x20,
        [NativeName("Name", "SpvBuiltInGlobalOffset")]
        GlobalOffset = 0x21,
        [NativeName("Name", "SpvBuiltInGlobalLinearId")]
        GlobalLinearId = 0x22,
        [NativeName("Name", "SpvBuiltInSubgroupSize")]
        SubgroupSize = 0x24,
        [NativeName("Name", "SpvBuiltInSubgroupMaxSize")]
        SubgroupMaxSize = 0x25,
        [NativeName("Name", "SpvBuiltInNumSubgroups")]
        NumSubgroups = 0x26,
        [NativeName("Name", "SpvBuiltInNumEnqueuedSubgroups")]
        NumEnqueuedSubgroups = 0x27,
        [NativeName("Name", "SpvBuiltInSubgroupId")]
        SubgroupId = 0x28,
        [NativeName("Name", "SpvBuiltInSubgroupLocalInvocationId")]
        SubgroupLocalInvocationId = 0x29,
        [NativeName("Name", "SpvBuiltInVertexIndex")]
        VertexIndex = 0x2A,
        [NativeName("Name", "SpvBuiltInInstanceIndex")]
        InstanceIndex = 0x2B,
        [NativeName("Name", "SpvBuiltInCoreIDARM")]
        CoreIdarm = 0x1040,
        [NativeName("Name", "SpvBuiltInCoreCountARM")]
        CoreCountArm = 0x1041,
        [NativeName("Name", "SpvBuiltInCoreMaxIDARM")]
        CoreMaxIdarm = 0x1042,
        [NativeName("Name", "SpvBuiltInWarpIDARM")]
        WarpIdarm = 0x1043,
        [NativeName("Name", "SpvBuiltInWarpMaxIDARM")]
        WarpMaxIdarm = 0x1044,
        [NativeName("Name", "SpvBuiltInSubgroupEqMask")]
        SubgroupEqMask = 0x1140,
        [NativeName("Name", "SpvBuiltInSubgroupEqMaskKHR")]
        SubgroupEqMaskKhr = 0x1140,
        [NativeName("Name", "SpvBuiltInSubgroupGeMask")]
        SubgroupGeMask = 0x1141,
        [NativeName("Name", "SpvBuiltInSubgroupGeMaskKHR")]
        SubgroupGeMaskKhr = 0x1141,
        [NativeName("Name", "SpvBuiltInSubgroupGtMask")]
        SubgroupGtMask = 0x1142,
        [NativeName("Name", "SpvBuiltInSubgroupGtMaskKHR")]
        SubgroupGtMaskKhr = 0x1142,
        [NativeName("Name", "SpvBuiltInSubgroupLeMask")]
        SubgroupLeMask = 0x1143,
        [NativeName("Name", "SpvBuiltInSubgroupLeMaskKHR")]
        SubgroupLeMaskKhr = 0x1143,
        [NativeName("Name", "SpvBuiltInSubgroupLtMask")]
        SubgroupLtMask = 0x1144,
        [NativeName("Name", "SpvBuiltInSubgroupLtMaskKHR")]
        SubgroupLtMaskKhr = 0x1144,
        [NativeName("Name", "SpvBuiltInBaseVertex")]
        BaseVertex = 0x1148,
        [NativeName("Name", "SpvBuiltInBaseInstance")]
        BaseInstance = 0x1149,
        [NativeName("Name", "SpvBuiltInDrawIndex")]
        DrawIndex = 0x114A,
        [NativeName("Name", "SpvBuiltInPrimitiveShadingRateKHR")]
        PrimitiveShadingRateKhr = 0x1150,
        [NativeName("Name", "SpvBuiltInDeviceIndex")]
        DeviceIndex = 0x1156,
        [NativeName("Name", "SpvBuiltInViewIndex")]
        ViewIndex = 0x1158,
        [NativeName("Name", "SpvBuiltInShadingRateKHR")]
        ShadingRateKhr = 0x115C,
        [NativeName("Name", "SpvBuiltInBaryCoordNoPerspAMD")]
        BaryCoordNoPerspAmd = 0x1380,
        [NativeName("Name", "SpvBuiltInBaryCoordNoPerspCentroidAMD")]
        BaryCoordNoPerspCentroidAmd = 0x1381,
        [NativeName("Name", "SpvBuiltInBaryCoordNoPerspSampleAMD")]
        BaryCoordNoPerspSampleAmd = 0x1382,
        [NativeName("Name", "SpvBuiltInBaryCoordSmoothAMD")]
        BaryCoordSmoothAmd = 0x1383,
        [NativeName("Name", "SpvBuiltInBaryCoordSmoothCentroidAMD")]
        BaryCoordSmoothCentroidAmd = 0x1384,
        [NativeName("Name", "SpvBuiltInBaryCoordSmoothSampleAMD")]
        BaryCoordSmoothSampleAmd = 0x1385,
        [NativeName("Name", "SpvBuiltInBaryCoordPullModelAMD")]
        BaryCoordPullModelAmd = 0x1386,
        [NativeName("Name", "SpvBuiltInFragStencilRefEXT")]
        FragStencilRefExt = 0x1396,
        [NativeName("Name", "SpvBuiltInCoalescedInputCountAMDX")]
        CoalescedInputCountAmdx = 0x139D,
        [NativeName("Name", "SpvBuiltInShaderIndexAMDX")]
        ShaderIndexAmdx = 0x13D1,
        [NativeName("Name", "SpvBuiltInViewportMaskNV")]
        ViewportMaskNV = 0x1485,
        [NativeName("Name", "SpvBuiltInSecondaryPositionNV")]
        SecondaryPositionNV = 0x1489,
        [NativeName("Name", "SpvBuiltInSecondaryViewportMaskNV")]
        SecondaryViewportMaskNV = 0x148A,
        [NativeName("Name", "SpvBuiltInPositionPerViewNV")]
        PositionPerViewNV = 0x148D,
        [NativeName("Name", "SpvBuiltInViewportMaskPerViewNV")]
        ViewportMaskPerViewNV = 0x148E,
        [NativeName("Name", "SpvBuiltInFullyCoveredEXT")]
        FullyCoveredExt = 0x1490,
        [NativeName("Name", "SpvBuiltInTaskCountNV")]
        TaskCountNV = 0x149A,
        [NativeName("Name", "SpvBuiltInPrimitiveCountNV")]
        PrimitiveCountNV = 0x149B,
        [NativeName("Name", "SpvBuiltInPrimitiveIndicesNV")]
        PrimitiveIndicesNV = 0x149C,
        [NativeName("Name", "SpvBuiltInClipDistancePerViewNV")]
        ClipDistancePerViewNV = 0x149D,
        [NativeName("Name", "SpvBuiltInCullDistancePerViewNV")]
        CullDistancePerViewNV = 0x149E,
        [NativeName("Name", "SpvBuiltInLayerPerViewNV")]
        LayerPerViewNV = 0x149F,
        [NativeName("Name", "SpvBuiltInMeshViewCountNV")]
        MeshViewCountNV = 0x14A0,
        [NativeName("Name", "SpvBuiltInMeshViewIndicesNV")]
        MeshViewIndicesNV = 0x14A1,
        [NativeName("Name", "SpvBuiltInBaryCoordKHR")]
        BaryCoordKhr = 0x14A6,
        [NativeName("Name", "SpvBuiltInBaryCoordNV")]
        BaryCoordNV = 0x14A6,
        [NativeName("Name", "SpvBuiltInBaryCoordNoPerspKHR")]
        BaryCoordNoPerspKhr = 0x14A7,
        [NativeName("Name", "SpvBuiltInBaryCoordNoPerspNV")]
        BaryCoordNoPerspNV = 0x14A7,
        [NativeName("Name", "SpvBuiltInFragSizeEXT")]
        FragSizeExt = 0x14AC,
        [NativeName("Name", "SpvBuiltInFragmentSizeNV")]
        FragmentSizeNV = 0x14AC,
        [NativeName("Name", "SpvBuiltInFragInvocationCountEXT")]
        FragInvocationCountExt = 0x14AD,
        [NativeName("Name", "SpvBuiltInInvocationsPerPixelNV")]
        InvocationsPerPixelNV = 0x14AD,
        [NativeName("Name", "SpvBuiltInPrimitivePointIndicesEXT")]
        PrimitivePointIndicesExt = 0x14AE,
        [NativeName("Name", "SpvBuiltInPrimitiveLineIndicesEXT")]
        PrimitiveLineIndicesExt = 0x14AF,
        [NativeName("Name", "SpvBuiltInPrimitiveTriangleIndicesEXT")]
        PrimitiveTriangleIndicesExt = 0x14B0,
        [NativeName("Name", "SpvBuiltInCullPrimitiveEXT")]
        CullPrimitiveExt = 0x14B3,
        [NativeName("Name", "SpvBuiltInLaunchIdKHR")]
        LaunchIdKhr = 0x14C7,
        [NativeName("Name", "SpvBuiltInLaunchIdNV")]
        LaunchIdNV = 0x14C7,
        [NativeName("Name", "SpvBuiltInLaunchSizeKHR")]
        LaunchSizeKhr = 0x14C8,
        [NativeName("Name", "SpvBuiltInLaunchSizeNV")]
        LaunchSizeNV = 0x14C8,
        [NativeName("Name", "SpvBuiltInWorldRayOriginKHR")]
        WorldRayOriginKhr = 0x14C9,
        [NativeName("Name", "SpvBuiltInWorldRayOriginNV")]
        WorldRayOriginNV = 0x14C9,
        [NativeName("Name", "SpvBuiltInWorldRayDirectionKHR")]
        WorldRayDirectionKhr = 0x14CA,
        [NativeName("Name", "SpvBuiltInWorldRayDirectionNV")]
        WorldRayDirectionNV = 0x14CA,
        [NativeName("Name", "SpvBuiltInObjectRayOriginKHR")]
        ObjectRayOriginKhr = 0x14CB,
        [NativeName("Name", "SpvBuiltInObjectRayOriginNV")]
        ObjectRayOriginNV = 0x14CB,
        [NativeName("Name", "SpvBuiltInObjectRayDirectionKHR")]
        ObjectRayDirectionKhr = 0x14CC,
        [NativeName("Name", "SpvBuiltInObjectRayDirectionNV")]
        ObjectRayDirectionNV = 0x14CC,
        [NativeName("Name", "SpvBuiltInRayTminKHR")]
        RayTminKhr = 0x14CD,
        [NativeName("Name", "SpvBuiltInRayTminNV")]
        RayTminNV = 0x14CD,
        [NativeName("Name", "SpvBuiltInRayTmaxKHR")]
        RayTmaxKhr = 0x14CE,
        [NativeName("Name", "SpvBuiltInRayTmaxNV")]
        RayTmaxNV = 0x14CE,
        [NativeName("Name", "SpvBuiltInInstanceCustomIndexKHR")]
        InstanceCustomIndexKhr = 0x14CF,
        [NativeName("Name", "SpvBuiltInInstanceCustomIndexNV")]
        InstanceCustomIndexNV = 0x14CF,
        [NativeName("Name", "SpvBuiltInObjectToWorldKHR")]
        ObjectToWorldKhr = 0x14D2,
        [NativeName("Name", "SpvBuiltInObjectToWorldNV")]
        ObjectToWorldNV = 0x14D2,
        [NativeName("Name", "SpvBuiltInWorldToObjectKHR")]
        WorldToObjectKhr = 0x14D3,
        [NativeName("Name", "SpvBuiltInWorldToObjectNV")]
        WorldToObjectNV = 0x14D3,
        [NativeName("Name", "SpvBuiltInHitTNV")]
        HitTnv = 0x14D4,
        [NativeName("Name", "SpvBuiltInHitKindKHR")]
        HitKindKhr = 0x14D5,
        [NativeName("Name", "SpvBuiltInHitKindNV")]
        HitKindNV = 0x14D5,
        [NativeName("Name", "SpvBuiltInCurrentRayTimeNV")]
        CurrentRayTimeNV = 0x14D6,
        [NativeName("Name", "SpvBuiltInHitTriangleVertexPositionsKHR")]
        HitTriangleVertexPositionsKhr = 0x14D7,
        [NativeName("Name", "SpvBuiltInHitMicroTriangleVertexPositionsNV")]
        HitMicroTriangleVertexPositionsNV = 0x14D9,
        [NativeName("Name", "SpvBuiltInHitMicroTriangleVertexBarycentricsNV")]
        HitMicroTriangleVertexBarycentricsNV = 0x14E0,
        [NativeName("Name", "SpvBuiltInIncomingRayFlagsKHR")]
        IncomingRayFlagsKhr = 0x14E7,
        [NativeName("Name", "SpvBuiltInIncomingRayFlagsNV")]
        IncomingRayFlagsNV = 0x14E7,
        [NativeName("Name", "SpvBuiltInRayGeometryIndexKHR")]
        RayGeometryIndexKhr = 0x14E8,
        [NativeName("Name", "SpvBuiltInWarpsPerSMNV")]
        WarpsPerSmnv = 0x14FE,
        [NativeName("Name", "SpvBuiltInSMCountNV")]
        SMCountNV = 0x14FF,
        [NativeName("Name", "SpvBuiltInWarpIDNV")]
        WarpIdnv = 0x1500,
        [NativeName("Name", "SpvBuiltInSMIDNV")]
        Smidnv = 0x1501,
        [NativeName("Name", "SpvBuiltInHitKindFrontFacingMicroTriangleNV")]
        HitKindFrontFacingMicroTriangleNV = 0x151D,
        [NativeName("Name", "SpvBuiltInHitKindBackFacingMicroTriangleNV")]
        HitKindBackFacingMicroTriangleNV = 0x151E,
        [NativeName("Name", "SpvBuiltInCullMaskKHR")]
        CullMaskKhr = 0x1785,
        [NativeName("Name", "SpvBuiltInMax")]
        Max = 0x7FFFFFFF,
    }
}
