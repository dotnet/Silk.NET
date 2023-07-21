// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TAPE_SET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_SET_MEDIA_PARAMETERS"]/*' />
public partial struct TAPE_SET_MEDIA_PARAMETERS
{
    /// <include file='TAPE_SET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_SET_MEDIA_PARAMETERS.BlockSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BlockSize;
}
