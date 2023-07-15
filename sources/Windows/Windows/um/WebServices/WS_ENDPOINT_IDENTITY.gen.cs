// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_ENDPOINT_IDENTITY.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY"]/*'/>
public partial struct WS_ENDPOINT_IDENTITY
{
    /// <include file='WS_ENDPOINT_IDENTITY.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY.identityType"]/*'/>
    public WS_ENDPOINT_IDENTITY_TYPE identityType;
}