// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF3DVideoOutputType.xml' path='doc/member[@name="MF3DVideoOutputType"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF3DVideoOutputType
{
    /// <include file='MF3DVideoOutputType.xml' path='doc/member[@name="MF3DVideoOutputType.MF3DVideoOutputType_BaseView"]/*'/>
    MF3DVideoOutputType_BaseView = 0,
    /// <include file='MF3DVideoOutputType.xml' path='doc/member[@name="MF3DVideoOutputType.MF3DVideoOutputType_Stereo"]/*'/>
    MF3DVideoOutputType_Stereo = 1,
}