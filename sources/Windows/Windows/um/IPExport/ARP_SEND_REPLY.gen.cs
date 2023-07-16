// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ARP_SEND_REPLY.xml' path='doc/member[@name="ARP_SEND_REPLY"]/*'/>
public partial struct ARP_SEND_REPLY
{
    /// <include file='ARP_SEND_REPLY.xml' path='doc/member[@name="ARP_SEND_REPLY.DestAddress"]/*'/>
    [NativeTypeName("IPAddr")]
    public uint DestAddress;
    /// <include file='ARP_SEND_REPLY.xml' path='doc/member[@name="ARP_SEND_REPLY.SrcAddress"]/*'/>
    [NativeTypeName("IPAddr")]
    public uint SrcAddress;
}