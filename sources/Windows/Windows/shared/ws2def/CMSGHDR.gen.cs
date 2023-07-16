// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CMSGHDR.xml' path='doc/member[@name="CMSGHDR"]/*'/>
public partial struct CMSGHDR
{
    /// <include file='CMSGHDR.xml' path='doc/member[@name="CMSGHDR.cmsg_len"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint cmsg_len;
    /// <include file='CMSGHDR.xml' path='doc/member[@name="CMSGHDR.cmsg_level"]/*'/>
    public int cmsg_level;
    /// <include file='CMSGHDR.xml' path='doc/member[@name="CMSGHDR.cmsg_type"]/*'/>
    public int cmsg_type;
}