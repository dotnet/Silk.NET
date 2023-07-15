// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE"]/*'/>
public enum STORAGE_BUS_TYPE
{
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeUnknown"]/*'/>
    BusTypeUnknown = 0x00,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeScsi"]/*'/>
    BusTypeScsi,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeAtapi"]/*'/>
    BusTypeAtapi,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeAta"]/*'/>
    BusTypeAta,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusType1394"]/*'/>
    BusType1394,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSsa"]/*'/>
    BusTypeSsa,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeFibre"]/*'/>
    BusTypeFibre,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeUsb"]/*'/>
    BusTypeUsb,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeRAID"]/*'/>
    BusTypeRAID,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeiScsi"]/*'/>
    BusTypeiScsi,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSas"]/*'/>
    BusTypeSas,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSata"]/*'/>
    BusTypeSata,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSd"]/*'/>
    BusTypeSd,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeMmc"]/*'/>
    BusTypeMmc,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeVirtual"]/*'/>
    BusTypeVirtual,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeFileBackedVirtual"]/*'/>
    BusTypeFileBackedVirtual,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSpaces"]/*'/>
    BusTypeSpaces,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeNvme"]/*'/>
    BusTypeNvme,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeSCM"]/*'/>
    BusTypeSCM,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeUfs"]/*'/>
    BusTypeUfs,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeMax"]/*'/>
    BusTypeMax,
    /// <include file='STORAGE_BUS_TYPE.xml' path='doc/member[@name="STORAGE_BUS_TYPE.BusTypeMaxReserved"]/*'/>
    BusTypeMaxReserved = 0x7F,
}