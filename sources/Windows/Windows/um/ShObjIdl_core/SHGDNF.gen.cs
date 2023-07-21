// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF"]/*' />
public enum SHGDNF
{
    /// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF.SHGDN_NORMAL"]/*' />
    SHGDN_NORMAL = 0,

    /// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF.SHGDN_INFOLDER"]/*' />
    SHGDN_INFOLDER = 0x1,

    /// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF.SHGDN_FOREDITING"]/*' />
    SHGDN_FOREDITING = 0x1000,

    /// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF.SHGDN_FORADDRESSBAR"]/*' />
    SHGDN_FORADDRESSBAR = 0x4000,

    /// <include file='SHGDNF.xml' path='doc/member[@name="SHGDNF.SHGDN_FORPARSING"]/*' />
    SHGDN_FORPARSING = 0x8000,
}
