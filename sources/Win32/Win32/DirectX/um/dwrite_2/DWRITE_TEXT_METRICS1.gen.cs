// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct DWRITE_TEXT_METRICS1 : DWRITE_TEXT_METRICS")]
[NativeInheritance("DWRITE_TEXT_METRICS")]
[SupportedOSPlatform("windows6.3")]
public partial struct DWRITE_TEXT_METRICS1
{
    public DWRITE_TEXT_METRICS Base;
    public float heightIncludingTrailingWhitespace;
}
