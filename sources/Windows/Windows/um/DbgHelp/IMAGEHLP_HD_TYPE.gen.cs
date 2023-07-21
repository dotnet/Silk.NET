// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_HD_TYPE.xml' path='doc/member[@name="IMAGEHLP_HD_TYPE"]/*' />
public enum IMAGEHLP_HD_TYPE
{
    /// <include file='IMAGEHLP_HD_TYPE.xml' path='doc/member[@name="IMAGEHLP_HD_TYPE.hdBase"]/*' />
    hdBase = 0,

    /// <include file='IMAGEHLP_HD_TYPE.xml' path='doc/member[@name="IMAGEHLP_HD_TYPE.hdSym"]/*' />
    hdSym,

    /// <include file='IMAGEHLP_HD_TYPE.xml' path='doc/member[@name="IMAGEHLP_HD_TYPE.hdSrc"]/*' />
    hdSrc,

    /// <include file='IMAGEHLP_HD_TYPE.xml' path='doc/member[@name="IMAGEHLP_HD_TYPE.hdMax"]/*' />
    hdMax,
}
