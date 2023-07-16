// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_TRANSLATED_NAME.xml' path='doc/member[@name="LSA_TRANSLATED_NAME"]/*'/>
public partial struct LSA_TRANSLATED_NAME
{
    /// <include file='LSA_TRANSLATED_NAME.xml' path='doc/member[@name="LSA_TRANSLATED_NAME.Use"]/*'/>
    public SID_NAME_USE Use;
    /// <include file='LSA_TRANSLATED_NAME.xml' path='doc/member[@name="LSA_TRANSLATED_NAME.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='LSA_TRANSLATED_NAME.xml' path='doc/member[@name="LSA_TRANSLATED_NAME.DomainIndex"]/*'/>
    [NativeTypeName("LONG")]
    public int DomainIndex;
}