// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO"]/*' />
public partial struct FDICABINETINFO
{
    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.cbCabinet"]/*' />
    [NativeTypeName("long")]
    public int cbCabinet;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.cFolders"]/*' />
    public ushort cFolders;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.cFiles"]/*' />
    public ushort cFiles;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.setID"]/*' />
    public ushort setID;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.iCabinet"]/*' />
    public ushort iCabinet;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.fReserve"]/*' />
    public BOOL fReserve;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.hasprev"]/*' />
    public BOOL hasprev;

    /// <include file='FDICABINETINFO.xml' path='doc/member[@name="FDICABINETINFO.hasnext"]/*' />
    public BOOL hasnext;
}
