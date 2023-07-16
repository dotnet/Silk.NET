// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.WinRT;
/// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription"]/*'/>
public unsafe partial struct MLOperatorSchemaDescription
{
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.name"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* name;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.operatorSetVersionAtLastChange"]/*'/>
    [NativeTypeName("int32_t")]
    public int operatorSetVersionAtLastChange;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.inputs"]/*'/>
    [NativeTypeName("const MLOperatorSchemaEdgeDescription *")]
    public MLOperatorSchemaEdgeDescription* inputs;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.inputCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint inputCount;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.outputs"]/*'/>
    [NativeTypeName("const MLOperatorSchemaEdgeDescription *")]
    public MLOperatorSchemaEdgeDescription* outputs;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.outputCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint outputCount;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.typeConstraints"]/*'/>
    [NativeTypeName("const MLOperatorEdgeTypeConstraint *")]
    public MLOperatorEdgeTypeConstraint* typeConstraints;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.typeConstraintCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint typeConstraintCount;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.attributes"]/*'/>
    [NativeTypeName("const MLOperatorAttribute *")]
    public MLOperatorAttribute* attributes;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.attributeCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint attributeCount;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.defaultAttributes"]/*'/>
    [NativeTypeName("const MLOperatorAttributeNameValue *")]
    public MLOperatorAttributeNameValue* defaultAttributes;
    /// <include file='MLOperatorSchemaDescription.xml' path='doc/member[@name="MLOperatorSchemaDescription.defaultAttributeCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint defaultAttributeCount;
}