// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POWER_SESSION_ALLOW_EXTERNAL_DMA_DEVICES.xml' path='doc/member[@name="POWER_SESSION_ALLOW_EXTERNAL_DMA_DEVICES"]/*'/>
public partial struct POWER_SESSION_ALLOW_EXTERNAL_DMA_DEVICES
{
    /// <include file='POWER_SESSION_ALLOW_EXTERNAL_DMA_DEVICES.xml' path='doc/member[@name="POWER_SESSION_ALLOW_EXTERNAL_DMA_DEVICES.IsAllowed"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsAllowed;
}