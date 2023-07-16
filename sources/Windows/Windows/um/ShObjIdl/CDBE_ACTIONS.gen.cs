// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CDBE_ACTIONS.xml' path='doc/member[@name="CDBE_ACTIONS"]/*'/>
public enum CDBE_ACTIONS
{
    /// <include file='CDBE_ACTIONS.xml' path='doc/member[@name="CDBE_ACTIONS.CDBE_TYPE_MUSIC"]/*'/>
    CDBE_TYPE_MUSIC = 0x1,
    /// <include file='CDBE_ACTIONS.xml' path='doc/member[@name="CDBE_ACTIONS.CDBE_TYPE_DATA"]/*'/>
    CDBE_TYPE_DATA = 0x2,
    /// <include file='CDBE_ACTIONS.xml' path='doc/member[@name="CDBE_ACTIONS.CDBE_TYPE_ALL"]/*'/>
    CDBE_TYPE_ALL = unchecked((int)(0xffffffff)),
}