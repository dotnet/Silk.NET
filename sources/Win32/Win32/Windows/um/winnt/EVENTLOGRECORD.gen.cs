// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENTLOGRECORD
{
    [NativeTypeName("DWORD")]
    public uint Length;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("DWORD")]
    public uint RecordNumber;

    [NativeTypeName("DWORD")]
    public uint TimeGenerated;

    [NativeTypeName("DWORD")]
    public uint TimeWritten;

    [NativeTypeName("DWORD")]
    public uint EventID;

    [NativeTypeName("WORD")]
    public ushort EventType;

    [NativeTypeName("WORD")]
    public ushort NumStrings;

    [NativeTypeName("WORD")]
    public ushort EventCategory;

    [NativeTypeName("WORD")]
    public ushort ReservedFlags;

    [NativeTypeName("DWORD")]
    public uint ClosingRecordNumber;

    [NativeTypeName("DWORD")]
    public uint StringOffset;

    [NativeTypeName("DWORD")]
    public uint UserSidLength;

    [NativeTypeName("DWORD")]
    public uint UserSidOffset;

    [NativeTypeName("DWORD")]
    public uint DataLength;

    [NativeTypeName("DWORD")]
    public uint DataOffset;
}
