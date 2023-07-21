// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS"]/*' />
public unsafe partial struct HIDP_CAPS
{
    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.Usage"]/*' />
    [NativeTypeName("USAGE")]
    public ushort Usage;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.UsagePage"]/*' />
    [NativeTypeName("USAGE")]
    public ushort UsagePage;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.InputReportByteLength"]/*' />
    public ushort InputReportByteLength;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.OutputReportByteLength"]/*' />
    public ushort OutputReportByteLength;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.FeatureReportByteLength"]/*' />
    public ushort FeatureReportByteLength;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.Reserved"]/*' />
    [NativeTypeName("USHORT[17]")]
    public fixed ushort Reserved[17];

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberLinkCollectionNodes"]/*' />
    public ushort NumberLinkCollectionNodes;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberInputButtonCaps"]/*' />
    public ushort NumberInputButtonCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberInputValueCaps"]/*' />
    public ushort NumberInputValueCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberInputDataIndices"]/*' />
    public ushort NumberInputDataIndices;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberOutputButtonCaps"]/*' />
    public ushort NumberOutputButtonCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberOutputValueCaps"]/*' />
    public ushort NumberOutputValueCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberOutputDataIndices"]/*' />
    public ushort NumberOutputDataIndices;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberFeatureButtonCaps"]/*' />
    public ushort NumberFeatureButtonCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberFeatureValueCaps"]/*' />
    public ushort NumberFeatureValueCaps;

    /// <include file='HIDP_CAPS.xml' path='doc/member[@name="HIDP_CAPS.NumberFeatureDataIndices"]/*' />
    public ushort NumberFeatureDataIndices;
}
