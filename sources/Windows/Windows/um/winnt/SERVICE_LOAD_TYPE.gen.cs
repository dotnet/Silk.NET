// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE"]/*'/>
public enum SERVICE_LOAD_TYPE
{
    /// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE.BootLoad"]/*'/>
    BootLoad = 0x00000000,
    /// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE.SystemLoad"]/*'/>
    SystemLoad = 0x00000001,
    /// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE.AutoLoad"]/*'/>
    AutoLoad = 0x00000002,
    /// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE.DemandLoad"]/*'/>
    DemandLoad = 0x00000003,
    /// <include file='SERVICE_LOAD_TYPE.xml' path='doc/member[@name="SERVICE_LOAD_TYPE.DisableLoad"]/*'/>
    DisableLoad = 0x00000004,
}