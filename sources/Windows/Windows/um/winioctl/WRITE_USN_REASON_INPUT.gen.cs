// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WRITE_USN_REASON_INPUT.xml' path='doc/member[@name="WRITE_USN_REASON_INPUT"]/*'/>
public partial struct WRITE_USN_REASON_INPUT
{
    /// <include file='WRITE_USN_REASON_INPUT.xml' path='doc/member[@name="WRITE_USN_REASON_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='WRITE_USN_REASON_INPUT.xml' path='doc/member[@name="WRITE_USN_REASON_INPUT.UsnReasonToWrite"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UsnReasonToWrite;
}