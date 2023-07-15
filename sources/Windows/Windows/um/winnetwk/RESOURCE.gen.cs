// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class RESOURCE
{
    [NativeTypeName("#define RESOURCE_CONNECTED 0x00000001")]
    public const int RESOURCE_CONNECTED = 0x00000001;
    [NativeTypeName("#define RESOURCE_GLOBALNET 0x00000002")]
    public const int RESOURCE_GLOBALNET = 0x00000002;
    [NativeTypeName("#define RESOURCE_REMEMBERED 0x00000003")]
    public const int RESOURCE_REMEMBERED = 0x00000003;
    [NativeTypeName("#define RESOURCE_RECENT 0x00000004")]
    public const int RESOURCE_RECENT = 0x00000004;
    [NativeTypeName("#define RESOURCE_CONTEXT 0x00000005")]
    public const int RESOURCE_CONTEXT = 0x00000005;
}