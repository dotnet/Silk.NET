// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION"]/*' />
public unsafe partial struct ASSEMBLY_FILE_DETAILED_INFORMATION
{
    /// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION.ulFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFlags;

    /// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION.ulFilenameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFilenameLength;

    /// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION.ulPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulPathLength;

    /// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION.lpFileName"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpFileName;

    /// <include file='ASSEMBLY_FILE_DETAILED_INFORMATION.xml' path='doc/member[@name="ASSEMBLY_FILE_DETAILED_INFORMATION.lpFilePath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpFilePath;
}
