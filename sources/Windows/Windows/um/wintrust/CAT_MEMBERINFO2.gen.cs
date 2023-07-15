// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CAT_MEMBERINFO2.xml' path='doc/member[@name="CAT_MEMBERINFO2"]/*'/>
public partial struct CAT_MEMBERINFO2
{
    /// <include file='CAT_MEMBERINFO2.xml' path='doc/member[@name="CAT_MEMBERINFO2.SubjectGuid"]/*'/>
    public Guid SubjectGuid;
    /// <include file='CAT_MEMBERINFO2.xml' path='doc/member[@name="CAT_MEMBERINFO2.dwCertVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCertVersion;
}