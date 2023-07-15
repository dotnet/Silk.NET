// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_TRANSLATED_SID2.xml' path='doc/member[@name="LSA_TRANSLATED_SID2"]/*'/>
public unsafe partial struct LSA_TRANSLATED_SID2
{
    /// <include file='LSA_TRANSLATED_SID2.xml' path='doc/member[@name="LSA_TRANSLATED_SID2.Use"]/*'/>
    public SID_NAME_USE Use;
    /// <include file='LSA_TRANSLATED_SID2.xml' path='doc/member[@name="LSA_TRANSLATED_SID2.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
    /// <include file='LSA_TRANSLATED_SID2.xml' path='doc/member[@name="LSA_TRANSLATED_SID2.DomainIndex"]/*'/>
    [NativeTypeName("LONG")]
    public int DomainIndex;
    /// <include file='LSA_TRANSLATED_SID2.xml' path='doc/member[@name="LSA_TRANSLATED_SID2.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}