// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_TEXT_METRICS1.xml' path='doc/member[@name="DWRITE_TEXT_METRICS1"]/*'/>
[NativeTypeName("struct DWRITE_TEXT_METRICS1 : DWRITE_TEXT_METRICS")]
[NativeInheritance("DWRITE_TEXT_METRICS")]
[SupportedOSPlatform("windows6.3")]
public partial struct DWRITE_TEXT_METRICS1
{
    public DWRITE_TEXT_METRICS Base;
    /// <include file='DWRITE_TEXT_METRICS1.xml' path='doc/member[@name="DWRITE_TEXT_METRICS1.heightIncludingTrailingWhitespace"]/*'/>
    public float heightIncludingTrailingWhitespace;
}