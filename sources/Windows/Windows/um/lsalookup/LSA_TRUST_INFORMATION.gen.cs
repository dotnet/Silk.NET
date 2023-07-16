// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_TRUST_INFORMATION"]/*'/>
public unsafe partial struct LSA_TRUST_INFORMATION
{
    /// <include file='LSA_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_TRUST_INFORMATION.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='LSA_TRUST_INFORMATION.xml' path='doc/member[@name="LSA_TRUST_INFORMATION.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
}