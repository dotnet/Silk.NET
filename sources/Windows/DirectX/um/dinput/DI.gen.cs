// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;

namespace Silk.NET.Windows;

public static partial class DI
{
    [NativeTypeName("#define DI_DEGREES 100")]
    public const int DI_DEGREES = 100;

    [NativeTypeName("#define DI_FFNOMINALMAX 10000")]
    public const int DI_FFNOMINALMAX = 10000;

    [NativeTypeName("#define DI_SECONDS 1000000")]
    public const int DI_SECONDS = 1000000;

    [NativeTypeName("#define DI_OK S_OK")]
    public const int DI_OK = ((int)(0));

    [NativeTypeName("#define DI_NOTATTACHED S_FALSE")]
    public const int DI_NOTATTACHED = ((int)(1));

    [NativeTypeName("#define DI_BUFFEROVERFLOW S_FALSE")]
    public const int DI_BUFFEROVERFLOW = ((int)(1));

    [NativeTypeName("#define DI_PROPNOEFFECT S_FALSE")]
    public const int DI_PROPNOEFFECT = ((int)(1));

    [NativeTypeName("#define DI_NOEFFECT S_FALSE")]
    public const int DI_NOEFFECT = ((int)(1));

    [NativeTypeName("#define DI_POLLEDDEVICE ((HRESULT)0x00000002L)")]
    public const int DI_POLLEDDEVICE = ((int)(0x00000002));

    [NativeTypeName("#define DI_DOWNLOADSKIPPED ((HRESULT)0x00000003L)")]
    public const int DI_DOWNLOADSKIPPED = ((int)(0x00000003));

    [NativeTypeName("#define DI_EFFECTRESTARTED ((HRESULT)0x00000004L)")]
    public const int DI_EFFECTRESTARTED = ((int)(0x00000004));

    [NativeTypeName("#define DI_TRUNCATED ((HRESULT)0x00000008L)")]
    public const int DI_TRUNCATED = ((int)(0x00000008));

    [NativeTypeName("#define DI_SETTINGSNOTSAVED ((HRESULT)0x0000000BL)")]
    public const int DI_SETTINGSNOTSAVED = ((int)(0x0000000B));

    [NativeTypeName("#define DI_TRUNCATEDANDRESTARTED ((HRESULT)0x0000000CL)")]
    public const int DI_TRUNCATEDANDRESTARTED = ((int)(0x0000000C));

    [NativeTypeName("#define DI_WRITEPROTECT ((HRESULT)0x00000013L)")]
    public const int DI_WRITEPROTECT = ((int)(0x00000013));
}
