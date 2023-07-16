// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SID_IDENTIFIER_AUTHORITY.xml' path='doc/member[@name="SID_IDENTIFIER_AUTHORITY"]/*'/>
public unsafe partial struct SID_IDENTIFIER_AUTHORITY
{
    /// <include file='SID_IDENTIFIER_AUTHORITY.xml' path='doc/member[@name="SID_IDENTIFIER_AUTHORITY.Value"]/*'/>
    [NativeTypeName("BYTE[6]")]
    public fixed byte Value[6];
}