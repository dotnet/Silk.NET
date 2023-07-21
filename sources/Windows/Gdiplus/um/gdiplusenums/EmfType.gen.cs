// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Gdiplus.MetafileType;

namespace Silk.NET.Gdiplus;

/// <include file='EmfType.xml' path='doc/member[@name="EmfType"]/*' />
public enum EmfType
{
    /// <include file='EmfType.xml' path='doc/member[@name="EmfType.EmfTypeEmfOnly"]/*' />
    EmfTypeEmfOnly = MetafileTypeEmf,

    /// <include file='EmfType.xml' path='doc/member[@name="EmfType.EmfTypeEmfPlusOnly"]/*' />
    EmfTypeEmfPlusOnly = MetafileTypeEmfPlusOnly,

    /// <include file='EmfType.xml' path='doc/member[@name="EmfType.EmfTypeEmfPlusDual"]/*' />
    EmfTypeEmfPlusDual = MetafileTypeEmfPlusDual,
}
