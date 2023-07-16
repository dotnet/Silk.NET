// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='STORAGE_PROVIDER_FILE_FLAGS.xml' path='doc/member[@name="STORAGE_PROVIDER_FILE_FLAGS"]/*'/>
[Flags]
public enum STORAGE_PROVIDER_FILE_FLAGS
{
    /// <include file='STORAGE_PROVIDER_FILE_FLAGS.xml' path='doc/member[@name="STORAGE_PROVIDER_FILE_FLAGS.SPFF_NONE"]/*'/>
    SPFF_NONE = 0,
    /// <include file='STORAGE_PROVIDER_FILE_FLAGS.xml' path='doc/member[@name="STORAGE_PROVIDER_FILE_FLAGS.SPFF_DOWNLOAD_BY_DEFAULT"]/*'/>
    SPFF_DOWNLOAD_BY_DEFAULT = 0x1,
    /// <include file='STORAGE_PROVIDER_FILE_FLAGS.xml' path='doc/member[@name="STORAGE_PROVIDER_FILE_FLAGS.SPFF_CREATED_ON_THIS_DEVICE"]/*'/>
    SPFF_CREATED_ON_THIS_DEVICE = 0x2,
}