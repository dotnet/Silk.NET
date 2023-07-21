// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DDRGBA.xml' path='doc/member[@name="DDRGBA"]/*' />
public partial struct DDRGBA
{
    /// <include file='DDRGBA.xml' path='doc/member[@name="DDRGBA.red"]/*' />
    public byte red;

    /// <include file='DDRGBA.xml' path='doc/member[@name="DDRGBA.green"]/*' />
    public byte green;

    /// <include file='DDRGBA.xml' path='doc/member[@name="DDRGBA.blue"]/*' />
    public byte blue;

    /// <include file='DDRGBA.xml' path='doc/member[@name="DDRGBA.alpha"]/*' />
    public byte alpha;
}
