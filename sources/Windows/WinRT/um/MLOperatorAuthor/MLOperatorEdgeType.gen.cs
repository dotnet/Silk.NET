// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.WinRT;
/// <include file='MLOperatorEdgeType.xml' path='doc/member[@name="MLOperatorEdgeType"]/*'/>
[NativeTypeName("uint32_t")]
public enum MLOperatorEdgeType : uint
{
    /// <include file='MLOperatorEdgeType.xml' path='doc/member[@name="MLOperatorEdgeType.Undefined"]/*'/>
    Undefined = 0,
    /// <include file='MLOperatorEdgeType.xml' path='doc/member[@name="MLOperatorEdgeType.Tensor"]/*'/>
    Tensor = 1,
}