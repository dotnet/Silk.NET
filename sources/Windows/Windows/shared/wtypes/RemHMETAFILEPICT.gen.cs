// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT"]/*' />
public unsafe partial struct RemHMETAFILEPICT
{
    /// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT.mm"]/*' />
    [NativeTypeName("LONG")]
    public int mm;

    /// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT.xExt"]/*' />
    [NativeTypeName("LONG")]
    public int xExt;

    /// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT.yExt"]/*' />
    [NativeTypeName("LONG")]
    public int yExt;

    /// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT.cbData"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbData;

    /// <include file='RemHMETAFILEPICT.xml' path='doc/member[@name="RemHMETAFILEPICT.data"]/*' />
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}
