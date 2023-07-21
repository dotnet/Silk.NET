// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE"]/*' />
public enum COLORDATATYPE
{
    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_BYTE"]/*' />
    COLOR_BYTE = 1,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_WORD"]/*' />
    COLOR_WORD,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_FLOAT"]/*' />
    COLOR_FLOAT,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_S2DOT13FIXED"]/*' />
    COLOR_S2DOT13FIXED,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_10b_R10G10B10A2"]/*' />
    COLOR_10b_R10G10B10A2,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_10b_R10G10B10A2_XR"]/*' />
    COLOR_10b_R10G10B10A2_XR,

    /// <include file='COLORDATATYPE.xml' path='doc/member[@name="COLORDATATYPE.COLOR_FLOAT16"]/*' />
    COLOR_FLOAT16,
}
