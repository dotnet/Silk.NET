// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SPVSTATE
{
    public SPVACTIONS eAction;

    [NativeTypeName("WORD")]
    public ushort LangID;

    [NativeTypeName("WORD")]
    public ushort wReserved;

    [NativeTypeName("long")]
    public int EmphAdj;

    [NativeTypeName("long")]
    public int RateAdj;

    [NativeTypeName("ULONG")]
    public uint Volume;
    public SPVPITCH PitchAdj;

    [NativeTypeName("ULONG")]
    public uint SilenceMSecs;

    [NativeTypeName("SPPHONEID *")]
    public ushort* pPhoneIds;
    public SPPARTOFSPEECH ePartOfSpeech;
    public SPVCONTEXT Context;
}
