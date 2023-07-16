// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='UNSIGNED_RATIO.xml' path='doc/member[@name="UNSIGNED_RATIO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct UNSIGNED_RATIO
{
    /// <include file='UNSIGNED_RATIO.xml' path='doc/member[@name="UNSIGNED_RATIO.uiNumerator"]/*'/>
    [NativeTypeName("UINT32")]
    public uint uiNumerator;
    /// <include file='UNSIGNED_RATIO.xml' path='doc/member[@name="UNSIGNED_RATIO.uiDenominator"]/*'/>
    [NativeTypeName("UINT32")]
    public uint uiDenominator;
}