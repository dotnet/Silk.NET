// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO"]/*'/>
public unsafe partial struct DESKBANDINFO
{
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.ptMinSize"]/*'/>
    public POINTL ptMinSize;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.ptMaxSize"]/*'/>
    public POINTL ptMaxSize;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.ptIntegral"]/*'/>
    public POINTL ptIntegral;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.ptActual"]/*'/>
    public POINTL ptActual;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.wszTitle"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort wszTitle[256];
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.dwModeFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwModeFlags;
    /// <include file='DESKBANDINFO.xml' path='doc/member[@name="DESKBANDINFO.crBkgnd"]/*'/>
    public COLORREF crBkgnd;
}