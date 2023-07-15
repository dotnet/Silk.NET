// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="eAVDecVideoSoftwareDeinterlaceMode"]/*'/>
public enum eAVDecVideoSoftwareDeinterlaceMode
{
    /// <include file='eAVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="eAVDecVideoSoftwareDeinterlaceMode.eAVDecVideoSoftwareDeinterlaceMode_NoDeinterlacing"]/*'/>
    eAVDecVideoSoftwareDeinterlaceMode_NoDeinterlacing = 0,
    /// <include file='eAVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="eAVDecVideoSoftwareDeinterlaceMode.eAVDecVideoSoftwareDeinterlaceMode_ProgressiveDeinterlacing"]/*'/>
    eAVDecVideoSoftwareDeinterlaceMode_ProgressiveDeinterlacing = 1,
    /// <include file='eAVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="eAVDecVideoSoftwareDeinterlaceMode.eAVDecVideoSoftwareDeinterlaceMode_BOBDeinterlacing"]/*'/>
    eAVDecVideoSoftwareDeinterlaceMode_BOBDeinterlacing = 2,
    /// <include file='eAVDecVideoSoftwareDeinterlaceMode.xml' path='doc/member[@name="eAVDecVideoSoftwareDeinterlaceMode.eAVDecVideoSoftwareDeinterlaceMode_SmartBOBDeinterlacing"]/*'/>
    eAVDecVideoSoftwareDeinterlaceMode_SmartBOBDeinterlacing = 3,
}