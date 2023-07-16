// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_MODULEW64_EX.xml' path='doc/member[@name="IMAGEHLP_MODULEW64_EX"]/*'/>
public partial struct IMAGEHLP_MODULEW64_EX
{
    /// <include file='IMAGEHLP_MODULEW64_EX.xml' path='doc/member[@name="IMAGEHLP_MODULEW64_EX.Module"]/*'/>
    public IMAGEHLP_MODULEW64 Module;
    /// <include file='IMAGEHLP_MODULEW64_EX.xml' path='doc/member[@name="IMAGEHLP_MODULEW64_EX.RegionFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RegionFlags;
}