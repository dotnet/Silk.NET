// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFNetAuthenticationFlags.xml' path='doc/member[@name="MFNetAuthenticationFlags"]/*'/>
public enum MFNetAuthenticationFlags
{
    /// <include file='MFNetAuthenticationFlags.xml' path='doc/member[@name="MFNetAuthenticationFlags.MFNET_AUTHENTICATION_PROXY"]/*'/>
    MFNET_AUTHENTICATION_PROXY = 0x1,
    /// <include file='MFNetAuthenticationFlags.xml' path='doc/member[@name="MFNetAuthenticationFlags.MFNET_AUTHENTICATION_CLEAR_TEXT"]/*'/>
    MFNET_AUTHENTICATION_CLEAR_TEXT = 0x2,
    /// <include file='MFNetAuthenticationFlags.xml' path='doc/member[@name="MFNetAuthenticationFlags.MFNET_AUTHENTICATION_LOGGED_ON_USER"]/*'/>
    MFNET_AUTHENTICATION_LOGGED_ON_USER = 0x4,
}