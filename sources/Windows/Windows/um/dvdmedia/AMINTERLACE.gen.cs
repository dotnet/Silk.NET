// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class AMINTERLACE
{
    [NativeTypeName("#define AMINTERLACE_IsInterlaced 0x00000001")]
    public const int AMINTERLACE_IsInterlaced = 0x00000001;
    [NativeTypeName("#define AMINTERLACE_1FieldPerSample 0x00000002")]
    public const int AMINTERLACE_1FieldPerSample = 0x00000002;
    [NativeTypeName("#define AMINTERLACE_Field1First 0x00000004")]
    public const int AMINTERLACE_Field1First = 0x00000004;
    [NativeTypeName("#define AMINTERLACE_UNUSED 0x00000008")]
    public const int AMINTERLACE_UNUSED = 0x00000008;
    [NativeTypeName("#define AMINTERLACE_FieldPatternMask 0x00000030")]
    public const int AMINTERLACE_FieldPatternMask = 0x00000030;
    [NativeTypeName("#define AMINTERLACE_FieldPatField1Only 0x00000000")]
    public const int AMINTERLACE_FieldPatField1Only = 0x00000000;
    [NativeTypeName("#define AMINTERLACE_FieldPatField2Only 0x00000010")]
    public const int AMINTERLACE_FieldPatField2Only = 0x00000010;
    [NativeTypeName("#define AMINTERLACE_FieldPatBothRegular 0x00000020")]
    public const int AMINTERLACE_FieldPatBothRegular = 0x00000020;
    [NativeTypeName("#define AMINTERLACE_FieldPatBothIrregular 0x00000030")]
    public const int AMINTERLACE_FieldPatBothIrregular = 0x00000030;
    [NativeTypeName("#define AMINTERLACE_DisplayModeMask 0x000000c0")]
    public const int AMINTERLACE_DisplayModeMask = 0x000000c0;
    [NativeTypeName("#define AMINTERLACE_DisplayModeBobOnly 0x00000000")]
    public const int AMINTERLACE_DisplayModeBobOnly = 0x00000000;
    [NativeTypeName("#define AMINTERLACE_DisplayModeWeaveOnly 0x00000040")]
    public const int AMINTERLACE_DisplayModeWeaveOnly = 0x00000040;
    [NativeTypeName("#define AMINTERLACE_DisplayModeBobOrWeave 0x00000080")]
    public const int AMINTERLACE_DisplayModeBobOrWeave = 0x00000080;
}