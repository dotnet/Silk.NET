// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_INITIATE_REPAIR_OUTPUT_BUFFER.xml' path='doc/member[@name="FILE_INITIATE_REPAIR_OUTPUT_BUFFER"]/*'/>
public partial struct FILE_INITIATE_REPAIR_OUTPUT_BUFFER
{
    /// <include file='FILE_INITIATE_REPAIR_OUTPUT_BUFFER.xml' path='doc/member[@name="FILE_INITIATE_REPAIR_OUTPUT_BUFFER.Hint1"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Hint1;
    /// <include file='FILE_INITIATE_REPAIR_OUTPUT_BUFFER.xml' path='doc/member[@name="FILE_INITIATE_REPAIR_OUTPUT_BUFFER.Hint2"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Hint2;
    /// <include file='FILE_INITIATE_REPAIR_OUTPUT_BUFFER.xml' path='doc/member[@name="FILE_INITIATE_REPAIR_OUTPUT_BUFFER.Clsn"]/*'/>
    [NativeTypeName("CLSN")]
    public ulong Clsn;
    /// <include file='FILE_INITIATE_REPAIR_OUTPUT_BUFFER.xml' path='doc/member[@name="FILE_INITIATE_REPAIR_OUTPUT_BUFFER.Status"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Status;
}