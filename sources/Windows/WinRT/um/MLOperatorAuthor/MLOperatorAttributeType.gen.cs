// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.WinRT;
/// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType"]/*'/>
[NativeTypeName("uint32_t")]
public enum MLOperatorAttributeType : uint
{
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.Undefined"]/*'/>
    Undefined = 0,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.Float"]/*'/>
    Float = 2,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.Int"]/*'/>
    Int = 3,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.String"]/*'/>
    String = 4,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.FloatArray"]/*'/>
    FloatArray = 7,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.IntArray"]/*'/>
    IntArray = 8,
    /// <include file='MLOperatorAttributeType.xml' path='doc/member[@name="MLOperatorAttributeType.StringArray"]/*'/>
    StringArray = 9,
}