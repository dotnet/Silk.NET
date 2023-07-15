// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STARTUPINFOEXA.xml' path='doc/member[@name="STARTUPINFOEXA"]/*'/>
public partial struct STARTUPINFOEXA
{
    /// <include file='STARTUPINFOEXA.xml' path='doc/member[@name="STARTUPINFOEXA.StartupInfo"]/*'/>
    public STARTUPINFOA StartupInfo;
    /// <include file='STARTUPINFOEXA.xml' path='doc/member[@name="STARTUPINFOEXA.lpAttributeList"]/*'/>
    public LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList;
}