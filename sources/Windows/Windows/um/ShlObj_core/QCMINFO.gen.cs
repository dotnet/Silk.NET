// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO"]/*' />
public unsafe partial struct QCMINFO
{
    /// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO.hmenu"]/*' />
    public HMENU hmenu;

    /// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO.indexMenu"]/*' />
    public uint indexMenu;

    /// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO.idCmdFirst"]/*' />
    public uint idCmdFirst;

    /// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO.idCmdLast"]/*' />
    public uint idCmdLast;

    /// <include file='QCMINFO.xml' path='doc/member[@name="QCMINFO.pIdMap"]/*' />
    [NativeTypeName("const QCMINFO_IDMAP *")]
    public QCMINFO_IDMAP* pIdMap;
}
