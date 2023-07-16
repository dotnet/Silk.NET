// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='TOKEN_DEVICE_CLAIMS.xml' path='doc/member[@name="TOKEN_DEVICE_CLAIMS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct TOKEN_DEVICE_CLAIMS
{
    /// <include file='TOKEN_DEVICE_CLAIMS.xml' path='doc/member[@name="TOKEN_DEVICE_CLAIMS.DeviceClaims"]/*'/>
    [NativeTypeName("PCLAIMS_BLOB")]
    public void* DeviceClaims;
}