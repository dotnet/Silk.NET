// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.WinRT;
/// <include file='MLOperatorEdgeTypeConstraint.xml' path='doc/member[@name="MLOperatorEdgeTypeConstraint"]/*'/>
public unsafe partial struct MLOperatorEdgeTypeConstraint
{
    /// <include file='MLOperatorEdgeTypeConstraint.xml' path='doc/member[@name="MLOperatorEdgeTypeConstraint.typeLabel"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* typeLabel;
    /// <include file='MLOperatorEdgeTypeConstraint.xml' path='doc/member[@name="MLOperatorEdgeTypeConstraint.allowedTypes"]/*'/>
    [NativeTypeName("const MLOperatorEdgeDescription *")]
    public MLOperatorEdgeDescription* allowedTypes;
    /// <include file='MLOperatorEdgeTypeConstraint.xml' path='doc/member[@name="MLOperatorEdgeTypeConstraint.allowedTypeCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint allowedTypeCount;
}