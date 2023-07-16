// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPFORWARD_TYPE.xml' path='doc/member[@name="MIB_IPFORWARD_TYPE"]/*'/>
public enum MIB_IPFORWARD_TYPE
{
    /// <include file='MIB_IPFORWARD_TYPE.xml' path='doc/member[@name="MIB_IPFORWARD_TYPE.MIB_IPROUTE_TYPE_OTHER"]/*'/>
    MIB_IPROUTE_TYPE_OTHER = 1,
    /// <include file='MIB_IPFORWARD_TYPE.xml' path='doc/member[@name="MIB_IPFORWARD_TYPE.MIB_IPROUTE_TYPE_INVALID"]/*'/>
    MIB_IPROUTE_TYPE_INVALID = 2,
    /// <include file='MIB_IPFORWARD_TYPE.xml' path='doc/member[@name="MIB_IPFORWARD_TYPE.MIB_IPROUTE_TYPE_DIRECT"]/*'/>
    MIB_IPROUTE_TYPE_DIRECT = 3,
    /// <include file='MIB_IPFORWARD_TYPE.xml' path='doc/member[@name="MIB_IPFORWARD_TYPE.MIB_IPROUTE_TYPE_INDIRECT"]/*'/>
    MIB_IPROUTE_TYPE_INDIRECT = 4,
}