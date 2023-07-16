// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MERGE_UPDATE_STATUS.xml' path='doc/member[@name="MERGE_UPDATE_STATUS"]/*'/>
public enum MERGE_UPDATE_STATUS
{
    /// <include file='MERGE_UPDATE_STATUS.xml' path='doc/member[@name="MERGE_UPDATE_STATUS.MUS_COMPLETE"]/*'/>
    MUS_COMPLETE = 0,
    /// <include file='MERGE_UPDATE_STATUS.xml' path='doc/member[@name="MERGE_UPDATE_STATUS.MUS_USERINPUTNEEDED"]/*'/>
    MUS_USERINPUTNEEDED = (MUS_COMPLETE + 1),
    /// <include file='MERGE_UPDATE_STATUS.xml' path='doc/member[@name="MERGE_UPDATE_STATUS.MUS_FAILED"]/*'/>
    MUS_FAILED = (MUS_USERINPUTNEEDED + 1),
}