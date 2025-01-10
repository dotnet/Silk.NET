// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class RESOURCEDISPLAYTYPE
{
    [NativeTypeName("#define RESOURCEDISPLAYTYPE_GENERIC 0x00000000")]
    public const int RESOURCEDISPLAYTYPE_GENERIC = 0x00000000;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_DOMAIN 0x00000001")]
    public const int RESOURCEDISPLAYTYPE_DOMAIN = 0x00000001;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SERVER 0x00000002")]
    public const int RESOURCEDISPLAYTYPE_SERVER = 0x00000002;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHARE 0x00000003")]
    public const int RESOURCEDISPLAYTYPE_SHARE = 0x00000003;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_FILE 0x00000004")]
    public const int RESOURCEDISPLAYTYPE_FILE = 0x00000004;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_GROUP 0x00000005")]
    public const int RESOURCEDISPLAYTYPE_GROUP = 0x00000005;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_NETWORK 0x00000006")]
    public const int RESOURCEDISPLAYTYPE_NETWORK = 0x00000006;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_ROOT 0x00000007")]
    public const int RESOURCEDISPLAYTYPE_ROOT = 0x00000007;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHAREADMIN 0x00000008")]
    public const int RESOURCEDISPLAYTYPE_SHAREADMIN = 0x00000008;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_DIRECTORY 0x00000009")]
    public const int RESOURCEDISPLAYTYPE_DIRECTORY = 0x00000009;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_TREE 0x0000000A")]
    public const int RESOURCEDISPLAYTYPE_TREE = 0x0000000A;

    [NativeTypeName("#define RESOURCEDISPLAYTYPE_NDSCONTAINER 0x0000000B")]
    public const int RESOURCEDISPLAYTYPE_NDSCONTAINER = 0x0000000B;
}
