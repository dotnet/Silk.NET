// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICRawParameterSet.xml' path='doc/member[@name="WICRawParameterSet"]/*'/>
public enum WICRawParameterSet
{
    /// <include file='WICRawParameterSet.xml' path='doc/member[@name="WICRawParameterSet.WICAsShotParameterSet"]/*'/>
    WICAsShotParameterSet = 0x1,
    /// <include file='WICRawParameterSet.xml' path='doc/member[@name="WICRawParameterSet.WICUserAdjustedParameterSet"]/*'/>
    WICUserAdjustedParameterSet = 0x2,
    /// <include file='WICRawParameterSet.xml' path='doc/member[@name="WICRawParameterSet.WICAutoAdjustedParameterSet"]/*'/>
    WICAutoAdjustedParameterSet = 0x3,
    /// <include file='WICRawParameterSet.xml' path='doc/member[@name="WICRawParameterSet.WICRAWPARAMETERSET_FORCE_DWORD"]/*'/>
    WICRAWPARAMETERSET_FORCE_DWORD = 0x7fffffff,
}