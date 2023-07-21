// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICProgressOperation.xml' path='doc/member[@name="WICProgressOperation"]/*' />
public enum WICProgressOperation
{
    /// <include file='WICProgressOperation.xml' path='doc/member[@name="WICProgressOperation.WICProgressOperationCopyPixels"]/*' />
    WICProgressOperationCopyPixels = 0x1,

    /// <include file='WICProgressOperation.xml' path='doc/member[@name="WICProgressOperation.WICProgressOperationWritePixels"]/*' />
    WICProgressOperationWritePixels = 0x2,

    /// <include file='WICProgressOperation.xml' path='doc/member[@name="WICProgressOperation.WICProgressOperationAll"]/*' />
    WICProgressOperationAll = 0xffff,

    /// <include file='WICProgressOperation.xml' path='doc/member[@name="WICProgressOperation.WICPROGRESSOPERATION_FORCE_DWORD"]/*' />
    WICPROGRESSOPERATION_FORCE_DWORD = 0x7fffffff,
}
