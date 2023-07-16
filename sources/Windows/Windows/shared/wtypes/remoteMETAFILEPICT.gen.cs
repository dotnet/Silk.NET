// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='remoteMETAFILEPICT.xml' path='doc/member[@name="remoteMETAFILEPICT"]/*'/>
public unsafe partial struct remoteMETAFILEPICT
{
    /// <include file='remoteMETAFILEPICT.xml' path='doc/member[@name="remoteMETAFILEPICT.mm"]/*'/>
    [NativeTypeName("LONG")]
    public int mm;
    /// <include file='remoteMETAFILEPICT.xml' path='doc/member[@name="remoteMETAFILEPICT.xExt"]/*'/>
    [NativeTypeName("LONG")]
    public int xExt;
    /// <include file='remoteMETAFILEPICT.xml' path='doc/member[@name="remoteMETAFILEPICT.yExt"]/*'/>
    [NativeTypeName("LONG")]
    public int yExt;
    /// <include file='remoteMETAFILEPICT.xml' path='doc/member[@name="remoteMETAFILEPICT.hMF"]/*'/>
    public userHMETAFILE* hMF;
}