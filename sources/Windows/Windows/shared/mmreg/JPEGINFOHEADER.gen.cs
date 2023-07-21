// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct JPEGINFOHEADER
{
    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGSize;

    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGProcess"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGProcess;

    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGColorSpaceID"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGColorSpaceID;

    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGBitsPerSample"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGBitsPerSample;

    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGHSubSampling"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGHSubSampling;

    /// <include file='JPEGINFOHEADER.xml' path='doc/member[@name="JPEGINFOHEADER.JPEGVSubSampling"]/*' />
    [NativeTypeName("DWORD")]
    public uint JPEGVSubSampling;
}
