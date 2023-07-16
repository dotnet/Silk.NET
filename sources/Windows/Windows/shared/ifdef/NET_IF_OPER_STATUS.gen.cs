// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS"]/*'/>
public enum NET_IF_OPER_STATUS
{
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_UP"]/*'/>
    NET_IF_OPER_STATUS_UP = 1,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_DOWN"]/*'/>
    NET_IF_OPER_STATUS_DOWN = 2,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_TESTING"]/*'/>
    NET_IF_OPER_STATUS_TESTING = 3,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_UNKNOWN"]/*'/>
    NET_IF_OPER_STATUS_UNKNOWN = 4,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_DORMANT"]/*'/>
    NET_IF_OPER_STATUS_DORMANT = 5,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_NOT_PRESENT"]/*'/>
    NET_IF_OPER_STATUS_NOT_PRESENT = 6,
    /// <include file='NET_IF_OPER_STATUS.xml' path='doc/member[@name="NET_IF_OPER_STATUS.NET_IF_OPER_STATUS_LOWER_LAYER_DOWN"]/*'/>
    NET_IF_OPER_STATUS_LOWER_LAYER_DOWN = 7,
}