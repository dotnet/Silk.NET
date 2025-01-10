// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_LOGGING_INFO
{
    public HTTP_PROPERTY_FLAGS Flags;

    [NativeTypeName("ULONG")]
    public uint LoggingFlags;

    [NativeTypeName("PCWSTR")]
    public ushort* SoftwareName;
    public ushort SoftwareNameLength;
    public ushort DirectoryNameLength;

    [NativeTypeName("PCWSTR")]
    public ushort* DirectoryName;
    public HTTP_LOGGING_TYPE Format;

    [NativeTypeName("ULONG")]
    public uint Fields;

    [NativeTypeName("PVOID")]
    public void* pExtFields;
    public ushort NumOfExtFields;
    public ushort MaxRecordSize;
    public HTTP_LOGGING_ROLLOVER_TYPE RolloverType;

    [NativeTypeName("ULONG")]
    public uint RolloverSize;

    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* pSecurityDescriptor;
}
