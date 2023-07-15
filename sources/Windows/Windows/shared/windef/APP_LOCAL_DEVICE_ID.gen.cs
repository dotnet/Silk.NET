// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='APP_LOCAL_DEVICE_ID.xml' path='doc/member[@name="APP_LOCAL_DEVICE_ID"]/*'/>
public unsafe partial struct APP_LOCAL_DEVICE_ID
{
    /// <include file='APP_LOCAL_DEVICE_ID.xml' path='doc/member[@name="APP_LOCAL_DEVICE_ID.value"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte value[32];
}