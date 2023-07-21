// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='EncoderParameter.xml' path='doc/member[@name="EncoderParameter"]/*' />
public unsafe partial struct EncoderParameter
{
    /// <include file='EncoderParameter.xml' path='doc/member[@name="EncoderParameter.Guid"]/*' />
    public Guid Guid;

    /// <include file='EncoderParameter.xml' path='doc/member[@name="EncoderParameter.NumberOfValues"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfValues;

    /// <include file='EncoderParameter.xml' path='doc/member[@name="EncoderParameter.Type"]/*' />
    [NativeTypeName("ULONG")]
    public uint Type;

    /// <include file='EncoderParameter.xml' path='doc/member[@name="EncoderParameter.Value"]/*' />
    public void* Value;
}
