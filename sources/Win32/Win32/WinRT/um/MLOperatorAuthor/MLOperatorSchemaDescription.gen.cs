// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public unsafe partial struct MLOperatorSchemaDescription
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("int32_t")]
    public int operatorSetVersionAtLastChange;

    [NativeTypeName("const MLOperatorSchemaEdgeDescription *")]
    public MLOperatorSchemaEdgeDescription* inputs;

    [NativeTypeName("uint32_t")]
    public uint inputCount;

    [NativeTypeName("const MLOperatorSchemaEdgeDescription *")]
    public MLOperatorSchemaEdgeDescription* outputs;

    [NativeTypeName("uint32_t")]
    public uint outputCount;

    [NativeTypeName("const MLOperatorEdgeTypeConstraint *")]
    public MLOperatorEdgeTypeConstraint* typeConstraints;

    [NativeTypeName("uint32_t")]
    public uint typeConstraintCount;

    [NativeTypeName("const MLOperatorAttribute *")]
    public MLOperatorAttribute* attributes;

    [NativeTypeName("uint32_t")]
    public uint attributeCount;

    [NativeTypeName("const MLOperatorAttributeNameValue *")]
    public MLOperatorAttributeNameValue* defaultAttributes;

    [NativeTypeName("uint32_t")]
    public uint defaultAttributeCount;
}
