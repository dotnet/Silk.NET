// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPVPRIORITY.xml' path='doc/member[@name="SPVPRIORITY"]/*'/>
public enum SPVPRIORITY
{
    /// <include file='SPVPRIORITY.xml' path='doc/member[@name="SPVPRIORITY.SPVPRI_NORMAL"]/*'/>
    SPVPRI_NORMAL = 0,
    /// <include file='SPVPRIORITY.xml' path='doc/member[@name="SPVPRIORITY.SPVPRI_ALERT"]/*'/>
    SPVPRI_ALERT = (1 << 0),
    /// <include file='SPVPRIORITY.xml' path='doc/member[@name="SPVPRIORITY.SPVPRI_OVER"]/*'/>
    SPVPRI_OVER = (1 << 1),
}