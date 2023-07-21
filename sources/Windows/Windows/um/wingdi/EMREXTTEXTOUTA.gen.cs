// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA"]/*' />
public partial struct EMREXTTEXTOUTA
{
    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.iGraphicsMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint iGraphicsMode;

    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.exScale"]/*' />
    public float exScale;

    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.eyScale"]/*' />
    public float eyScale;

    /// <include file='EMREXTTEXTOUTA.xml' path='doc/member[@name="EMREXTTEXTOUTA.emrtext"]/*' />
    public EMRTEXT emrtext;
}
