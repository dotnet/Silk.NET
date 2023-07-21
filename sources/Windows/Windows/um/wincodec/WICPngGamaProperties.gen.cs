// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPngGamaProperties.xml' path='doc/member[@name="WICPngGamaProperties"]/*' />
public enum WICPngGamaProperties
{
    /// <include file='WICPngGamaProperties.xml' path='doc/member[@name="WICPngGamaProperties.WICPngGamaGamma"]/*' />
    WICPngGamaGamma = 0x1,

    /// <include file='WICPngGamaProperties.xml' path='doc/member[@name="WICPngGamaProperties.WICPngGamaProperties_FORCE_DWORD"]/*' />
    WICPngGamaProperties_FORCE_DWORD = 0x7fffffff,
}
