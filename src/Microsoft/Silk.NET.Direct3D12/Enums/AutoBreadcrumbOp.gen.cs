// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP")]
    public enum AutoBreadcrumbOp : int
    {
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETMARKER")]
        AutoBreadcrumbOpSetmarker = 0x0,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT")]
        AutoBreadcrumbOpBeginevent = 0x1,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDEVENT")]
        AutoBreadcrumbOpEndevent = 0x2,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED")]
        AutoBreadcrumbOpDrawinstanced = 0x3,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED")]
        AutoBreadcrumbOpDrawindexedinstanced = 0x4,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT")]
        AutoBreadcrumbOpExecuteindirect = 0x5,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCH")]
        AutoBreadcrumbOpDispatch = 0x6,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION")]
        AutoBreadcrumbOpCopybufferregion = 0x7,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION")]
        AutoBreadcrumbOpCopytextureregion = 0x8,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE")]
        AutoBreadcrumbOpCopyresource = 0x9,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTILES")]
        AutoBreadcrumbOpCopytiles = 0xA,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE")]
        AutoBreadcrumbOpResolvesubresource = 0xB,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW")]
        AutoBreadcrumbOpClearrendertargetview = 0xC,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW")]
        AutoBreadcrumbOpClearunorderedaccessview = 0xD,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW")]
        AutoBreadcrumbOpCleardepthstencilview = 0xE,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER")]
        AutoBreadcrumbOpResourcebarrier = 0xF,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE")]
        AutoBreadcrumbOpExecutebundle = 0x10,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PRESENT")]
        AutoBreadcrumbOpPresent = 0x11,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA")]
        AutoBreadcrumbOpResolvequerydata = 0x12,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION")]
        AutoBreadcrumbOpBeginsubmission = 0x13,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION")]
        AutoBreadcrumbOpEndsubmission = 0x14,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME")]
        AutoBreadcrumbOpDecodeframe = 0x15,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES")]
        AutoBreadcrumbOpProcessframes = 0x16,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT")]
        AutoBreadcrumbOpAtomiccopybufferuint = 0x17,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64")]
        AutoBreadcrumbOpAtomiccopybufferuint64 = 0x18,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION")]
        AutoBreadcrumbOpResolvesubresourceregion = 0x19,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE")]
        AutoBreadcrumbOpWritebufferimmediate = 0x1A,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1")]
        AutoBreadcrumbOpDecodeframe1 = 0x1B,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION")]
        AutoBreadcrumbOpSetprotectedresourcesession = 0x1C,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2")]
        AutoBreadcrumbOpDecodeframe2 = 0x1D,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1")]
        AutoBreadcrumbOpProcessframes1 = 0x1E,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE")]
        AutoBreadcrumbOpBuildraytracingaccelerationstructure = 0x1F,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO")]
        AutoBreadcrumbOpEmitraytracingaccelerationstructurepostbuildinfo = 0x20,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE")]
        AutoBreadcrumbOpCopyraytracingaccelerationstructure = 0x21,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS")]
        AutoBreadcrumbOpDispatchrays = 0x22,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND")]
        AutoBreadcrumbOpInitializemetacommand = 0x23,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND")]
        AutoBreadcrumbOpExecutemetacommand = 0x24,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION")]
        AutoBreadcrumbOpEstimatemotion = 0x25,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP")]
        AutoBreadcrumbOpResolvemotionvectorheap = 0x26,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1")]
        AutoBreadcrumbOpSetpipelinestate1 = 0x27,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND")]
        AutoBreadcrumbOpInitializeextensioncommand = 0x28,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND")]
        AutoBreadcrumbOpExecuteextensioncommand = 0x29,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH")]
        AutoBreadcrumbOpDispatchmesh = 0x2A,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME")]
        AutoBreadcrumbOpEncodeframe = 0x2B,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA")]
        AutoBreadcrumbOpResolveencoderoutputmetadata = 0x2C,
    }
}
