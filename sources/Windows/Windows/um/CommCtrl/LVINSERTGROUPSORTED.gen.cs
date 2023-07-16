// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LVINSERTGROUPSORTED.xml' path='doc/member[@name="LVINSERTGROUPSORTED"]/*'/>
public unsafe partial struct LVINSERTGROUPSORTED
{
    /// <include file='LVINSERTGROUPSORTED.xml' path='doc/member[@name="LVINSERTGROUPSORTED.pfnGroupCompare"]/*'/>
    [NativeTypeName("PFNLVGROUPCOMPARE")]
    public delegate* unmanaged<int, int, void*, int> pfnGroupCompare;
    /// <include file='LVINSERTGROUPSORTED.xml' path='doc/member[@name="LVINSERTGROUPSORTED.pvData"]/*'/>
    public void* pvData;
    /// <include file='LVINSERTGROUPSORTED.xml' path='doc/member[@name="LVINSERTGROUPSORTED.lvGroup"]/*'/>
    public LVGROUP lvGroup;
}