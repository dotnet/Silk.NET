// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class VK
{
    [NativeTypeName("#define VK_PAD_A 0x5800")]
    public const int VK_PAD_A = 0x5800;

    [NativeTypeName("#define VK_PAD_B 0x5801")]
    public const int VK_PAD_B = 0x5801;

    [NativeTypeName("#define VK_PAD_X 0x5802")]
    public const int VK_PAD_X = 0x5802;

    [NativeTypeName("#define VK_PAD_Y 0x5803")]
    public const int VK_PAD_Y = 0x5803;

    [NativeTypeName("#define VK_PAD_RSHOULDER 0x5804")]
    public const int VK_PAD_RSHOULDER = 0x5804;

    [NativeTypeName("#define VK_PAD_LSHOULDER 0x5805")]
    public const int VK_PAD_LSHOULDER = 0x5805;

    [NativeTypeName("#define VK_PAD_LTRIGGER 0x5806")]
    public const int VK_PAD_LTRIGGER = 0x5806;

    [NativeTypeName("#define VK_PAD_RTRIGGER 0x5807")]
    public const int VK_PAD_RTRIGGER = 0x5807;

    [NativeTypeName("#define VK_PAD_DPAD_UP 0x5810")]
    public const int VK_PAD_DPAD_UP = 0x5810;

    [NativeTypeName("#define VK_PAD_DPAD_DOWN 0x5811")]
    public const int VK_PAD_DPAD_DOWN = 0x5811;

    [NativeTypeName("#define VK_PAD_DPAD_LEFT 0x5812")]
    public const int VK_PAD_DPAD_LEFT = 0x5812;

    [NativeTypeName("#define VK_PAD_DPAD_RIGHT 0x5813")]
    public const int VK_PAD_DPAD_RIGHT = 0x5813;

    [NativeTypeName("#define VK_PAD_START 0x5814")]
    public const int VK_PAD_START = 0x5814;

    [NativeTypeName("#define VK_PAD_BACK 0x5815")]
    public const int VK_PAD_BACK = 0x5815;

    [NativeTypeName("#define VK_PAD_LTHUMB_PRESS 0x5816")]
    public const int VK_PAD_LTHUMB_PRESS = 0x5816;

    [NativeTypeName("#define VK_PAD_RTHUMB_PRESS 0x5817")]
    public const int VK_PAD_RTHUMB_PRESS = 0x5817;

    [NativeTypeName("#define VK_PAD_LTHUMB_UP 0x5820")]
    public const int VK_PAD_LTHUMB_UP = 0x5820;

    [NativeTypeName("#define VK_PAD_LTHUMB_DOWN 0x5821")]
    public const int VK_PAD_LTHUMB_DOWN = 0x5821;

    [NativeTypeName("#define VK_PAD_LTHUMB_RIGHT 0x5822")]
    public const int VK_PAD_LTHUMB_RIGHT = 0x5822;

    [NativeTypeName("#define VK_PAD_LTHUMB_LEFT 0x5823")]
    public const int VK_PAD_LTHUMB_LEFT = 0x5823;

    [NativeTypeName("#define VK_PAD_LTHUMB_UPLEFT 0x5824")]
    public const int VK_PAD_LTHUMB_UPLEFT = 0x5824;

    [NativeTypeName("#define VK_PAD_LTHUMB_UPRIGHT 0x5825")]
    public const int VK_PAD_LTHUMB_UPRIGHT = 0x5825;

    [NativeTypeName("#define VK_PAD_LTHUMB_DOWNRIGHT 0x5826")]
    public const int VK_PAD_LTHUMB_DOWNRIGHT = 0x5826;

    [NativeTypeName("#define VK_PAD_LTHUMB_DOWNLEFT 0x5827")]
    public const int VK_PAD_LTHUMB_DOWNLEFT = 0x5827;

    [NativeTypeName("#define VK_PAD_RTHUMB_UP 0x5830")]
    public const int VK_PAD_RTHUMB_UP = 0x5830;

    [NativeTypeName("#define VK_PAD_RTHUMB_DOWN 0x5831")]
    public const int VK_PAD_RTHUMB_DOWN = 0x5831;

    [NativeTypeName("#define VK_PAD_RTHUMB_RIGHT 0x5832")]
    public const int VK_PAD_RTHUMB_RIGHT = 0x5832;

    [NativeTypeName("#define VK_PAD_RTHUMB_LEFT 0x5833")]
    public const int VK_PAD_RTHUMB_LEFT = 0x5833;

    [NativeTypeName("#define VK_PAD_RTHUMB_UPLEFT 0x5834")]
    public const int VK_PAD_RTHUMB_UPLEFT = 0x5834;

    [NativeTypeName("#define VK_PAD_RTHUMB_UPRIGHT 0x5835")]
    public const int VK_PAD_RTHUMB_UPRIGHT = 0x5835;

    [NativeTypeName("#define VK_PAD_RTHUMB_DOWNRIGHT 0x5836")]
    public const int VK_PAD_RTHUMB_DOWNRIGHT = 0x5836;

    [NativeTypeName("#define VK_PAD_RTHUMB_DOWNLEFT 0x5837")]
    public const int VK_PAD_RTHUMB_DOWNLEFT = 0x5837;
}
