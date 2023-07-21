// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_INF_STRING_LENGTH 4096")]
    public const int MAX_INF_STRING_LENGTH = 4096;

    [NativeTypeName("#define MAX_INF_SECTION_NAME_LENGTH 255")]
    public const int MAX_INF_SECTION_NAME_LENGTH = 255;

    [NativeTypeName("#define MAX_TITLE_LEN 60")]
    public const int MAX_TITLE_LEN = 60;

    [NativeTypeName("#define MAX_INSTRUCTION_LEN 256")]
    public const int MAX_INSTRUCTION_LEN = 256;

    [NativeTypeName("#define MAX_LABEL_LEN 30")]
    public const int MAX_LABEL_LEN = 30;

    [NativeTypeName("#define MAX_SERVICE_NAME_LEN 256")]
    public const int MAX_SERVICE_NAME_LEN = 256;

    [NativeTypeName("#define MAX_SUBTITLE_LEN 256")]
    public const int MAX_SUBTITLE_LEN = 256;

    [NativeTypeName("#define MAX_INSTALLWIZARD_DYNAPAGES 20")]
    public const int MAX_INSTALLWIZARD_DYNAPAGES = 20;

    [NativeTypeName("#define MAX_IDD_DYNAWIZ_RESOURCE_ID 11000")]
    public const int MAX_IDD_DYNAWIZ_RESOURCE_ID = 11000;
}
