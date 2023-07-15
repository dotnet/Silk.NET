// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE"]/*'/>
public enum ACTIVATIONTYPE
{
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_UNCATEGORIZED"]/*'/>
    ACTIVATIONTYPE_UNCATEGORIZED = 0,
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_MONIKER"]/*'/>
    ACTIVATIONTYPE_FROM_MONIKER = 0x1,
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_DATA"]/*'/>
    ACTIVATIONTYPE_FROM_DATA = 0x2,
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_STORAGE"]/*'/>
    ACTIVATIONTYPE_FROM_STORAGE = 0x4,
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_STREAM"]/*'/>
    ACTIVATIONTYPE_FROM_STREAM = 0x8,
    /// <include file='ACTIVATIONTYPE.xml' path='doc/member[@name="ACTIVATIONTYPE.ACTIVATIONTYPE_FROM_FILE"]/*'/>
    ACTIVATIONTYPE_FROM_FILE = 0x10,
}