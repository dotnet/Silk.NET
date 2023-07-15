// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.xml' path='doc/member[@name="MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS"]/*'/>
public enum MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS
{
    /// <include file='MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.xml' path='doc/member[@name="MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.MF_TOPOLOGY_RESOLUTION_SUCCEEDED"]/*'/>
    MF_TOPOLOGY_RESOLUTION_SUCCEEDED = 0,
    /// <include file='MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.xml' path='doc/member[@name="MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.MF_OPTIONAL_NODE_REJECTED_MEDIA_TYPE"]/*'/>
    MF_OPTIONAL_NODE_REJECTED_MEDIA_TYPE = 0x1,
    /// <include file='MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.xml' path='doc/member[@name="MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS.MF_OPTIONAL_NODE_REJECTED_PROTECTED_PROCESS"]/*'/>
    MF_OPTIONAL_NODE_REJECTED_PROTECTED_PROCESS = 0x2,
}