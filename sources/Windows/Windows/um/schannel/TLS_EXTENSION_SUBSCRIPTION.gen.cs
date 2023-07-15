// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TLS_EXTENSION_SUBSCRIPTION.xml' path='doc/member[@name="TLS_EXTENSION_SUBSCRIPTION"]/*'/>
public partial struct TLS_EXTENSION_SUBSCRIPTION
{
    /// <include file='TLS_EXTENSION_SUBSCRIPTION.xml' path='doc/member[@name="TLS_EXTENSION_SUBSCRIPTION.ExtensionType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExtensionType;
    /// <include file='TLS_EXTENSION_SUBSCRIPTION.xml' path='doc/member[@name="TLS_EXTENSION_SUBSCRIPTION.HandshakeType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort HandshakeType;
}