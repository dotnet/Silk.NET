// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudgetNodeSegmentGroup
{
    /// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup.nodeIndex"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint nodeIndex;

    /// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup.segmentGroup"]/*'/>

    public DXCoreSegmentGroup segmentGroup;
}
