// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DFMICS.xml' path='doc/member[@name="DFMICS"]/*'/>
public unsafe partial struct DFMICS
{
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.fMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fMask;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.idCmdFirst"]/*'/>
    public uint idCmdFirst;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.idDefMax"]/*'/>
    public uint idDefMax;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.pici"]/*'/>
    [NativeTypeName("LPCMINVOKECOMMANDINFO")]
    public CMINVOKECOMMANDINFO* pici;
    /// <include file='DFMICS.xml' path='doc/member[@name="DFMICS.punkSite"]/*'/>
    public IUnknown* punkSite;
}