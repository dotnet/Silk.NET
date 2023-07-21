// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE"]/*' />
public enum MEM_DEDICATED_ATTRIBUTE_TYPE
{
    /// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE.MemDedicatedAttributeReadBandwidth"]/*' />
    MemDedicatedAttributeReadBandwidth = 0,

    /// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE.MemDedicatedAttributeReadLatency"]/*' />
    MemDedicatedAttributeReadLatency,

    /// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE.MemDedicatedAttributeWriteBandwidth"]/*' />
    MemDedicatedAttributeWriteBandwidth,

    /// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE.MemDedicatedAttributeWriteLatency"]/*' />
    MemDedicatedAttributeWriteLatency,

    /// <include file='MEM_DEDICATED_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MEM_DEDICATED_ATTRIBUTE_TYPE.MemDedicatedAttributeMax"]/*' />
    MemDedicatedAttributeMax,
}
