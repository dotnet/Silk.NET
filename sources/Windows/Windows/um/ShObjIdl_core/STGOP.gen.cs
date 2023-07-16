// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STGOP.xml' path='doc/member[@name="STGOP"]/*'/>
public enum STGOP
{
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_MOVE"]/*'/>
    STGOP_MOVE = 1,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_COPY"]/*'/>
    STGOP_COPY = 2,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_SYNC"]/*'/>
    STGOP_SYNC = 3,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_REMOVE"]/*'/>
    STGOP_REMOVE = 5,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_RENAME"]/*'/>
    STGOP_RENAME = 6,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_APPLYPROPERTIES"]/*'/>
    STGOP_APPLYPROPERTIES = 8,
    /// <include file='STGOP.xml' path='doc/member[@name="STGOP.STGOP_NEW"]/*'/>
    STGOP_NEW = 10,
}