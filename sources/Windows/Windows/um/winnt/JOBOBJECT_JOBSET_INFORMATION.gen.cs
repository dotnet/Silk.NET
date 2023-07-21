// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='JOBOBJECT_JOBSET_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_JOBSET_INFORMATION"]/*' />
public partial struct JOBOBJECT_JOBSET_INFORMATION
{
    /// <include file='JOBOBJECT_JOBSET_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_JOBSET_INFORMATION.MemberLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint MemberLevel;
}
