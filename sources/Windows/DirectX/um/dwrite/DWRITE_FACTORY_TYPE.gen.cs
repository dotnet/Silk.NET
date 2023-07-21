// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_FACTORY_TYPE.xml' path='doc/member[@name="DWRITE_FACTORY_TYPE"]/*' />
public enum DWRITE_FACTORY_TYPE
{
    /// <include file='DWRITE_FACTORY_TYPE.xml' path='doc/member[@name="DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED"]/*' />
    DWRITE_FACTORY_TYPE_SHARED,

    /// <include file='DWRITE_FACTORY_TYPE.xml' path='doc/member[@name="DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_ISOLATED"]/*' />
    DWRITE_FACTORY_TYPE_ISOLATED,
}
