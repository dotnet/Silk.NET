// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS"]/*'/>
public enum SCRIPTFLAGS
{
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_CACHEINFO"]/*'/>
    SCRIPTFLAGS_CACHEINFO = 0x00000001,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_SHORTCUTS"]/*'/>
    SCRIPTFLAGS_SHORTCUTS = 0x00000004,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_MACHINEASSIGN"]/*'/>
    SCRIPTFLAGS_MACHINEASSIGN = 0x00000008,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_REGDATA_CNFGINFO"]/*'/>
    SCRIPTFLAGS_REGDATA_CNFGINFO = 0x00000020,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_VALIDATE_TRANSFORMS_LIST"]/*'/>
    SCRIPTFLAGS_VALIDATE_TRANSFORMS_LIST = 0x00000040,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_REGDATA_CLASSINFO"]/*'/>
    SCRIPTFLAGS_REGDATA_CLASSINFO = 0x00000080,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_REGDATA_EXTENSIONINFO"]/*'/>
    SCRIPTFLAGS_REGDATA_EXTENSIONINFO = 0x00000100,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_REGDATA_APPINFO"]/*'/>
    SCRIPTFLAGS_REGDATA_APPINFO = SCRIPTFLAGS_REGDATA_CLASSINFO | SCRIPTFLAGS_REGDATA_EXTENSIONINFO,
    /// <include file='SCRIPTFLAGS.xml' path='doc/member[@name="SCRIPTFLAGS.SCRIPTFLAGS_REGDATA"]/*'/>
    SCRIPTFLAGS_REGDATA = SCRIPTFLAGS_REGDATA_APPINFO | SCRIPTFLAGS_REGDATA_CNFGINFO,
}