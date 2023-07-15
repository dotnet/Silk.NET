// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_ADDRESSING_VERSION.xml' path='doc/member[@name="WS_ADDRESSING_VERSION"]/*'/>
public enum WS_ADDRESSING_VERSION
{
    /// <include file='WS_ADDRESSING_VERSION.xml' path='doc/member[@name="WS_ADDRESSING_VERSION.WS_ADDRESSING_VERSION_0_9"]/*'/>
    WS_ADDRESSING_VERSION_0_9 = 1,
    /// <include file='WS_ADDRESSING_VERSION.xml' path='doc/member[@name="WS_ADDRESSING_VERSION.WS_ADDRESSING_VERSION_1_0"]/*'/>
    WS_ADDRESSING_VERSION_1_0 = 2,
    /// <include file='WS_ADDRESSING_VERSION.xml' path='doc/member[@name="WS_ADDRESSING_VERSION.WS_ADDRESSING_VERSION_TRANSPORT"]/*'/>
    WS_ADDRESSING_VERSION_TRANSPORT = 3,
}