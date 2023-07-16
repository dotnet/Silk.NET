// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX"]/*'/>
public unsafe partial struct MFFOLDDOWN_MATRIX
{
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cbSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cbSize;
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cSrcChannels"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cSrcChannels;
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.cDstChannels"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cDstChannels;
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.dwChannelMask"]/*'/>
    [NativeTypeName("UINT32")]
    public uint dwChannelMask;
    /// <include file='MFFOLDDOWN_MATRIX.xml' path='doc/member[@name="MFFOLDDOWN_MATRIX.Coeff"]/*'/>
    [NativeTypeName("LONG[64]")]
    public fixed int Coeff[64];
}