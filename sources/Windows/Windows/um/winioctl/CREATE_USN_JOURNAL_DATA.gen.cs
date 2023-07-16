// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREATE_USN_JOURNAL_DATA.xml' path='doc/member[@name="CREATE_USN_JOURNAL_DATA"]/*'/>
public partial struct CREATE_USN_JOURNAL_DATA
{
    /// <include file='CREATE_USN_JOURNAL_DATA.xml' path='doc/member[@name="CREATE_USN_JOURNAL_DATA.MaximumSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumSize;
    /// <include file='CREATE_USN_JOURNAL_DATA.xml' path='doc/member[@name="CREATE_USN_JOURNAL_DATA.AllocationDelta"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong AllocationDelta;
}