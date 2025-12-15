// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MARKER_API")]
    public enum MarkerApi : int
    {
        [Obsolete("Deprecated in favour of \"Setmarker\"")]
        [NativeName("Name", "D3D12_MARKER_API_SETMARKER")]
        MarkerApiSetmarker = 0x0,
        [Obsolete("Deprecated in favour of \"Beginevent\"")]
        [NativeName("Name", "D3D12_MARKER_API_BEGINEVENT")]
        MarkerApiBeginevent = 0x1,
        [Obsolete("Deprecated in favour of \"Endevent\"")]
        [NativeName("Name", "D3D12_MARKER_API_ENDEVENT")]
        MarkerApiEndevent = 0x2,
        [Obsolete("Deprecated in favour of \"Drawinstanced\"")]
        [NativeName("Name", "D3D12_MARKER_API_DRAWINSTANCED")]
        MarkerApiDrawinstanced = 0x3,
        [Obsolete("Deprecated in favour of \"Drawindexedinstanced\"")]
        [NativeName("Name", "D3D12_MARKER_API_DRAWINDEXEDINSTANCED")]
        MarkerApiDrawindexedinstanced = 0x4,
        [Obsolete("Deprecated in favour of \"Executeindirect\"")]
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEINDIRECT")]
        MarkerApiExecuteindirect = 0x5,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "D3D12_MARKER_API_DISPATCH")]
        MarkerApiDispatch = 0x6,
        [Obsolete("Deprecated in favour of \"Copybufferregion\"")]
        [NativeName("Name", "D3D12_MARKER_API_COPYBUFFERREGION")]
        MarkerApiCopybufferregion = 0x7,
        [Obsolete("Deprecated in favour of \"Copytextureregion\"")]
        [NativeName("Name", "D3D12_MARKER_API_COPYTEXTUREREGION")]
        MarkerApiCopytextureregion = 0x8,
        [Obsolete("Deprecated in favour of \"Copyresource\"")]
        [NativeName("Name", "D3D12_MARKER_API_COPYRESOURCE")]
        MarkerApiCopyresource = 0x9,
        [Obsolete("Deprecated in favour of \"Copytiles\"")]
        [NativeName("Name", "D3D12_MARKER_API_COPYTILES")]
        MarkerApiCopytiles = 0xA,
        [Obsolete("Deprecated in favour of \"Resolvesubresource\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVESUBRESOURCE")]
        MarkerApiResolvesubresource = 0xB,
        [Obsolete("Deprecated in favour of \"Clearrendertargetview\"")]
        [NativeName("Name", "D3D12_MARKER_API_CLEARRENDERTARGETVIEW")]
        MarkerApiClearrendertargetview = 0xC,
        [Obsolete("Deprecated in favour of \"Clearunorderedaccessview\"")]
        [NativeName("Name", "D3D12_MARKER_API_CLEARUNORDEREDACCESSVIEW")]
        MarkerApiClearunorderedaccessview = 0xD,
        [Obsolete("Deprecated in favour of \"Cleardepthstencilview\"")]
        [NativeName("Name", "D3D12_MARKER_API_CLEARDEPTHSTENCILVIEW")]
        MarkerApiCleardepthstencilview = 0xE,
        [Obsolete("Deprecated in favour of \"Resourcebarrier\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOURCEBARRIER")]
        MarkerApiResourcebarrier = 0xF,
        [Obsolete("Deprecated in favour of \"Executebundle\"")]
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEBUNDLE")]
        MarkerApiExecutebundle = 0x10,
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "D3D12_MARKER_API_PRESENT")]
        MarkerApiPresent = 0x11,
        [Obsolete("Deprecated in favour of \"Resolvequerydata\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEQUERYDATA")]
        MarkerApiResolvequerydata = 0x12,
        [Obsolete("Deprecated in favour of \"Beginsubmission\"")]
        [NativeName("Name", "D3D12_MARKER_API_BEGINSUBMISSION")]
        MarkerApiBeginsubmission = 0x13,
        [Obsolete("Deprecated in favour of \"Endsubmission\"")]
        [NativeName("Name", "D3D12_MARKER_API_ENDSUBMISSION")]
        MarkerApiEndsubmission = 0x14,
        [Obsolete("Deprecated in favour of \"Decodeframe\"")]
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME")]
        MarkerApiDecodeframe = 0x15,
        [Obsolete("Deprecated in favour of \"Processframes\"")]
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES")]
        MarkerApiProcessframes = 0x16,
        [Obsolete("Deprecated in favour of \"Atomiccopybufferuint\"")]
        [NativeName("Name", "D3D12_MARKER_API_ATOMICCOPYBUFFERUINT")]
        MarkerApiAtomiccopybufferuint = 0x17,
        [Obsolete("Deprecated in favour of \"Atomiccopybufferuint64\"")]
        [NativeName("Name", "D3D12_MARKER_API_ATOMICCOPYBUFFERUINT64")]
        MarkerApiAtomiccopybufferuint64 = 0x18,
        [Obsolete("Deprecated in favour of \"Resolvesubresourceregion\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVESUBRESOURCEREGION")]
        MarkerApiResolvesubresourceregion = 0x19,
        [Obsolete("Deprecated in favour of \"Writebufferimmediate\"")]
        [NativeName("Name", "D3D12_MARKER_API_WRITEBUFFERIMMEDIATE")]
        MarkerApiWritebufferimmediate = 0x1A,
        [Obsolete("Deprecated in favour of \"Decodeframe1\"")]
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME1")]
        MarkerApiDecodeframe1 = 0x1B,
        [Obsolete("Deprecated in favour of \"Setprotectedresourcesession\"")]
        [NativeName("Name", "D3D12_MARKER_API_SETPROTECTEDRESOURCESESSION")]
        MarkerApiSetprotectedresourcesession = 0x1C,
        [Obsolete("Deprecated in favour of \"Decodeframe2\"")]
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME2")]
        MarkerApiDecodeframe2 = 0x1D,
        [Obsolete("Deprecated in favour of \"Processframes1\"")]
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES1")]
        MarkerApiProcessframes1 = 0x1E,
        [Obsolete("Deprecated in favour of \"Buildraytracingaccelerationstructure\"")]
        [NativeName("Name", "D3D12_MARKER_API_BUILDRAYTRACINGACCELERATIONSTRUCTURE")]
        MarkerApiBuildraytracingaccelerationstructure = 0x1F,
        [Obsolete("Deprecated in favour of \"Emitraytracingaccelerationstructurepostbuildinfo\"")]
        [NativeName("Name", "D3D12_MARKER_API_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO")]
        MarkerApiEmitraytracingaccelerationstructurepostbuildinfo = 0x20,
        [Obsolete("Deprecated in favour of \"Copyraytracingaccelerationstructure\"")]
        [NativeName("Name", "D3D12_MARKER_API_COPYRAYTRACINGACCELERATIONSTRUCTURE")]
        MarkerApiCopyraytracingaccelerationstructure = 0x21,
        [Obsolete("Deprecated in favour of \"Dispatchrays\"")]
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHRAYS")]
        MarkerApiDispatchrays = 0x22,
        [Obsolete("Deprecated in favour of \"Initializemetacommand\"")]
        [NativeName("Name", "D3D12_MARKER_API_INITIALIZEMETACOMMAND")]
        MarkerApiInitializemetacommand = 0x23,
        [Obsolete("Deprecated in favour of \"Executemetacommand\"")]
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEMETACOMMAND")]
        MarkerApiExecutemetacommand = 0x24,
        [Obsolete("Deprecated in favour of \"Estimatemotion\"")]
        [NativeName("Name", "D3D12_MARKER_API_ESTIMATEMOTION")]
        MarkerApiEstimatemotion = 0x25,
        [Obsolete("Deprecated in favour of \"Resolvemotionvectorheap\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEMOTIONVECTORHEAP")]
        MarkerApiResolvemotionvectorheap = 0x26,
        [Obsolete("Deprecated in favour of \"Setpipelinestate1\"")]
        [NativeName("Name", "D3D12_MARKER_API_SETPIPELINESTATE1")]
        MarkerApiSetpipelinestate1 = 0x27,
        [Obsolete("Deprecated in favour of \"Initializeextensioncommand\"")]
        [NativeName("Name", "D3D12_MARKER_API_INITIALIZEEXTENSIONCOMMAND")]
        MarkerApiInitializeextensioncommand = 0x28,
        [Obsolete("Deprecated in favour of \"Executeextensioncommand\"")]
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEEXTENSIONCOMMAND")]
        MarkerApiExecuteextensioncommand = 0x29,
        [Obsolete("Deprecated in favour of \"Dispatchmesh\"")]
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHMESH")]
        MarkerApiDispatchmesh = 0x2A,
        [Obsolete("Deprecated in favour of \"Encodeframe\"")]
        [NativeName("Name", "D3D12_MARKER_API_ENCODEFRAME")]
        MarkerApiEncodeframe = 0x2B,
        [Obsolete("Deprecated in favour of \"Resolveencoderoutputmetadata\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEENCODEROUTPUTMETADATA")]
        MarkerApiResolveencoderoutputmetadata = 0x2C,
        [Obsolete("Deprecated in favour of \"Barrier\"")]
        [NativeName("Name", "D3D12_MARKER_API_BARRIER")]
        MarkerApiBarrier = 0x2D,
        [Obsolete("Deprecated in favour of \"BeginCommandList\"")]
        [NativeName("Name", "D3D12_MARKER_API_BEGIN_COMMAND_LIST")]
        MarkerApiBeginCommandList = 0x2E,
        [Obsolete("Deprecated in favour of \"Dispatchgraph\"")]
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHGRAPH")]
        MarkerApiDispatchgraph = 0x2F,
        [Obsolete("Deprecated in favour of \"Setprogram\"")]
        [NativeName("Name", "D3D12_MARKER_API_SETPROGRAM")]
        MarkerApiSetprogram = 0x30,
        [Obsolete("Deprecated in favour of \"Encodeframe1\"")]
        [NativeName("Name", "D3D12_MARKER_API_ENCODEFRAME1")]
        MarkerApiEncodeframe1 = 0x31,
        [Obsolete("Deprecated in favour of \"Resolveencoderoutputmetadata1\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEENCODEROUTPUTMETADATA1")]
        MarkerApiResolveencoderoutputmetadata1 = 0x32,
        [Obsolete("Deprecated in favour of \"Resolveinputparamlayout\"")]
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEINPUTPARAMLAYOUT")]
        MarkerApiResolveinputparamlayout = 0x33,
        [Obsolete("Deprecated in favour of \"Processframes2\"")]
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES2")]
        MarkerApiProcessframes2 = 0x34,
        [Obsolete("Deprecated in favour of \"SetWorkGraphMaximumGpuInputRecords\"")]
        [NativeName("Name", "D3D12_MARKER_API_SET_WORK_GRAPH_MAXIMUM_GPU_INPUT_RECORDS")]
        MarkerApiSetWorkGraphMaximumGpuInputRecords = 0x35,
        [NativeName("Name", "D3D12_MARKER_API_SETMARKER")]
        Setmarker = 0x0,
        [NativeName("Name", "D3D12_MARKER_API_BEGINEVENT")]
        Beginevent = 0x1,
        [NativeName("Name", "D3D12_MARKER_API_ENDEVENT")]
        Endevent = 0x2,
        [NativeName("Name", "D3D12_MARKER_API_DRAWINSTANCED")]
        Drawinstanced = 0x3,
        [NativeName("Name", "D3D12_MARKER_API_DRAWINDEXEDINSTANCED")]
        Drawindexedinstanced = 0x4,
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEINDIRECT")]
        Executeindirect = 0x5,
        [NativeName("Name", "D3D12_MARKER_API_DISPATCH")]
        Dispatch = 0x6,
        [NativeName("Name", "D3D12_MARKER_API_COPYBUFFERREGION")]
        Copybufferregion = 0x7,
        [NativeName("Name", "D3D12_MARKER_API_COPYTEXTUREREGION")]
        Copytextureregion = 0x8,
        [NativeName("Name", "D3D12_MARKER_API_COPYRESOURCE")]
        Copyresource = 0x9,
        [NativeName("Name", "D3D12_MARKER_API_COPYTILES")]
        Copytiles = 0xA,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVESUBRESOURCE")]
        Resolvesubresource = 0xB,
        [NativeName("Name", "D3D12_MARKER_API_CLEARRENDERTARGETVIEW")]
        Clearrendertargetview = 0xC,
        [NativeName("Name", "D3D12_MARKER_API_CLEARUNORDEREDACCESSVIEW")]
        Clearunorderedaccessview = 0xD,
        [NativeName("Name", "D3D12_MARKER_API_CLEARDEPTHSTENCILVIEW")]
        Cleardepthstencilview = 0xE,
        [NativeName("Name", "D3D12_MARKER_API_RESOURCEBARRIER")]
        Resourcebarrier = 0xF,
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEBUNDLE")]
        Executebundle = 0x10,
        [NativeName("Name", "D3D12_MARKER_API_PRESENT")]
        Present = 0x11,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEQUERYDATA")]
        Resolvequerydata = 0x12,
        [NativeName("Name", "D3D12_MARKER_API_BEGINSUBMISSION")]
        Beginsubmission = 0x13,
        [NativeName("Name", "D3D12_MARKER_API_ENDSUBMISSION")]
        Endsubmission = 0x14,
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME")]
        Decodeframe = 0x15,
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES")]
        Processframes = 0x16,
        [NativeName("Name", "D3D12_MARKER_API_ATOMICCOPYBUFFERUINT")]
        Atomiccopybufferuint = 0x17,
        [NativeName("Name", "D3D12_MARKER_API_ATOMICCOPYBUFFERUINT64")]
        Atomiccopybufferuint64 = 0x18,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVESUBRESOURCEREGION")]
        Resolvesubresourceregion = 0x19,
        [NativeName("Name", "D3D12_MARKER_API_WRITEBUFFERIMMEDIATE")]
        Writebufferimmediate = 0x1A,
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME1")]
        Decodeframe1 = 0x1B,
        [NativeName("Name", "D3D12_MARKER_API_SETPROTECTEDRESOURCESESSION")]
        Setprotectedresourcesession = 0x1C,
        [NativeName("Name", "D3D12_MARKER_API_DECODEFRAME2")]
        Decodeframe2 = 0x1D,
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES1")]
        Processframes1 = 0x1E,
        [NativeName("Name", "D3D12_MARKER_API_BUILDRAYTRACINGACCELERATIONSTRUCTURE")]
        Buildraytracingaccelerationstructure = 0x1F,
        [NativeName("Name", "D3D12_MARKER_API_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO")]
        Emitraytracingaccelerationstructurepostbuildinfo = 0x20,
        [NativeName("Name", "D3D12_MARKER_API_COPYRAYTRACINGACCELERATIONSTRUCTURE")]
        Copyraytracingaccelerationstructure = 0x21,
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHRAYS")]
        Dispatchrays = 0x22,
        [NativeName("Name", "D3D12_MARKER_API_INITIALIZEMETACOMMAND")]
        Initializemetacommand = 0x23,
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEMETACOMMAND")]
        Executemetacommand = 0x24,
        [NativeName("Name", "D3D12_MARKER_API_ESTIMATEMOTION")]
        Estimatemotion = 0x25,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEMOTIONVECTORHEAP")]
        Resolvemotionvectorheap = 0x26,
        [NativeName("Name", "D3D12_MARKER_API_SETPIPELINESTATE1")]
        Setpipelinestate1 = 0x27,
        [NativeName("Name", "D3D12_MARKER_API_INITIALIZEEXTENSIONCOMMAND")]
        Initializeextensioncommand = 0x28,
        [NativeName("Name", "D3D12_MARKER_API_EXECUTEEXTENSIONCOMMAND")]
        Executeextensioncommand = 0x29,
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHMESH")]
        Dispatchmesh = 0x2A,
        [NativeName("Name", "D3D12_MARKER_API_ENCODEFRAME")]
        Encodeframe = 0x2B,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEENCODEROUTPUTMETADATA")]
        Resolveencoderoutputmetadata = 0x2C,
        [NativeName("Name", "D3D12_MARKER_API_BARRIER")]
        Barrier = 0x2D,
        [NativeName("Name", "D3D12_MARKER_API_BEGIN_COMMAND_LIST")]
        BeginCommandList = 0x2E,
        [NativeName("Name", "D3D12_MARKER_API_DISPATCHGRAPH")]
        Dispatchgraph = 0x2F,
        [NativeName("Name", "D3D12_MARKER_API_SETPROGRAM")]
        Setprogram = 0x30,
        [NativeName("Name", "D3D12_MARKER_API_ENCODEFRAME1")]
        Encodeframe1 = 0x31,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEENCODEROUTPUTMETADATA1")]
        Resolveencoderoutputmetadata1 = 0x32,
        [NativeName("Name", "D3D12_MARKER_API_RESOLVEINPUTPARAMLAYOUT")]
        Resolveinputparamlayout = 0x33,
        [NativeName("Name", "D3D12_MARKER_API_PROCESSFRAMES2")]
        Processframes2 = 0x34,
        [NativeName("Name", "D3D12_MARKER_API_SET_WORK_GRAPH_MAXIMUM_GPU_INPUT_RECORDS")]
        SetWorkGraphMaximumGpuInputRecords = 0x35,
    }
}
