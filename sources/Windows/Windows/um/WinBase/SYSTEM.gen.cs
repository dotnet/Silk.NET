// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SYSTEM
{
    [NativeTypeName("#define SYSTEM_STATUS_FLAG_POWER_SAVING_ON 0x01")]
    public const int SYSTEM_STATUS_FLAG_POWER_SAVING_ON = 0x01;
}