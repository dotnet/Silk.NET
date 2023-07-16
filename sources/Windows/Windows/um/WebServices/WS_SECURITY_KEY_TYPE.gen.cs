// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_KEY_TYPE.xml' path='doc/member[@name="WS_SECURITY_KEY_TYPE"]/*'/>
public enum WS_SECURITY_KEY_TYPE
{
    /// <include file='WS_SECURITY_KEY_TYPE.xml' path='doc/member[@name="WS_SECURITY_KEY_TYPE.WS_SECURITY_KEY_TYPE_NONE"]/*'/>
    WS_SECURITY_KEY_TYPE_NONE = 1,
    /// <include file='WS_SECURITY_KEY_TYPE.xml' path='doc/member[@name="WS_SECURITY_KEY_TYPE.WS_SECURITY_KEY_TYPE_SYMMETRIC"]/*'/>
    WS_SECURITY_KEY_TYPE_SYMMETRIC = 2,
    /// <include file='WS_SECURITY_KEY_TYPE.xml' path='doc/member[@name="WS_SECURITY_KEY_TYPE.WS_SECURITY_KEY_TYPE_ASYMMETRIC"]/*'/>
    WS_SECURITY_KEY_TYPE_ASYMMETRIC = 3,
}