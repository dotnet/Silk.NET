// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NTFS_FILE_RECORD_INPUT_BUFFER.xml' path='doc/member[@name="NTFS_FILE_RECORD_INPUT_BUFFER"]/*'/>
public partial struct NTFS_FILE_RECORD_INPUT_BUFFER
{
    /// <include file='NTFS_FILE_RECORD_INPUT_BUFFER.xml' path='doc/member[@name="NTFS_FILE_RECORD_INPUT_BUFFER.FileReferenceNumber"]/*'/>
    public LARGE_INTEGER FileReferenceNumber;
}