// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE"]/*' />
public enum KTMOBJECT_TYPE
{
    /// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE.KTMOBJECT_TRANSACTION"]/*' />
    KTMOBJECT_TRANSACTION,

    /// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE.KTMOBJECT_TRANSACTION_MANAGER"]/*' />
    KTMOBJECT_TRANSACTION_MANAGER,

    /// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE.KTMOBJECT_RESOURCE_MANAGER"]/*' />
    KTMOBJECT_RESOURCE_MANAGER,

    /// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE.KTMOBJECT_ENLISTMENT"]/*' />
    KTMOBJECT_ENLISTMENT,

    /// <include file='KTMOBJECT_TYPE.xml' path='doc/member[@name="KTMOBJECT_TYPE.KTMOBJECT_INVALID"]/*' />
    KTMOBJECT_INVALID,
}
