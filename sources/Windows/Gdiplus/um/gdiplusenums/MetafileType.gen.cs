// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='MetafileType.xml' path='doc/member[@name="MetafileType"]/*' />
public enum MetafileType
{
    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeInvalid"]/*' />
    MetafileTypeInvalid,

    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeWmf"]/*' />
    MetafileTypeWmf,

    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeWmfPlaceable"]/*' />
    MetafileTypeWmfPlaceable,

    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeEmf"]/*' />
    MetafileTypeEmf,

    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeEmfPlusOnly"]/*' />
    MetafileTypeEmfPlusOnly,

    /// <include file='MetafileType.xml' path='doc/member[@name="MetafileType.MetafileTypeEmfPlusDual"]/*' />
    MetafileTypeEmfPlusDual,
}
