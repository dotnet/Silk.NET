// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='JOB_SET_ARRAY.xml' path='doc/member[@name="JOB_SET_ARRAY"]/*'/>
public partial struct JOB_SET_ARRAY
{
    /// <include file='JOB_SET_ARRAY.xml' path='doc/member[@name="JOB_SET_ARRAY.JobHandle"]/*'/>
    public HANDLE JobHandle;
    /// <include file='JOB_SET_ARRAY.xml' path='doc/member[@name="JOB_SET_ARRAY.MemberLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MemberLevel;
    /// <include file='JOB_SET_ARRAY.xml' path='doc/member[@name="JOB_SET_ARRAY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}