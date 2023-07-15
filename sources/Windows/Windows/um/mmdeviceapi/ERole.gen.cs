// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ERole.xml' path='doc/member[@name="ERole"]/*'/>
public enum ERole
{
    /// <include file='ERole.xml' path='doc/member[@name="ERole.eConsole"]/*'/>
    eConsole = 0,
    /// <include file='ERole.xml' path='doc/member[@name="ERole.eMultimedia"]/*'/>
    eMultimedia = (eConsole + 1),
    /// <include file='ERole.xml' path='doc/member[@name="ERole.eCommunications"]/*'/>
    eCommunications = (eMultimedia + 1),
    /// <include file='ERole.xml' path='doc/member[@name="ERole.ERole_enum_count"]/*'/>
    ERole_enum_count = (eCommunications + 1),
}