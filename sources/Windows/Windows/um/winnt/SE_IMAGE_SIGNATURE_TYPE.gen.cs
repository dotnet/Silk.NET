// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE"]/*' />
public enum SE_IMAGE_SIGNATURE_TYPE
{
    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureNone"]/*' />
    SeImageSignatureNone = 0,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureEmbedded"]/*' />
    SeImageSignatureEmbedded,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureCache"]/*' />
    SeImageSignatureCache,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureCatalogCached"]/*' />
    SeImageSignatureCatalogCached,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureCatalogNotCached"]/*' />
    SeImageSignatureCatalogNotCached,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignatureCatalogHint"]/*' />
    SeImageSignatureCatalogHint,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignaturePackageCatalog"]/*' />
    SeImageSignaturePackageCatalog,

    /// <include file='SE_IMAGE_SIGNATURE_TYPE.xml' path='doc/member[@name="SE_IMAGE_SIGNATURE_TYPE.SeImageSignaturePplMitigated"]/*' />
    SeImageSignaturePplMitigated,
}
