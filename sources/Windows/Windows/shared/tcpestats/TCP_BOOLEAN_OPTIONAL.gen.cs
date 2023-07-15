// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCP_BOOLEAN_OPTIONAL.xml' path='doc/member[@name="TCP_BOOLEAN_OPTIONAL"]/*'/>
public enum TCP_BOOLEAN_OPTIONAL
{
    /// <include file='TCP_BOOLEAN_OPTIONAL.xml' path='doc/member[@name="TCP_BOOLEAN_OPTIONAL.TcpBoolOptDisabled"]/*'/>
    TcpBoolOptDisabled = 0,
    /// <include file='TCP_BOOLEAN_OPTIONAL.xml' path='doc/member[@name="TCP_BOOLEAN_OPTIONAL.TcpBoolOptEnabled"]/*'/>
    TcpBoolOptEnabled,
    /// <include file='TCP_BOOLEAN_OPTIONAL.xml' path='doc/member[@name="TCP_BOOLEAN_OPTIONAL.TcpBoolOptUnchanged"]/*'/>
    TcpBoolOptUnchanged = -1,
}