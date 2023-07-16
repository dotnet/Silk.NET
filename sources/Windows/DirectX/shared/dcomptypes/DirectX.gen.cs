// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DirectX
{
    [NativeTypeName("#define COMPOSITIONOBJECT_READ 0x0001L")]
    public const int COMPOSITIONOBJECT_READ = 0x0001;
    [NativeTypeName("#define COMPOSITIONOBJECT_WRITE 0x0002L")]
    public const int COMPOSITIONOBJECT_WRITE = 0x0002;
    [NativeTypeName("#define COMPOSITIONOBJECT_ALL_ACCESS (COMPOSITIONOBJECT_READ | COMPOSITIONOBJECT_WRITE)")]
    public const int COMPOSITIONOBJECT_ALL_ACCESS = (0x0001 | 0x0002);
    [NativeTypeName("#define COMPOSITION_STATS_MAX_TARGETS 256")]
    public const int COMPOSITION_STATS_MAX_TARGETS = 256;
}