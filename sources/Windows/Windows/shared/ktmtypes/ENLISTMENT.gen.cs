// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ENLISTMENT
{
    [NativeTypeName("#define ENLISTMENT_SUPERIOR 0x00000001")]
    public const int ENLISTMENT_SUPERIOR = 0x00000001;
    [NativeTypeName("#define ENLISTMENT_MAXIMUM_OPTION 0x00000001")]
    public const int ENLISTMENT_MAXIMUM_OPTION = 0x00000001;
    [NativeTypeName("#define ENLISTMENT_OBJECT_PATH L\"\\\\Enlistment\\\\\"")]
    public const string ENLISTMENT_OBJECT_PATH = "\\Enlistment\\";
    [NativeTypeName("#define ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(ENLISTMENT_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
    public const uint ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES = (26 + (38 * 2));
}