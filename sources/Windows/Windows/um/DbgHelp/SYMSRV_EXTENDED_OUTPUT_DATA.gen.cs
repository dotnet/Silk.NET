// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA"]/*' />
public unsafe partial struct SYMSRV_EXTENDED_OUTPUT_DATA
{
    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.sizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint sizeOfStruct;

    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.version"]/*' />
    [NativeTypeName("DWORD")]
    public uint version;

    /// <include file='SYMSRV_EXTENDED_OUTPUT_DATA.xml' path='doc/member[@name="SYMSRV_EXTENDED_OUTPUT_DATA.filePtrMsg"]/*' />
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort filePtrMsg[261];
}
