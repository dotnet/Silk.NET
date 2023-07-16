// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_BUS_QUERY_TYPE.xml' path='doc/member[@name="SCM_BUS_QUERY_TYPE"]/*'/>
public enum SCM_BUS_QUERY_TYPE
{
    /// <include file='SCM_BUS_QUERY_TYPE.xml' path='doc/member[@name="SCM_BUS_QUERY_TYPE.ScmBusQuery_Descriptor"]/*'/>
    ScmBusQuery_Descriptor = 0,
    /// <include file='SCM_BUS_QUERY_TYPE.xml' path='doc/member[@name="SCM_BUS_QUERY_TYPE.ScmBusQuery_IsSupported"]/*'/>
    ScmBusQuery_IsSupported,
    /// <include file='SCM_BUS_QUERY_TYPE.xml' path='doc/member[@name="SCM_BUS_QUERY_TYPE.ScmBusQuery_Max"]/*'/>
    ScmBusQuery_Max,
}