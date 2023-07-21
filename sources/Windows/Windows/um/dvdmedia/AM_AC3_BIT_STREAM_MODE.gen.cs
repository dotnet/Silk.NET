// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_AC3_BIT_STREAM_MODE.xml' path='doc/member[@name="AM_AC3_BIT_STREAM_MODE"]/*' />
public partial struct AM_AC3_BIT_STREAM_MODE
{
    /// <include file='AM_AC3_BIT_STREAM_MODE.xml' path='doc/member[@name="AM_AC3_BIT_STREAM_MODE.BitStreamMode"]/*' />
    [NativeTypeName("LONG")]
    public int BitStreamMode;
}
