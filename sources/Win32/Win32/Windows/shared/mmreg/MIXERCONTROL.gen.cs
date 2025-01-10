// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MIXERCONTROL
{
    [NativeTypeName(
        "#define MIXERCONTROL_CONTROLTYPE_SRS_MTS (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 6)"
    )]
    public const int MIXERCONTROL_CONTROLTYPE_SRS_MTS = (
        (0x20000000 | 0x00000000 | 0x00010000) + 6
    );

    [NativeTypeName(
        "#define MIXERCONTROL_CONTROLTYPE_SRS_ONOFF (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 7)"
    )]
    public const int MIXERCONTROL_CONTROLTYPE_SRS_ONOFF = (
        (0x20000000 | 0x00000000 | 0x00010000) + 7
    );

    [NativeTypeName(
        "#define MIXERCONTROL_CONTROLTYPE_SRS_SYNTHSELECT (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 8)"
    )]
    public const int MIXERCONTROL_CONTROLTYPE_SRS_SYNTHSELECT = (
        (0x20000000 | 0x00000000 | 0x00010000) + 8
    );
}
