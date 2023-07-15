// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='CPLINFO.xml' path='doc/member[@name="CPLINFO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CPLINFO
{
    /// <include file='CPLINFO.xml' path='doc/member[@name="CPLINFO.idIcon"]/*'/>
    public int idIcon;
    /// <include file='CPLINFO.xml' path='doc/member[@name="CPLINFO.idName"]/*'/>
    public int idName;
    /// <include file='CPLINFO.xml' path='doc/member[@name="CPLINFO.idInfo"]/*'/>
    public int idInfo;
    /// <include file='CPLINFO.xml' path='doc/member[@name="CPLINFO.lData"]/*'/>
    [NativeTypeName("LONG_PTR")]
    public nint lData;
}