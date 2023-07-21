// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO"]/*' />
public unsafe partial struct MSIFILEHASHINFO
{
    /// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO.dwFileHashInfoSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwFileHashInfoSize;

    /// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO.dwData"]/*' />
    [NativeTypeName("ULONG[4]")]
    public fixed uint dwData[4];
}
