// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_ENUMERATION_INFORMATION.xml' path='doc/member[@name="LSA_ENUMERATION_INFORMATION"]/*'/>
public unsafe partial struct LSA_ENUMERATION_INFORMATION
{
    /// <include file='LSA_ENUMERATION_INFORMATION.xml' path='doc/member[@name="LSA_ENUMERATION_INFORMATION.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
}