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
        [Obsolete("Deprecated in favour of \"Setmarker\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETMARKER")]
        AutoBreadcrumbOpSetmarker = 0x0,
        [Obsolete("Deprecated in favour of \"Beginevent\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT")]
        AutoBreadcrumbOpBeginevent = 0x1,
        [Obsolete("Deprecated in favour of \"Endevent\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDEVENT")]
        AutoBreadcrumbOpEndevent = 0x2,
        [Obsolete("Deprecated in favour of \"Drawinstanced\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED")]
        AutoBreadcrumbOpDrawinstanced = 0x3,
        [Obsolete("Deprecated in favour of \"Drawindexedinstanced\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED")]
        AutoBreadcrumbOpDrawindexedinstanced = 0x4,
        [Obsolete("Deprecated in favour of \"Executeindirect\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT")]
        AutoBreadcrumbOpExecuteindirect = 0x5,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCH")]
        AutoBreadcrumbOpDispatch = 0x6,
        [Obsolete("Deprecated in favour of \"Copybufferregion\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION")]
        AutoBreadcrumbOpCopybufferregion = 0x7,
        [Obsolete("Deprecated in favour of \"Copytextureregion\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION")]
        AutoBreadcrumbOpCopytextureregion = 0x8,
        [Obsolete("Deprecated in favour of \"Copyresource\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE")]
        AutoBreadcrumbOpCopyresource = 0x9,
        [Obsolete("Deprecated in favour of \"Copytiles\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTILES")]
        AutoBreadcrumbOpCopytiles = 0xA,
        [Obsolete("Deprecated in favour of \"Resolvesubresource\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE")]
        AutoBreadcrumbOpResolvesubresource = 0xB,
        [Obsolete("Deprecated in favour of \"Clearrendertargetview\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW")]
        AutoBreadcrumbOpClearrendertargetview = 0xC,
        [Obsolete("Deprecated in favour of \"Clearunorderedaccessview\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW")]
        AutoBreadcrumbOpClearunorderedaccessview = 0xD,
        [Obsolete("Deprecated in favour of \"Cleardepthstencilview\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW")]
        AutoBreadcrumbOpCleardepthstencilview = 0xE,
        [Obsolete("Deprecated in favour of \"Resourcebarrier\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER")]
        AutoBreadcrumbOpResourcebarrier = 0xF,
        [Obsolete("Deprecated in favour of \"Executebundle\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE")]
        AutoBreadcrumbOpExecutebundle = 0x10,
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PRESENT")]
        AutoBreadcrumbOpPresent = 0x11,
        [Obsolete("Deprecated in favour of \"Resolvequerydata\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA")]
        AutoBreadcrumbOpResolvequerydata = 0x12,
        [Obsolete("Deprecated in favour of \"Beginsubmission\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION")]
        AutoBreadcrumbOpBeginsubmission = 0x13,
        [Obsolete("Deprecated in favour of \"Endsubmission\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION")]
        AutoBreadcrumbOpEndsubmission = 0x14,
        [Obsolete("Deprecated in favour of \"Decodeframe\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME")]
        AutoBreadcrumbOpDecodeframe = 0x15,
        [Obsolete("Deprecated in favour of \"Processframes\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES")]
        AutoBreadcrumbOpProcessframes = 0x16,
        [Obsolete("Deprecated in favour of \"Atomiccopybufferuint\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT")]
        AutoBreadcrumbOpAtomiccopybufferuint = 0x17,
        [Obsolete("Deprecated in favour of \"Atomiccopybufferuint64\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64")]
        AutoBreadcrumbOpAtomiccopybufferuint64 = 0x18,
        [Obsolete("Deprecated in favour of \"Resolvesubresourceregion\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION")]
        AutoBreadcrumbOpResolvesubresourceregion = 0x19,
        [Obsolete("Deprecated in favour of \"Writebufferimmediate\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE")]
        AutoBreadcrumbOpWritebufferimmediate = 0x1A,
        [Obsolete("Deprecated in favour of \"Decodeframe1\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1")]
        AutoBreadcrumbOpDecodeframe1 = 0x1B,
        [Obsolete("Deprecated in favour of \"Setprotectedresourcesession\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION")]
        AutoBreadcrumbOpSetprotectedresourcesession = 0x1C,
        [Obsolete("Deprecated in favour of \"Decodeframe2\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2")]
        AutoBreadcrumbOpDecodeframe2 = 0x1D,
        [Obsolete("Deprecated in favour of \"Processframes1\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1")]
        AutoBreadcrumbOpProcessframes1 = 0x1E,
        [Obsolete("Deprecated in favour of \"Buildraytracingaccelerationstructure\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE")]
        AutoBreadcrumbOpBuildraytracingaccelerationstructure = 0x1F,
        [Obsolete("Deprecated in favour of \"Emitraytracingaccelerationstructurepostbuildinfo\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO")]
        AutoBreadcrumbOpEmitraytracingaccelerationstructurepostbuildinfo = 0x20,
        [Obsolete("Deprecated in favour of \"Copyraytracingaccelerationstructure\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE")]
        AutoBreadcrumbOpCopyraytracingaccelerationstructure = 0x21,
        [Obsolete("Deprecated in favour of \"Dispatchrays\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS")]
        AutoBreadcrumbOpDispatchrays = 0x22,
        [Obsolete("Deprecated in favour of \"Initializemetacommand\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND")]
        AutoBreadcrumbOpInitializemetacommand = 0x23,
        [Obsolete("Deprecated in favour of \"Executemetacommand\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND")]
        AutoBreadcrumbOpExecutemetacommand = 0x24,
        [Obsolete("Deprecated in favour of \"Estimatemotion\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION")]
        AutoBreadcrumbOpEstimatemotion = 0x25,
        [Obsolete("Deprecated in favour of \"Resolvemotionvectorheap\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP")]
        AutoBreadcrumbOpResolvemotionvectorheap = 0x26,
        [Obsolete("Deprecated in favour of \"Setpipelinestate1\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1")]
        AutoBreadcrumbOpSetpipelinestate1 = 0x27,
        [Obsolete("Deprecated in favour of \"Initializeextensioncommand\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND")]
        AutoBreadcrumbOpInitializeextensioncommand = 0x28,
        [Obsolete("Deprecated in favour of \"Executeextensioncommand\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND")]
        AutoBreadcrumbOpExecuteextensioncommand = 0x29,
        [Obsolete("Deprecated in favour of \"Dispatchmesh\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH")]
        AutoBreadcrumbOpDispatchmesh = 0x2A,
        [Obsolete("Deprecated in favour of \"Encodeframe\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME")]
        AutoBreadcrumbOpEncodeframe = 0x2B,
        [Obsolete("Deprecated in favour of \"Resolveencoderoutputmetadata\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA")]
        AutoBreadcrumbOpResolveencoderoutputmetadata = 0x2C,
        [Obsolete("Deprecated in favour of \"Barrier\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BARRIER")]
        AutoBreadcrumbOpBarrier = 0x2D,
        [Obsolete("Deprecated in favour of \"BeginCommandList\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGIN_COMMAND_LIST")]
        AutoBreadcrumbOpBeginCommandList = 0x2E,
        [Obsolete("Deprecated in favour of \"Dispatchgraph\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHGRAPH")]
        AutoBreadcrumbOpDispatchgraph = 0x2F,
        [Obsolete("Deprecated in favour of \"Setprogram\"")]
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPROGRAM")]
        AutoBreadcrumbOpSetprogram = 0x30,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETMARKER")]
        Setmarker = 0x0,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT")]
        Beginevent = 0x1,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDEVENT")]
        Endevent = 0x2,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED")]
        Drawinstanced = 0x3,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED")]
        Drawindexedinstanced = 0x4,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT")]
        Executeindirect = 0x5,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCH")]
        Dispatch = 0x6,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION")]
        Copybufferregion = 0x7,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION")]
        Copytextureregion = 0x8,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE")]
        Copyresource = 0x9,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYTILES")]
        Copytiles = 0xA,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE")]
        Resolvesubresource = 0xB,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW")]
        Clearrendertargetview = 0xC,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW")]
        Clearunorderedaccessview = 0xD,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW")]
        Cleardepthstencilview = 0xE,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER")]
        Resourcebarrier = 0xF,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE")]
        Executebundle = 0x10,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PRESENT")]
        Present = 0x11,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA")]
        Resolvequerydata = 0x12,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION")]
        Beginsubmission = 0x13,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION")]
        Endsubmission = 0x14,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME")]
        Decodeframe = 0x15,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES")]
        Processframes = 0x16,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT")]
        Atomiccopybufferuint = 0x17,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64")]
        Atomiccopybufferuint64 = 0x18,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION")]
        Resolvesubresourceregion = 0x19,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE")]
        Writebufferimmediate = 0x1A,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1")]
        Decodeframe1 = 0x1B,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION")]
        Setprotectedresourcesession = 0x1C,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2")]
        Decodeframe2 = 0x1D,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1")]
        Processframes1 = 0x1E,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE")]
        Buildraytracingaccelerationstructure = 0x1F,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO")]
        Emitraytracingaccelerationstructurepostbuildinfo = 0x20,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE")]
        Copyraytracingaccelerationstructure = 0x21,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS")]
        Dispatchrays = 0x22,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND")]
        Initializemetacommand = 0x23,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND")]
        Executemetacommand = 0x24,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION")]
        Estimatemotion = 0x25,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP")]
        Resolvemotionvectorheap = 0x26,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1")]
        Setpipelinestate1 = 0x27,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND")]
        Initializeextensioncommand = 0x28,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND")]
        Executeextensioncommand = 0x29,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH")]
        Dispatchmesh = 0x2A,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME")]
        Encodeframe = 0x2B,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA")]
        Resolveencoderoutputmetadata = 0x2C,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BARRIER")]
        Barrier = 0x2D,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_BEGIN_COMMAND_LIST")]
        BeginCommandList = 0x2E,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_DISPATCHGRAPH")]
        Dispatchgraph = 0x2F,
        [NativeName("Name", "D3D12_AUTO_BREADCRUMB_OP_SETPROGRAM")]
        Setprogram = 0x30,
    }
}
