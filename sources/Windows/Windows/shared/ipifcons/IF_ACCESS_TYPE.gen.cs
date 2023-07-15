// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE"]/*'/>
public enum IF_ACCESS_TYPE
{
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_LOOPBACK"]/*'/>
    IF_ACCESS_LOOPBACK = 1,
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_BROADCAST"]/*'/>
    IF_ACCESS_BROADCAST = 2,
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_POINT_TO_POINT"]/*'/>
    IF_ACCESS_POINT_TO_POINT = 3,
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_POINTTOPOINT"]/*'/>
    IF_ACCESS_POINTTOPOINT = 3,
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_POINT_TO_MULTI_POINT"]/*'/>
    IF_ACCESS_POINT_TO_MULTI_POINT = 4,
    /// <include file='IF_ACCESS_TYPE.xml' path='doc/member[@name="IF_ACCESS_TYPE.IF_ACCESS_POINTTOMULTIPOINT"]/*'/>
    IF_ACCESS_POINTTOMULTIPOINT = 4,
}