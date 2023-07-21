// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS"]/*' />
[Flags]
public enum DATAOBJ_GET_ITEM_FLAGS
{
    /// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS.DOGIF_DEFAULT"]/*' />
    DOGIF_DEFAULT = 0,

    /// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS.DOGIF_TRAVERSE_LINK"]/*' />
    DOGIF_TRAVERSE_LINK = 0x1,

    /// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS.DOGIF_NO_HDROP"]/*' />
    DOGIF_NO_HDROP = 0x2,

    /// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS.DOGIF_NO_URL"]/*' />
    DOGIF_NO_URL = 0x4,

    /// <include file='DATAOBJ_GET_ITEM_FLAGS.xml' path='doc/member[@name="DATAOBJ_GET_ITEM_FLAGS.DOGIF_ONLY_IF_ONE"]/*' />
    DOGIF_ONLY_IF_ONE = 0x8,
}
