// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RESUME_PERFORMANCE.xml' path='doc/member[@name="RESUME_PERFORMANCE"]/*'/>
public partial struct RESUME_PERFORMANCE
{
    /// <include file='RESUME_PERFORMANCE.xml' path='doc/member[@name="RESUME_PERFORMANCE.PostTimeMs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PostTimeMs;
    /// <include file='RESUME_PERFORMANCE.xml' path='doc/member[@name="RESUME_PERFORMANCE.TotalResumeTimeMs"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalResumeTimeMs;
    /// <include file='RESUME_PERFORMANCE.xml' path='doc/member[@name="RESUME_PERFORMANCE.ResumeCompleteTimestamp"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ResumeCompleteTimestamp;
}