// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CHANGER_INITIALIZE_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_INITIALIZE_ELEMENT_STATUS"]/*'/>
public partial struct CHANGER_INITIALIZE_ELEMENT_STATUS
{
    /// <include file='CHANGER_INITIALIZE_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_INITIALIZE_ELEMENT_STATUS.ElementList"]/*'/>
    public CHANGER_ELEMENT_LIST ElementList;
    /// <include file='CHANGER_INITIALIZE_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_INITIALIZE_ELEMENT_STATUS.BarCodeScan"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BarCodeScan;
}