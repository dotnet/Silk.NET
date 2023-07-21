// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE"]/*' />
public enum SE_OBJECT_TYPE
{
    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_UNKNOWN_OBJECT_TYPE"]/*' />
    SE_UNKNOWN_OBJECT_TYPE = 0,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_FILE_OBJECT"]/*' />
    SE_FILE_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_SERVICE"]/*' />
    SE_SERVICE,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_PRINTER"]/*' />
    SE_PRINTER,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_REGISTRY_KEY"]/*' />
    SE_REGISTRY_KEY,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_LMSHARE"]/*' />
    SE_LMSHARE,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_KERNEL_OBJECT"]/*' />
    SE_KERNEL_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_WINDOW_OBJECT"]/*' />
    SE_WINDOW_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_DS_OBJECT"]/*' />
    SE_DS_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_DS_OBJECT_ALL"]/*' />
    SE_DS_OBJECT_ALL,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_PROVIDER_DEFINED_OBJECT"]/*' />
    SE_PROVIDER_DEFINED_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_WMIGUID_OBJECT"]/*' />
    SE_WMIGUID_OBJECT,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_REGISTRY_WOW64_32KEY"]/*' />
    SE_REGISTRY_WOW64_32KEY,

    /// <include file='SE_OBJECT_TYPE.xml' path='doc/member[@name="SE_OBJECT_TYPE.SE_REGISTRY_WOW64_64KEY"]/*' />
    SE_REGISTRY_WOW64_64KEY,
}
