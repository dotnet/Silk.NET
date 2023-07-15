// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES"]/*'/>
public enum SPCFGRULEATTRIBUTES
{
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_TopLevel"]/*'/>
    SPRAF_TopLevel = (1 << 0),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Active"]/*'/>
    SPRAF_Active = (1 << 1),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Export"]/*'/>
    SPRAF_Export = (1 << 2),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Import"]/*'/>
    SPRAF_Import = (1 << 3),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Interpreter"]/*'/>
    SPRAF_Interpreter = (1 << 4),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Dynamic"]/*'/>
    SPRAF_Dynamic = (1 << 5),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_Root"]/*'/>
    SPRAF_Root = (1 << 6),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_AutoPause"]/*'/>
    SPRAF_AutoPause = (1 << 16),
    /// <include file='SPCFGRULEATTRIBUTES.xml' path='doc/member[@name="SPCFGRULEATTRIBUTES.SPRAF_UserDelimited"]/*'/>
    SPRAF_UserDelimited = (1 << 17),
}