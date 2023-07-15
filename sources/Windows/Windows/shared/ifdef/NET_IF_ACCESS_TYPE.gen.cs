// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE"]/*'/>
public enum NET_IF_ACCESS_TYPE
{
    /// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE.NET_IF_ACCESS_LOOPBACK"]/*'/>
    NET_IF_ACCESS_LOOPBACK = 1,
    /// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE.NET_IF_ACCESS_BROADCAST"]/*'/>
    NET_IF_ACCESS_BROADCAST = 2,
    /// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE.NET_IF_ACCESS_POINT_TO_POINT"]/*'/>
    NET_IF_ACCESS_POINT_TO_POINT = 3,
    /// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE.NET_IF_ACCESS_POINT_TO_MULTI_POINT"]/*'/>
    NET_IF_ACCESS_POINT_TO_MULTI_POINT = 4,
    /// <include file='NET_IF_ACCESS_TYPE.xml' path='doc/member[@name="NET_IF_ACCESS_TYPE.NET_IF_ACCESS_MAXIMUM"]/*'/>
    NET_IF_ACCESS_MAXIMUM = 5,
}