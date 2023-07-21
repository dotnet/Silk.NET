// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MIXER
{
    [NativeTypeName("#define MIXER_SHORT_NAME_CHARS 16")]
    public const int MIXER_SHORT_NAME_CHARS = 16;

    [NativeTypeName("#define MIXER_LONG_NAME_CHARS 64")]
    public const int MIXER_LONG_NAME_CHARS = 64;

    [NativeTypeName("#define MIXER_OBJECTF_HANDLE 0x80000000L")]
    public const uint MIXER_OBJECTF_HANDLE = 0x80000000;

    [NativeTypeName("#define MIXER_OBJECTF_MIXER 0x00000000L")]
    public const int MIXER_OBJECTF_MIXER = 0x00000000;

    [NativeTypeName("#define MIXER_OBJECTF_HMIXER (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIXER)")]
    public const uint MIXER_OBJECTF_HMIXER = (0x80000000 | 0x00000000);

    [NativeTypeName("#define MIXER_OBJECTF_WAVEOUT 0x10000000L")]
    public const int MIXER_OBJECTF_WAVEOUT = 0x10000000;

    [NativeTypeName("#define MIXER_OBJECTF_HWAVEOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEOUT)")]
    public const uint MIXER_OBJECTF_HWAVEOUT = (0x80000000 | 0x10000000);

    [NativeTypeName("#define MIXER_OBJECTF_WAVEIN 0x20000000L")]
    public const int MIXER_OBJECTF_WAVEIN = 0x20000000;

    [NativeTypeName("#define MIXER_OBJECTF_HWAVEIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEIN)")]
    public const uint MIXER_OBJECTF_HWAVEIN = (0x80000000 | 0x20000000);

    [NativeTypeName("#define MIXER_OBJECTF_MIDIOUT 0x30000000L")]
    public const int MIXER_OBJECTF_MIDIOUT = 0x30000000;

    [NativeTypeName("#define MIXER_OBJECTF_HMIDIOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIOUT)")]
    public const uint MIXER_OBJECTF_HMIDIOUT = (0x80000000 | 0x30000000);

    [NativeTypeName("#define MIXER_OBJECTF_MIDIIN 0x40000000L")]
    public const int MIXER_OBJECTF_MIDIIN = 0x40000000;

    [NativeTypeName("#define MIXER_OBJECTF_HMIDIIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIIN)")]
    public const uint MIXER_OBJECTF_HMIDIIN = (0x80000000 | 0x40000000);

    [NativeTypeName("#define MIXER_OBJECTF_AUX 0x50000000L")]
    public const int MIXER_OBJECTF_AUX = 0x50000000;

    [NativeTypeName("#define MIXER_GETLINEINFOF_DESTINATION 0x00000000L")]
    public const int MIXER_GETLINEINFOF_DESTINATION = 0x00000000;

    [NativeTypeName("#define MIXER_GETLINEINFOF_SOURCE 0x00000001L")]
    public const int MIXER_GETLINEINFOF_SOURCE = 0x00000001;

    [NativeTypeName("#define MIXER_GETLINEINFOF_LINEID 0x00000002L")]
    public const int MIXER_GETLINEINFOF_LINEID = 0x00000002;

    [NativeTypeName("#define MIXER_GETLINEINFOF_COMPONENTTYPE 0x00000003L")]
    public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 0x00000003;

    [NativeTypeName("#define MIXER_GETLINEINFOF_TARGETTYPE 0x00000004L")]
    public const int MIXER_GETLINEINFOF_TARGETTYPE = 0x00000004;

    [NativeTypeName("#define MIXER_GETLINEINFOF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETLINEINFOF_QUERYMASK = 0x0000000F;

    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ALL 0x00000000L")]
    public const int MIXER_GETLINECONTROLSF_ALL = 0x00000000;

    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYID 0x00000001L")]
    public const int MIXER_GETLINECONTROLSF_ONEBYID = 0x00000001;

    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYTYPE 0x00000002L")]
    public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 0x00000002;

    [NativeTypeName("#define MIXER_GETLINECONTROLSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETLINECONTROLSF_QUERYMASK = 0x0000000F;

    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_VALUE 0x00000000L")]
    public const int MIXER_GETCONTROLDETAILSF_VALUE = 0x00000000;

    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_LISTTEXT 0x00000001L")]
    public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 0x00000001;

    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 0x0000000F;

    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_VALUE 0x00000000L")]
    public const int MIXER_SETCONTROLDETAILSF_VALUE = 0x00000000;

    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_CUSTOM 0x00000001L")]
    public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 0x00000001;

    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 0x0000000F;
}
