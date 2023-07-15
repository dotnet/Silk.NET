// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS"]/*'/>
[Flags]
public enum FOLDERVIEWOPTIONS
{
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_DEFAULT"]/*'/>
    FVO_DEFAULT = 0,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_VISTALAYOUT"]/*'/>
    FVO_VISTALAYOUT = 0x1,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_CUSTOMPOSITION"]/*'/>
    FVO_CUSTOMPOSITION = 0x2,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_CUSTOMORDERING"]/*'/>
    FVO_CUSTOMORDERING = 0x4,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_SUPPORTHYPERLINKS"]/*'/>
    FVO_SUPPORTHYPERLINKS = 0x8,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_NOANIMATIONS"]/*'/>
    FVO_NOANIMATIONS = 0x10,
    /// <include file='FOLDERVIEWOPTIONS.xml' path='doc/member[@name="FOLDERVIEWOPTIONS.FVO_NOSCROLLTIPS"]/*'/>
    FVO_NOSCROLLTIPS = 0x20,
}