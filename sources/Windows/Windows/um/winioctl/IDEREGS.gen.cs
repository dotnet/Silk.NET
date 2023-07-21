// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS"]/*' />
public partial struct IDEREGS
{
    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bFeaturesReg"]/*' />
    public byte bFeaturesReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bSectorCountReg"]/*' />
    public byte bSectorCountReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bSectorNumberReg"]/*' />
    public byte bSectorNumberReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bCylLowReg"]/*' />
    public byte bCylLowReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bCylHighReg"]/*' />
    public byte bCylHighReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bDriveHeadReg"]/*' />
    public byte bDriveHeadReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bCommandReg"]/*' />
    public byte bCommandReg;

    /// <include file='IDEREGS.xml' path='doc/member[@name="IDEREGS.bReserved"]/*' />
    public byte bReserved;
}
