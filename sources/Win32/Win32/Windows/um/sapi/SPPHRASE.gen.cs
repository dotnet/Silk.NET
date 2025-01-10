// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct SPPHRASE : SPPHRASE_53")]
[NativeInheritance("SPPHRASE_53")]
public partial struct SPPHRASE
{
    public SPPHRASE_53 Base;
    public SPSEMANTICFORMAT SemanticTagFormat;
}
