// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GROUP_SOURCE_REQ.xml' path='doc/member[@name="GROUP_SOURCE_REQ"]/*'/>
public partial struct GROUP_SOURCE_REQ
{
    /// <include file='GROUP_SOURCE_REQ.xml' path='doc/member[@name="GROUP_SOURCE_REQ.gsr_interface"]/*'/>
    [NativeTypeName("ULONG")]
    public uint gsr_interface;
    /// <include file='GROUP_SOURCE_REQ.xml' path='doc/member[@name="GROUP_SOURCE_REQ.gsr_group"]/*'/>
    public SOCKADDR_STORAGE gsr_group;
    /// <include file='GROUP_SOURCE_REQ.xml' path='doc/member[@name="GROUP_SOURCE_REQ.gsr_source"]/*'/>
    public SOCKADDR_STORAGE gsr_source;
}