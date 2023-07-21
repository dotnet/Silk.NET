// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.WinRT;

/// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription"]/*' />
public unsafe partial struct MLOperatorKernelDescription
{
    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.domain"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* domain;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.minimumOperatorSetVersion"]/*' />
    [NativeTypeName("int32_t")]
    public int minimumOperatorSetVersion;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.executionType"]/*' />
    public MLOperatorExecutionType executionType;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.typeConstraints"]/*' />
    [NativeTypeName("const MLOperatorEdgeTypeConstraint *")]
    public MLOperatorEdgeTypeConstraint* typeConstraints;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.typeConstraintCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint typeConstraintCount;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.defaultAttributes"]/*' />
    [NativeTypeName("const MLOperatorAttributeNameValue *")]
    public MLOperatorAttributeNameValue* defaultAttributes;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.defaultAttributeCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint defaultAttributeCount;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.options"]/*' />
    public MLOperatorKernelOptions options;

    /// <include file='MLOperatorKernelDescription.xml' path='doc/member[@name="MLOperatorKernelDescription.executionOptions"]/*' />
    [NativeTypeName("uint32_t")]
    public uint executionOptions;
}
