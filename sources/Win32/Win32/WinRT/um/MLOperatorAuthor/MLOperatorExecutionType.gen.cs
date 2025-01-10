// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("uint32_t")]
public enum MLOperatorExecutionType : uint
{
    Undefined = 0,
    Cpu = 1,
    D3D12 = 2,
}
