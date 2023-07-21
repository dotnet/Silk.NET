// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT"]/*' />
public unsafe partial struct SPPHRASEELEMENT
{
    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulAudioTimeOffset"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioTimeOffset;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulAudioSizeTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioSizeTime;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulAudioStreamOffset"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioStreamOffset;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulAudioSizeBytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioSizeBytes;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulRetainedStreamOffset"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulRetainedStreamOffset;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ulRetainedSizeBytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulRetainedSizeBytes;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.pszDisplayText"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszDisplayText;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.pszLexicalForm"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszLexicalForm;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.pszPronunciation"]/*' />
    [NativeTypeName("const SPPHONEID *")]
    public ushort* pszPronunciation;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.bDisplayAttributes"]/*' />
    public byte bDisplayAttributes;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.RequiredConfidence"]/*' />
    [NativeTypeName("signed char")]
    public sbyte RequiredConfidence;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.ActualConfidence"]/*' />
    [NativeTypeName("signed char")]
    public sbyte ActualConfidence;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.Reserved"]/*' />
    public byte Reserved;

    /// <include file='SPPHRASEELEMENT.xml' path='doc/member[@name="SPPHRASEELEMENT.SREngineConfidence"]/*' />
    public float SREngineConfidence;
}
