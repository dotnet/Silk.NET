// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS"]/*'/>
public enum IF_OPER_STATUS
{
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusUp"]/*'/>
    IfOperStatusUp = 1,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusDown"]/*'/>
    IfOperStatusDown,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusTesting"]/*'/>
    IfOperStatusTesting,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusUnknown"]/*'/>
    IfOperStatusUnknown,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusDormant"]/*'/>
    IfOperStatusDormant,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusNotPresent"]/*'/>
    IfOperStatusNotPresent,
    /// <include file='IF_OPER_STATUS.xml' path='doc/member[@name="IF_OPER_STATUS.IfOperStatusLowerLayerDown"]/*'/>
    IfOperStatusLowerLayerDown,
}