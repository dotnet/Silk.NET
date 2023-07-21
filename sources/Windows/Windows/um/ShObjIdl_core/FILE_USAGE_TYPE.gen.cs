// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_USAGE_TYPE.xml' path='doc/member[@name="FILE_USAGE_TYPE"]/*' />
public enum FILE_USAGE_TYPE
{
    /// <include file='FILE_USAGE_TYPE.xml' path='doc/member[@name="FILE_USAGE_TYPE.FUT_PLAYING"]/*' />
    FUT_PLAYING = 0,

    /// <include file='FILE_USAGE_TYPE.xml' path='doc/member[@name="FILE_USAGE_TYPE.FUT_EDITING"]/*' />
    FUT_EDITING = (FUT_PLAYING + 1),

    /// <include file='FILE_USAGE_TYPE.xml' path='doc/member[@name="FILE_USAGE_TYPE.FUT_GENERIC"]/*' />
    FUT_GENERIC = (FUT_EDITING + 1),
}
