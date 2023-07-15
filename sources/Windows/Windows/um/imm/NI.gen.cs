// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class NI
{
    [NativeTypeName("#define NI_OPENCANDIDATE 0x0010")]
    public const int NI_OPENCANDIDATE = 0x0010;
    [NativeTypeName("#define NI_CLOSECANDIDATE 0x0011")]
    public const int NI_CLOSECANDIDATE = 0x0011;
    [NativeTypeName("#define NI_SELECTCANDIDATESTR 0x0012")]
    public const int NI_SELECTCANDIDATESTR = 0x0012;
    [NativeTypeName("#define NI_CHANGECANDIDATELIST 0x0013")]
    public const int NI_CHANGECANDIDATELIST = 0x0013;
    [NativeTypeName("#define NI_FINALIZECONVERSIONRESULT 0x0014")]
    public const int NI_FINALIZECONVERSIONRESULT = 0x0014;
    [NativeTypeName("#define NI_COMPOSITIONSTR 0x0015")]
    public const int NI_COMPOSITIONSTR = 0x0015;
    [NativeTypeName("#define NI_SETCANDIDATE_PAGESTART 0x0016")]
    public const int NI_SETCANDIDATE_PAGESTART = 0x0016;
    [NativeTypeName("#define NI_SETCANDIDATE_PAGESIZE 0x0017")]
    public const int NI_SETCANDIDATE_PAGESIZE = 0x0017;
    [NativeTypeName("#define NI_IMEMENUSELECTED 0x0018")]
    public const int NI_IMEMENUSELECTED = 0x0018;
}