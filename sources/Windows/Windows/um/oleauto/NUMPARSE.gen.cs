// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE"]/*' />
public partial struct NUMPARSE
{
    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.cDig"]/*' />
    public int cDig;

    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.dwInFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwInFlags;

    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.dwOutFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwOutFlags;

    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.cchUsed"]/*' />
    public int cchUsed;

    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.nBaseShift"]/*' />
    public int nBaseShift;

    /// <include file='NUMPARSE.xml' path='doc/member[@name="NUMPARSE.nPwr10"]/*' />
    public int nPwr10;
}
