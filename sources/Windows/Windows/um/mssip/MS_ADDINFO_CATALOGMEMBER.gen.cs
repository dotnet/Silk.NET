// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER"]/*'/>
public partial struct MS_ADDINFO_CATALOGMEMBER
{
    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.pStore"]/*'/>
    [NativeTypeName("struct CRYPTCATSTORE_ *")]
    public IntPtr pStore;
    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.pMember"]/*'/>
    [NativeTypeName("struct CRYPTCATMEMBER_ *")]
    public IntPtr pMember;
}