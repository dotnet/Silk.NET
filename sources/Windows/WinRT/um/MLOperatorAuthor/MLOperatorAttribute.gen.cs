// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.WinRT;

/// <include file='MLOperatorAttribute.xml' path='doc/member[@name="MLOperatorAttribute"]/*' />
public unsafe partial struct MLOperatorAttribute
{
    /// <include file='MLOperatorAttribute.xml' path='doc/member[@name="MLOperatorAttribute.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='MLOperatorAttribute.xml' path='doc/member[@name="MLOperatorAttribute.type"]/*' />
    public MLOperatorAttributeType type;

    /// <include file='MLOperatorAttribute.xml' path='doc/member[@name="MLOperatorAttribute.required"]/*' />
    [NativeTypeName("bool")]
    public byte required;
}
