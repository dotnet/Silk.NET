// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_BUS_SET_TYPE.xml' path='doc/member[@name="SCM_BUS_SET_TYPE"]/*'/>
public enum SCM_BUS_SET_TYPE
{
    /// <include file='SCM_BUS_SET_TYPE.xml' path='doc/member[@name="SCM_BUS_SET_TYPE.ScmBusSet_Descriptor"]/*'/>
    ScmBusSet_Descriptor = 0,
    /// <include file='SCM_BUS_SET_TYPE.xml' path='doc/member[@name="SCM_BUS_SET_TYPE.ScmBusSet_IsSupported"]/*'/>
    ScmBusSet_IsSupported,
    /// <include file='SCM_BUS_SET_TYPE.xml' path='doc/member[@name="SCM_BUS_SET_TYPE.ScmBusSet_Max"]/*'/>
    ScmBusSet_Max,
}