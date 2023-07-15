// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NET_IF_DIRECTION_TYPE.xml' path='doc/member[@name="NET_IF_DIRECTION_TYPE"]/*'/>
public enum NET_IF_DIRECTION_TYPE
{
    /// <include file='NET_IF_DIRECTION_TYPE.xml' path='doc/member[@name="NET_IF_DIRECTION_TYPE.NET_IF_DIRECTION_SENDRECEIVE"]/*'/>
    NET_IF_DIRECTION_SENDRECEIVE,
    /// <include file='NET_IF_DIRECTION_TYPE.xml' path='doc/member[@name="NET_IF_DIRECTION_TYPE.NET_IF_DIRECTION_SENDONLY"]/*'/>
    NET_IF_DIRECTION_SENDONLY,
    /// <include file='NET_IF_DIRECTION_TYPE.xml' path='doc/member[@name="NET_IF_DIRECTION_TYPE.NET_IF_DIRECTION_RECEIVEONLY"]/*'/>
    NET_IF_DIRECTION_RECEIVEONLY,
    /// <include file='NET_IF_DIRECTION_TYPE.xml' path='doc/member[@name="NET_IF_DIRECTION_TYPE.NET_IF_DIRECTION_MAXIMUM"]/*'/>
    NET_IF_DIRECTION_MAXIMUM,
}