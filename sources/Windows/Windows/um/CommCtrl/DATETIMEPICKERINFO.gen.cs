// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO"]/*'/>
public partial struct DATETIMEPICKERINFO
{
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.rcCheck"]/*'/>
    public RECT rcCheck;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.stateCheck"]/*'/>
    [NativeTypeName("DWORD")]
    public uint stateCheck;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.rcButton"]/*'/>
    public RECT rcButton;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.stateButton"]/*'/>
    [NativeTypeName("DWORD")]
    public uint stateButton;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.hwndEdit"]/*'/>
    public HWND hwndEdit;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.hwndUD"]/*'/>
    public HWND hwndUD;
    /// <include file='DATETIMEPICKERINFO.xml' path='doc/member[@name="DATETIMEPICKERINFO.hwndDropDown"]/*'/>
    public HWND hwndDropDown;
}