// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_QUERY_ON_DISK_VOL_INFO_BUFFER
{
    public LARGE_INTEGER DirectoryCount;
    public LARGE_INTEGER FileCount;

    [NativeTypeName("WORD")]
    public ushort FsFormatMajVersion;

    [NativeTypeName("WORD")]
    public ushort FsFormatMinVersion;

    [NativeTypeName("WCHAR[12]")]
    public _FsFormatName_e__FixedBuffer FsFormatName;
    public LARGE_INTEGER FormatTime;
    public LARGE_INTEGER LastUpdateTime;

    [NativeTypeName("WCHAR[34]")]
    public _CopyrightInfo_e__FixedBuffer CopyrightInfo;

    [NativeTypeName("WCHAR[34]")]
    public _AbstractInfo_e__FixedBuffer AbstractInfo;

    [NativeTypeName("WCHAR[34]")]
    public _FormattingImplementationInfo_e__FixedBuffer FormattingImplementationInfo;

    [NativeTypeName("WCHAR[34]")]
    public _LastModifyingImplementationInfo_e__FixedBuffer LastModifyingImplementationInfo;

    [InlineArray(12)]
    public partial struct _FsFormatName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(34)]
    public partial struct _CopyrightInfo_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(34)]
    public partial struct _AbstractInfo_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(34)]
    public partial struct _FormattingImplementationInfo_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(34)]
    public partial struct _LastModifyingImplementationInfo_e__FixedBuffer
    {
        public ushort e0;
    }
}
