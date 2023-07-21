// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM"]/*' />
public enum TCP_RTO_ALGORITHM
{
    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.TcpRtoAlgorithmOther"]/*' />
    TcpRtoAlgorithmOther = 1,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.TcpRtoAlgorithmConstant"]/*' />
    TcpRtoAlgorithmConstant,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.TcpRtoAlgorithmRsre"]/*' />
    TcpRtoAlgorithmRsre,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.TcpRtoAlgorithmVanj"]/*' />
    TcpRtoAlgorithmVanj,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.MIB_TCP_RTO_OTHER"]/*' />
    MIB_TCP_RTO_OTHER = 1,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.MIB_TCP_RTO_CONSTANT"]/*' />
    MIB_TCP_RTO_CONSTANT = 2,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.MIB_TCP_RTO_RSRE"]/*' />
    MIB_TCP_RTO_RSRE = 3,

    /// <include file='TCP_RTO_ALGORITHM.xml' path='doc/member[@name="TCP_RTO_ALGORITHM.MIB_TCP_RTO_VANJ"]/*' />
    MIB_TCP_RTO_VANJ = 4,
}
