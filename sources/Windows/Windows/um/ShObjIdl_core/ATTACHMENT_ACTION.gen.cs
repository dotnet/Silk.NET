// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ATTACHMENT_ACTION.xml' path='doc/member[@name="ATTACHMENT_ACTION"]/*'/>
public enum ATTACHMENT_ACTION
{
    /// <include file='ATTACHMENT_ACTION.xml' path='doc/member[@name="ATTACHMENT_ACTION.ATTACHMENT_ACTION_CANCEL"]/*'/>
    ATTACHMENT_ACTION_CANCEL = 0,
    /// <include file='ATTACHMENT_ACTION.xml' path='doc/member[@name="ATTACHMENT_ACTION.ATTACHMENT_ACTION_SAVE"]/*'/>
    ATTACHMENT_ACTION_SAVE = 0x1,
    /// <include file='ATTACHMENT_ACTION.xml' path='doc/member[@name="ATTACHMENT_ACTION.ATTACHMENT_ACTION_EXEC"]/*'/>
    ATTACHMENT_ACTION_EXEC = 0x2,
}