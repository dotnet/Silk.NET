// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("uint32_t")]
public enum MLOperatorAttributeType : uint
{
    Undefined = 0,
    Float = 2,
    Int = 3,
    String = 4,
    FloatArray = 7,
    IntArray = 8,
    StringArray = 9,
}
