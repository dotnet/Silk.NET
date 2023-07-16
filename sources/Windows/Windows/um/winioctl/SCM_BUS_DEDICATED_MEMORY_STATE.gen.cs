// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_BUS_DEDICATED_MEMORY_STATE.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_STATE"]/*'/>
public partial struct SCM_BUS_DEDICATED_MEMORY_STATE
{
    /// <include file='SCM_BUS_DEDICATED_MEMORY_STATE.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_STATE.ActivateState"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ActivateState;
}