// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE"]/*' />
public unsafe partial struct SPVSTATE
{
    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.eAction"]/*' />
    public SPVACTIONS eAction;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.LangID"]/*' />
    [NativeTypeName("WORD")]
    public ushort LangID;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.wReserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.EmphAdj"]/*' />
    [NativeTypeName("long")]
    public int EmphAdj;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.RateAdj"]/*' />
    [NativeTypeName("long")]
    public int RateAdj;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.Volume"]/*' />
    [NativeTypeName("ULONG")]
    public uint Volume;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.PitchAdj"]/*' />
    public SPVPITCH PitchAdj;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.SilenceMSecs"]/*' />
    [NativeTypeName("ULONG")]
    public uint SilenceMSecs;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.pPhoneIds"]/*' />
    [NativeTypeName("SPPHONEID *")]
    public ushort* pPhoneIds;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.ePartOfSpeech"]/*' />
    public SPPARTOFSPEECH ePartOfSpeech;

    /// <include file='SPVSTATE.xml' path='doc/member[@name="SPVSTATE.Context"]/*' />
    public SPVCONTEXT Context;
}
