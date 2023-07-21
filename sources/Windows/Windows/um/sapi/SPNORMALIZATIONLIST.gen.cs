// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPNORMALIZATIONLIST.xml' path='doc/member[@name="SPNORMALIZATIONLIST"]/*' />
public unsafe partial struct SPNORMALIZATIONLIST
{
    /// <include file='SPNORMALIZATIONLIST.xml' path='doc/member[@name="SPNORMALIZATIONLIST.ulSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSize;

    /// <include file='SPNORMALIZATIONLIST.xml' path='doc/member[@name="SPNORMALIZATIONLIST.ppszzNormalizedList"]/*' />
    [NativeTypeName("WCHAR **")]
    public ushort** ppszzNormalizedList;
}
