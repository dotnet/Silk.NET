// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_TRANSLATED_SID.xml' path='doc/member[@name="LSA_TRANSLATED_SID"]/*'/>
public partial struct LSA_TRANSLATED_SID
{
    /// <include file='LSA_TRANSLATED_SID.xml' path='doc/member[@name="LSA_TRANSLATED_SID.Use"]/*'/>
    public SID_NAME_USE Use;
    /// <include file='LSA_TRANSLATED_SID.xml' path='doc/member[@name="LSA_TRANSLATED_SID.RelativeId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RelativeId;
    /// <include file='LSA_TRANSLATED_SID.xml' path='doc/member[@name="LSA_TRANSLATED_SID.DomainIndex"]/*'/>
    [NativeTypeName("LONG")]
    public int DomainIndex;
}