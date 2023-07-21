// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern"]/*' />
public unsafe partial struct WICBitmapPattern
{
    /// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern.Position"]/*' />
    public ULARGE_INTEGER Position;

    /// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern.Pattern"]/*' />
    public byte* Pattern;

    /// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern.Mask"]/*' />
    public byte* Mask;

    /// <include file='WICBitmapPattern.xml' path='doc/member[@name="WICBitmapPattern.EndOfStream"]/*' />
    public BOOL EndOfStream;
}
