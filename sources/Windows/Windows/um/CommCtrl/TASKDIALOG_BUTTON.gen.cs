// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TASKDIALOG_BUTTON.xml' path='doc/member[@name="TASKDIALOG_BUTTON"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct TASKDIALOG_BUTTON
{
    /// <include file='TASKDIALOG_BUTTON.xml' path='doc/member[@name="TASKDIALOG_BUTTON.nButtonID"]/*'/>
    public int nButtonID;
    /// <include file='TASKDIALOG_BUTTON.xml' path='doc/member[@name="TASKDIALOG_BUTTON.pszButtonText"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszButtonText;
}