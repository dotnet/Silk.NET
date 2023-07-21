// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES"]/*' />
public partial struct WCS_DEVICE_MHC2_CAPABILITIES
{
    /// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES.Size"]/*' />
    public uint Size;

    /// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES.SupportsMhc2"]/*' />
    public BOOL SupportsMhc2;

    /// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES.RegammaLutEntryCount"]/*' />
    public uint RegammaLutEntryCount;

    /// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES.CscXyzMatrixRows"]/*' />
    public uint CscXyzMatrixRows;

    /// <include file='WCS_DEVICE_MHC2_CAPABILITIES.xml' path='doc/member[@name="WCS_DEVICE_MHC2_CAPABILITIES.CscXyzMatrixColumns"]/*' />
    public uint CscXyzMatrixColumns;
}
