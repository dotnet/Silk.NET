// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SP_FILE_COPY_PARAMS_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HSPFILEQ QueueHandle;

    [NativeTypeName("PCSTR")]
    public sbyte* SourceRootPath;

    [NativeTypeName("PCSTR")]
    public sbyte* SourcePath;

    [NativeTypeName("PCSTR")]
    public sbyte* SourceFilename;

    [NativeTypeName("PCSTR")]
    public sbyte* SourceDescription;

    [NativeTypeName("PCSTR")]
    public sbyte* SourceTagfile;

    [NativeTypeName("PCSTR")]
    public sbyte* TargetDirectory;

    [NativeTypeName("PCSTR")]
    public sbyte* TargetFilename;

    [NativeTypeName("DWORD")]
    public uint CopyStyle;
    public HINF LayoutInf;

    [NativeTypeName("PCSTR")]
    public sbyte* SecurityDescriptor;
}
