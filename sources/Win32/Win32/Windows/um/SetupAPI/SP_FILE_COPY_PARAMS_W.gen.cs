// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SP_FILE_COPY_PARAMS_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HSPFILEQ QueueHandle;

    [NativeTypeName("PCWSTR")]
    public ushort* SourceRootPath;

    [NativeTypeName("PCWSTR")]
    public ushort* SourcePath;

    [NativeTypeName("PCWSTR")]
    public ushort* SourceFilename;

    [NativeTypeName("PCWSTR")]
    public ushort* SourceDescription;

    [NativeTypeName("PCWSTR")]
    public ushort* SourceTagfile;

    [NativeTypeName("PCWSTR")]
    public ushort* TargetDirectory;

    [NativeTypeName("PCWSTR")]
    public ushort* TargetFilename;

    [NativeTypeName("DWORD")]
    public uint CopyStyle;
    public HINF LayoutInf;

    [NativeTypeName("PCWSTR")]
    public ushort* SecurityDescriptor;
}
