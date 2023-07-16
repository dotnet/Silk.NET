// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DXGI
{
    [NativeTypeName("#define DXGI_CPU_ACCESS_NONE ( 0 )")]
    public const int DXGI_CPU_ACCESS_NONE = (0);
    [NativeTypeName("#define DXGI_CPU_ACCESS_DYNAMIC ( 1 )")]
    public const int DXGI_CPU_ACCESS_DYNAMIC = (1);
    [NativeTypeName("#define DXGI_CPU_ACCESS_READ_WRITE ( 2 )")]
    public const int DXGI_CPU_ACCESS_READ_WRITE = (2);
    [NativeTypeName("#define DXGI_CPU_ACCESS_SCRATCH ( 3 )")]
    public const int DXGI_CPU_ACCESS_SCRATCH = (3);
    [NativeTypeName("#define DXGI_CPU_ACCESS_FIELD 15")]
    public const int DXGI_CPU_ACCESS_FIELD = 15;
}