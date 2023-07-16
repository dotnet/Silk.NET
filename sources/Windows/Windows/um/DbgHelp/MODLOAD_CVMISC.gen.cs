// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC"]/*'/>
public partial struct MODLOAD_CVMISC
{
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.oCV"]/*'/>
    [NativeTypeName("DWORD")]
    public uint oCV;
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.cCV"]/*'/>
    [NativeTypeName("size_t")]
    public nuint cCV;
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.oMisc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint oMisc;
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.cMisc"]/*'/>
    [NativeTypeName("size_t")]
    public nuint cMisc;
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.dtImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dtImage;
    /// <include file='MODLOAD_CVMISC.xml' path='doc/member[@name="MODLOAD_CVMISC.cImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cImage;
}