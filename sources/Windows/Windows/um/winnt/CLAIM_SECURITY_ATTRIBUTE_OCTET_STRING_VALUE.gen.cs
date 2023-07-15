// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
{
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE.pValue"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pValue;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE.ValueLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ValueLength;
}