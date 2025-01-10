// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SPPHRASEELEMENT
{
    [NativeTypeName("ULONG")]
    public uint ulAudioTimeOffset;

    [NativeTypeName("ULONG")]
    public uint ulAudioSizeTime;

    [NativeTypeName("ULONG")]
    public uint ulAudioStreamOffset;

    [NativeTypeName("ULONG")]
    public uint ulAudioSizeBytes;

    [NativeTypeName("ULONG")]
    public uint ulRetainedStreamOffset;

    [NativeTypeName("ULONG")]
    public uint ulRetainedSizeBytes;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszDisplayText;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszLexicalForm;

    [NativeTypeName("const SPPHONEID *")]
    public ushort* pszPronunciation;
    public byte bDisplayAttributes;

    [NativeTypeName("signed char")]
    public sbyte RequiredConfidence;

    [NativeTypeName("signed char")]
    public sbyte ActualConfidence;
    public byte Reserved;
    public float SREngineConfidence;
}
