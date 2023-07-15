// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EmulationType.xml' path='doc/member[@name="EmulationType"]/*'/>
public enum EmulationType
{
    /// <include file='EmulationType.xml' path='doc/member[@name="EmulationType.EmulationNone"]/*'/>
    EmulationNone = 0,
    /// <include file='EmulationType.xml' path='doc/member[@name="EmulationType.Emulation12MFloppy"]/*'/>
    Emulation12MFloppy = 1,
    /// <include file='EmulationType.xml' path='doc/member[@name="EmulationType.Emulation144MFloppy"]/*'/>
    Emulation144MFloppy = 2,
    /// <include file='EmulationType.xml' path='doc/member[@name="EmulationType.Emulation288MFloppy"]/*'/>
    Emulation288MFloppy = 3,
    /// <include file='EmulationType.xml' path='doc/member[@name="EmulationType.EmulationHardDisk"]/*'/>
    EmulationHardDisk = 4,
}