// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50"]/*' />
public unsafe partial struct SPPHRASE_50
{
    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.LangID"]/*' />
    [NativeTypeName("WORD")]
    public ushort LangID;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.wHomophoneGroupId"]/*' />
    [NativeTypeName("WORD")]
    public ushort wHomophoneGroupId;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ullGrammarID"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullGrammarID;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ftStartTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ftStartTime;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ullAudioStreamPosition"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamPosition;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ulAudioSizeBytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioSizeBytes;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ulRetainedSizeBytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulRetainedSizeBytes;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ulAudioSizeTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAudioSizeTime;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.Rule"]/*' />
    public SPPHRASERULE Rule;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.pProperties"]/*' />
    [NativeTypeName("const SPPHRASEPROPERTY *")]
    public SPPHRASEPROPERTY* pProperties;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.pElements"]/*' />
    [NativeTypeName("const SPPHRASEELEMENT *")]
    public SPPHRASEELEMENT* pElements;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.cReplacements"]/*' />
    [NativeTypeName("ULONG")]
    public uint cReplacements;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.pReplacements"]/*' />
    [NativeTypeName("const SPPHRASEREPLACEMENT *")]
    public SPPHRASEREPLACEMENT* pReplacements;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.SREngineID"]/*' />
    public Guid SREngineID;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.ulSREnginePrivateDataSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSREnginePrivateDataSize;

    /// <include file='SPPHRASE_50.xml' path='doc/member[@name="SPPHRASE_50.pSREnginePrivateData"]/*' />
    [NativeTypeName("const BYTE *")]
    public byte* pSREnginePrivateData;
}
