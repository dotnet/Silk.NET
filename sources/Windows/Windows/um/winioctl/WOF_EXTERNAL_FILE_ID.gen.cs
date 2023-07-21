// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WOF_EXTERNAL_FILE_ID.xml' path='doc/member[@name="WOF_EXTERNAL_FILE_ID"]/*' />
public partial struct WOF_EXTERNAL_FILE_ID
{
    /// <include file='WOF_EXTERNAL_FILE_ID.xml' path='doc/member[@name="WOF_EXTERNAL_FILE_ID.FileId"]/*' />
    public FILE_ID_128 FileId;
}
