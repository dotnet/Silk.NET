// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHChangeProductKeyAsIDList
{
    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.cb"]/*' />
    public ushort cb;

    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.wszProductKey"]/*' />
    [NativeTypeName("WCHAR[39]")]
    public fixed ushort wszProductKey[39];

    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.cbZero"]/*' />
    public ushort cbZero;
}
