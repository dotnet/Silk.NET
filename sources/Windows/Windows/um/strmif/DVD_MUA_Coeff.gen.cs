// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_MUA_Coeff.xml' path='doc/member[@name="DVD_MUA_Coeff"]/*' />
public partial struct DVD_MUA_Coeff
{
    /// <include file='DVD_MUA_Coeff.xml' path='doc/member[@name="DVD_MUA_Coeff.log2_alpha"]/*' />
    public double log2_alpha;

    /// <include file='DVD_MUA_Coeff.xml' path='doc/member[@name="DVD_MUA_Coeff.log2_beta"]/*' />
    public double log2_beta;
}
