// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP"]/*' />
public enum LOGICAL_PROCESSOR_RELATIONSHIP
{
    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorCore"]/*' />
    RelationProcessorCore,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNode"]/*' />
    RelationNumaNode,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache"]/*' />
    RelationCache,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorPackage"]/*' />
    RelationProcessorPackage,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationGroup"]/*' />
    RelationGroup,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorDie"]/*' />
    RelationProcessorDie,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationNumaNodeEx"]/*' />
    RelationNumaNodeEx,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationProcessorModule"]/*' />
    RelationProcessorModule,

    /// <include file='LOGICAL_PROCESSOR_RELATIONSHIP.xml' path='doc/member[@name="LOGICAL_PROCESSOR_RELATIONSHIP.RelationAll"]/*' />
    RelationAll = 0xffff,
}
