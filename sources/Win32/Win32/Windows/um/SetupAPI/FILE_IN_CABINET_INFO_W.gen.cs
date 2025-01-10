// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FILE_IN_CABINET_INFO_W
{
    [NativeTypeName("PCWSTR")]
    public ushort* NameInCabinet;

    [NativeTypeName("DWORD")]
    public uint FileSize;

    [NativeTypeName("DWORD")]
    public uint Win32Error;

    [NativeTypeName("WORD")]
    public ushort DosDate;

    [NativeTypeName("WORD")]
    public ushort DosTime;

    [NativeTypeName("WORD")]
    public ushort DosAttribs;

    [NativeTypeName("WCHAR[260]")]
    public _FullTargetName_e__FixedBuffer FullTargetName;

    [InlineArray(260)]
    public partial struct _FullTargetName_e__FixedBuffer
    {
        public ushort e0;
    }
}
