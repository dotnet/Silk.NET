// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE"]/*' />
public unsafe partial struct SPPHRASERULE
{
    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.pszName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszName;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.ulId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulId;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.ulFirstElement"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulFirstElement;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.ulCountOfElements"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCountOfElements;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.pNextSibling"]/*' />
    [NativeTypeName("const SPPHRASERULE *")]
    public SPPHRASERULE* pNextSibling;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.pFirstChild"]/*' />
    [NativeTypeName("const SPPHRASERULE *")]
    public SPPHRASERULE* pFirstChild;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.SREngineConfidence"]/*' />
    public float SREngineConfidence;

    /// <include file='SPPHRASERULE.xml' path='doc/member[@name="SPPHRASERULE.Confidence"]/*' />
    [NativeTypeName("signed char")]
    public sbyte Confidence;
}
