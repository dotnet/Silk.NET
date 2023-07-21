// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICJpegIndexingOptions.xml' path='doc/member[@name="WICJpegIndexingOptions"]/*' />
public enum WICJpegIndexingOptions
{
    /// <include file='WICJpegIndexingOptions.xml' path='doc/member[@name="WICJpegIndexingOptions.WICJpegIndexingOptionsGenerateOnDemand"]/*' />
    WICJpegIndexingOptionsGenerateOnDemand = 0,

    /// <include file='WICJpegIndexingOptions.xml' path='doc/member[@name="WICJpegIndexingOptions.WICJpegIndexingOptionsGenerateOnLoad"]/*' />
    WICJpegIndexingOptionsGenerateOnLoad = 0x1,

    /// <include file='WICJpegIndexingOptions.xml' path='doc/member[@name="WICJpegIndexingOptions.WICJpegIndexingOptions_FORCE_DWORD"]/*' />
    WICJpegIndexingOptions_FORCE_DWORD = 0x7fffffff,
}
