// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='TOKEN_USER_CLAIMS.xml' path='doc/member[@name="TOKEN_USER_CLAIMS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct TOKEN_USER_CLAIMS
{
    /// <include file='TOKEN_USER_CLAIMS.xml' path='doc/member[@name="TOKEN_USER_CLAIMS.UserClaims"]/*'/>
    [NativeTypeName("PCLAIMS_BLOB")]
    public void* UserClaims;
}