// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS"]/*'/>
public enum INTERNAL_IF_OPER_STATUS
{
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_NON_OPERATIONAL"]/*'/>
    IF_OPER_STATUS_NON_OPERATIONAL = 0,
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_UNREACHABLE"]/*'/>
    IF_OPER_STATUS_UNREACHABLE = 1,
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_DISCONNECTED"]/*'/>
    IF_OPER_STATUS_DISCONNECTED = 2,
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_CONNECTING"]/*'/>
    IF_OPER_STATUS_CONNECTING = 3,
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_CONNECTED"]/*'/>
    IF_OPER_STATUS_CONNECTED = 4,
    /// <include file='INTERNAL_IF_OPER_STATUS.xml' path='doc/member[@name="INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_OPERATIONAL"]/*'/>
    IF_OPER_STATUS_OPERATIONAL = 5,
}