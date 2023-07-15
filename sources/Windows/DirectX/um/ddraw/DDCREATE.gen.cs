// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDCREATE
{
    [NativeTypeName("#define DDCREATE_HARDWAREONLY 0x00000001l")]
    public const int DDCREATE_HARDWAREONLY = 0x00000001;
    [NativeTypeName("#define DDCREATE_EMULATIONONLY 0x00000002l")]
    public const int DDCREATE_EMULATIONONLY = 0x00000002;
}