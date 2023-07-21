// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GRADIENT_RECT.xml' path='doc/member[@name="GRADIENT_RECT"]/*' />
public partial struct GRADIENT_RECT
{
    /// <include file='GRADIENT_RECT.xml' path='doc/member[@name="GRADIENT_RECT.UpperLeft"]/*' />
    [NativeTypeName("ULONG")]
    public uint UpperLeft;

    /// <include file='GRADIENT_RECT.xml' path='doc/member[@name="GRADIENT_RECT.LowerRight"]/*' />
    [NativeTypeName("ULONG")]
    public uint LowerRight;
}
