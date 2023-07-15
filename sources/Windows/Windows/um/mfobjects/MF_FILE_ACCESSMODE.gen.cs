// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_FILE_ACCESSMODE.xml' path='doc/member[@name="MF_FILE_ACCESSMODE"]/*'/>
public enum MF_FILE_ACCESSMODE
{
    /// <include file='MF_FILE_ACCESSMODE.xml' path='doc/member[@name="MF_FILE_ACCESSMODE.MF_ACCESSMODE_READ"]/*'/>
    MF_ACCESSMODE_READ = 1,
    /// <include file='MF_FILE_ACCESSMODE.xml' path='doc/member[@name="MF_FILE_ACCESSMODE.MF_ACCESSMODE_WRITE"]/*'/>
    MF_ACCESSMODE_WRITE = 2,
    /// <include file='MF_FILE_ACCESSMODE.xml' path='doc/member[@name="MF_FILE_ACCESSMODE.MF_ACCESSMODE_READWRITE"]/*'/>
    MF_ACCESSMODE_READWRITE = 3,
}