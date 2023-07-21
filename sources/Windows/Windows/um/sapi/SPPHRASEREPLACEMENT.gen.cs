// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPPHRASEREPLACEMENT.xml' path='doc/member[@name="SPPHRASEREPLACEMENT"]/*' />
public unsafe partial struct SPPHRASEREPLACEMENT
{
    /// <include file='SPPHRASEREPLACEMENT.xml' path='doc/member[@name="SPPHRASEREPLACEMENT.bDisplayAttributes"]/*' />
    public byte bDisplayAttributes;

    /// <include file='SPPHRASEREPLACEMENT.xml' path='doc/member[@name="SPPHRASEREPLACEMENT.pszReplacementText"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszReplacementText;

    /// <include file='SPPHRASEREPLACEMENT.xml' path='doc/member[@name="SPPHRASEREPLACEMENT.ulFirstElement"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulFirstElement;

    /// <include file='SPPHRASEREPLACEMENT.xml' path='doc/member[@name="SPPHRASEREPLACEMENT.ulCountOfElements"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCountOfElements;
}
