// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS"]/*'/>
public unsafe partial struct FS_BPIO_RESULTS
{
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.OpStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OpStatus;
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailingDriverNameLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FailingDriverNameLen;
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailingDriverName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort FailingDriverName[32];
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailureReasonLen"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FailureReasonLen;
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailureReason"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort FailureReason[128];
}