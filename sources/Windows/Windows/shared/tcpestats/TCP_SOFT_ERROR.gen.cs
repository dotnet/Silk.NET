// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR"]/*'/>
public enum TCP_SOFT_ERROR
{
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorNone"]/*'/>
    TcpErrorNone = 0,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorBelowDataWindow"]/*'/>
    TcpErrorBelowDataWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorAboveDataWindow"]/*'/>
    TcpErrorAboveDataWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorBelowAckWindow"]/*'/>
    TcpErrorBelowAckWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorAboveAckWindow"]/*'/>
    TcpErrorAboveAckWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorBelowTsWindow"]/*'/>
    TcpErrorBelowTsWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorAboveTsWindow"]/*'/>
    TcpErrorAboveTsWindow,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorDataChecksumError"]/*'/>
    TcpErrorDataChecksumError,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorDataLengthError"]/*'/>
    TcpErrorDataLengthError,
    /// <include file='TCP_SOFT_ERROR.xml' path='doc/member[@name="TCP_SOFT_ERROR.TcpErrorMaxSoftError"]/*'/>
    TcpErrorMaxSoftError,
}