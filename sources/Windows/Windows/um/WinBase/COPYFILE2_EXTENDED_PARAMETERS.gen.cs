// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS
{
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.dwCopyFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCopyFlags;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pfCancel"]/*'/>
    public BOOL* pfCancel;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pProgressRoutine"]/*'/>
    [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
    public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS.pvCallbackContext"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pvCallbackContext;
}