// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/D2DErr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;
public static partial class FACILITY
{
    [NativeTypeName("#define FACILITY_D2D 0x899")]
    public const int FACILITY_D2D = 0x899;
}