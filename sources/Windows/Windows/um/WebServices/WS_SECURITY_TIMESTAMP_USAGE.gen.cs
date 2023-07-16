// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_TIMESTAMP_USAGE.xml' path='doc/member[@name="WS_SECURITY_TIMESTAMP_USAGE"]/*'/>
public enum WS_SECURITY_TIMESTAMP_USAGE
{
    /// <include file='WS_SECURITY_TIMESTAMP_USAGE.xml' path='doc/member[@name="WS_SECURITY_TIMESTAMP_USAGE.WS_SECURITY_TIMESTAMP_USAGE_ALWAYS"]/*'/>
    WS_SECURITY_TIMESTAMP_USAGE_ALWAYS = 1,
    /// <include file='WS_SECURITY_TIMESTAMP_USAGE.xml' path='doc/member[@name="WS_SECURITY_TIMESTAMP_USAGE.WS_SECURITY_TIMESTAMP_USAGE_NEVER"]/*'/>
    WS_SECURITY_TIMESTAMP_USAGE_NEVER = 2,
    /// <include file='WS_SECURITY_TIMESTAMP_USAGE.xml' path='doc/member[@name="WS_SECURITY_TIMESTAMP_USAGE.WS_SECURITY_TIMESTAMP_USAGE_REQUESTS_ONLY"]/*'/>
    WS_SECURITY_TIMESTAMP_USAGE_REQUESTS_ONLY = 3,
}