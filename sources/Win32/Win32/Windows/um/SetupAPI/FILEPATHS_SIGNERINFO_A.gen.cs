// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FILEPATHS_SIGNERINFO_A
{
    [NativeTypeName("PCSTR")]
    public sbyte* Target;

    [NativeTypeName("PCSTR")]
    public sbyte* Source;
    public uint Win32Error;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("PCSTR")]
    public sbyte* DigitalSigner;

    [NativeTypeName("PCSTR")]
    public sbyte* Version;

    [NativeTypeName("PCSTR")]
    public sbyte* CatalogFile;
}
