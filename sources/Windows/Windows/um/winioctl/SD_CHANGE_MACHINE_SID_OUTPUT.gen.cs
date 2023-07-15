// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT"]/*'/>
public partial struct SD_CHANGE_MACHINE_SID_OUTPUT
{
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumSDChangedSuccess"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDChangedSuccess;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumSDChangedFail"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDChangedFail;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumSDUnused"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDUnused;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumSDTotal"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumSDTotal;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumMftSDChangedSuccess"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumMftSDChangedSuccess;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumMftSDChangedFail"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumMftSDChangedFail;
    /// <include file='SD_CHANGE_MACHINE_SID_OUTPUT.xml' path='doc/member[@name="SD_CHANGE_MACHINE_SID_OUTPUT.NumMftSDTotal"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumMftSDTotal;
}