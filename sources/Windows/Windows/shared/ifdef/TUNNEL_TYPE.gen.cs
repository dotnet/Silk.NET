// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE"]/*'/>
public enum TUNNEL_TYPE
{
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_NONE"]/*'/>
    TUNNEL_TYPE_NONE = 0,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_OTHER"]/*'/>
    TUNNEL_TYPE_OTHER = 1,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_DIRECT"]/*'/>
    TUNNEL_TYPE_DIRECT = 2,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_6TO4"]/*'/>
    TUNNEL_TYPE_6TO4 = 11,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_ISATAP"]/*'/>
    TUNNEL_TYPE_ISATAP = 13,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_TEREDO"]/*'/>
    TUNNEL_TYPE_TEREDO = 14,
    /// <include file='TUNNEL_TYPE.xml' path='doc/member[@name="TUNNEL_TYPE.TUNNEL_TYPE_IPHTTPS"]/*'/>
    TUNNEL_TYPE_IPHTTPS = 15,
}