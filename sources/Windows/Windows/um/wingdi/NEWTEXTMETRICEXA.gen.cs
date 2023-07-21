// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NEWTEXTMETRICEXA.xml' path='doc/member[@name="NEWTEXTMETRICEXA"]/*' />
public partial struct NEWTEXTMETRICEXA
{
    /// <include file='NEWTEXTMETRICEXA.xml' path='doc/member[@name="NEWTEXTMETRICEXA.ntmTm"]/*' />
    public NEWTEXTMETRICA ntmTm;

    /// <include file='NEWTEXTMETRICEXA.xml' path='doc/member[@name="NEWTEXTMETRICEXA.ntmFontSig"]/*' />
    public FONTSIGNATURE ntmFontSig;
}
