// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_PROTECTION_LEVEL.xml' path='doc/member[@name="WS_PROTECTION_LEVEL"]/*'/>
public enum WS_PROTECTION_LEVEL
{
    /// <include file='WS_PROTECTION_LEVEL.xml' path='doc/member[@name="WS_PROTECTION_LEVEL.WS_PROTECTION_LEVEL_NONE"]/*'/>
    WS_PROTECTION_LEVEL_NONE = 1,
    /// <include file='WS_PROTECTION_LEVEL.xml' path='doc/member[@name="WS_PROTECTION_LEVEL.WS_PROTECTION_LEVEL_SIGN"]/*'/>
    WS_PROTECTION_LEVEL_SIGN = 2,
    /// <include file='WS_PROTECTION_LEVEL.xml' path='doc/member[@name="WS_PROTECTION_LEVEL.WS_PROTECTION_LEVEL_SIGN_AND_ENCRYPT"]/*'/>
    WS_PROTECTION_LEVEL_SIGN_AND_ENCRYPT = 3,
}