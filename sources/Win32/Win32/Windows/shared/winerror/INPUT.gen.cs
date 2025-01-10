// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct INPUT
{
    [NativeTypeName("#define INPUT_E_OUT_OF_ORDER _HRESULT_TYPEDEF_(0x80400000L)")]
    public const int INPUT_E_OUT_OF_ORDER = unchecked((int)(0x80400000));

    [NativeTypeName("#define INPUT_E_REENTRANCY _HRESULT_TYPEDEF_(0x80400001L)")]
    public const int INPUT_E_REENTRANCY = unchecked((int)(0x80400001));

    [NativeTypeName("#define INPUT_E_MULTIMODAL _HRESULT_TYPEDEF_(0x80400002L)")]
    public const int INPUT_E_MULTIMODAL = unchecked((int)(0x80400002));

    [NativeTypeName("#define INPUT_E_PACKET _HRESULT_TYPEDEF_(0x80400003L)")]
    public const int INPUT_E_PACKET = unchecked((int)(0x80400003));

    [NativeTypeName("#define INPUT_E_FRAME _HRESULT_TYPEDEF_(0x80400004L)")]
    public const int INPUT_E_FRAME = unchecked((int)(0x80400004));

    [NativeTypeName("#define INPUT_E_HISTORY _HRESULT_TYPEDEF_(0x80400005L)")]
    public const int INPUT_E_HISTORY = unchecked((int)(0x80400005));

    [NativeTypeName("#define INPUT_E_DEVICE_INFO _HRESULT_TYPEDEF_(0x80400006L)")]
    public const int INPUT_E_DEVICE_INFO = unchecked((int)(0x80400006));

    [NativeTypeName("#define INPUT_E_TRANSFORM _HRESULT_TYPEDEF_(0x80400007L)")]
    public const int INPUT_E_TRANSFORM = unchecked((int)(0x80400007));

    [NativeTypeName("#define INPUT_E_DEVICE_PROPERTY _HRESULT_TYPEDEF_(0x80400008L)")]
    public const int INPUT_E_DEVICE_PROPERTY = unchecked((int)(0x80400008));
}
