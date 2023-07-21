// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class DIDBAM
{
    [NativeTypeName("#define DIDBAM_DEFAULT 0x00000000")]
    public const int DIDBAM_DEFAULT = 0x00000000;

    [NativeTypeName("#define DIDBAM_PRESERVE 0x00000001")]
    public const int DIDBAM_PRESERVE = 0x00000001;

    [NativeTypeName("#define DIDBAM_INITIALIZE 0x00000002")]
    public const int DIDBAM_INITIALIZE = 0x00000002;

    [NativeTypeName("#define DIDBAM_HWDEFAULTS 0x00000004")]
    public const int DIDBAM_HWDEFAULTS = 0x00000004;
}
