// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GET_LENGTH_INFORMATION.xml' path='doc/member[@name="GET_LENGTH_INFORMATION"]/*' />
public partial struct GET_LENGTH_INFORMATION
{
    /// <include file='GET_LENGTH_INFORMATION.xml' path='doc/member[@name="GET_LENGTH_INFORMATION.Length"]/*' />
    public LARGE_INTEGER Length;
}
