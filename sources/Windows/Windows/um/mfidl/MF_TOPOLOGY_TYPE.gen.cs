// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE"]/*'/>
public enum MF_TOPOLOGY_TYPE
{
    /// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE.MF_TOPOLOGY_OUTPUT_NODE"]/*'/>
    MF_TOPOLOGY_OUTPUT_NODE = 0,
    /// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE.MF_TOPOLOGY_SOURCESTREAM_NODE"]/*'/>
    MF_TOPOLOGY_SOURCESTREAM_NODE = (MF_TOPOLOGY_OUTPUT_NODE + 1),
    /// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE.MF_TOPOLOGY_TRANSFORM_NODE"]/*'/>
    MF_TOPOLOGY_TRANSFORM_NODE = (MF_TOPOLOGY_SOURCESTREAM_NODE + 1),
    /// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE.MF_TOPOLOGY_TEE_NODE"]/*'/>
    MF_TOPOLOGY_TEE_NODE = (MF_TOPOLOGY_TRANSFORM_NODE + 1),
    /// <include file='MF_TOPOLOGY_TYPE.xml' path='doc/member[@name="MF_TOPOLOGY_TYPE.MF_TOPOLOGY_MAX"]/*'/>
    MF_TOPOLOGY_MAX = unchecked((int)(0xffffffff)),
}