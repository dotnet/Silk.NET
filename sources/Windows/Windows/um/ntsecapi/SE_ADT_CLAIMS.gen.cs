// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SE_ADT_CLAIMS.xml' path='doc/member[@name="SE_ADT_CLAIMS"]/*'/>
public unsafe partial struct SE_ADT_CLAIMS
{
    /// <include file='SE_ADT_CLAIMS.xml' path='doc/member[@name="SE_ADT_CLAIMS.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='SE_ADT_CLAIMS.xml' path='doc/member[@name="SE_ADT_CLAIMS.Claims"]/*'/>
    [NativeTypeName("PCLAIMS_BLOB")]
    public void* Claims;
}