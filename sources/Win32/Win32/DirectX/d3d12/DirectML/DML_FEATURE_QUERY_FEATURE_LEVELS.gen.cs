// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_FEATURE_QUERY_FEATURE_LEVELS
{
    public uint RequestedFeatureLevelCount;

    [NativeTypeName("const DML_FEATURE_LEVEL *")]
    public DML_FEATURE_LEVEL* RequestedFeatureLevels;
}
