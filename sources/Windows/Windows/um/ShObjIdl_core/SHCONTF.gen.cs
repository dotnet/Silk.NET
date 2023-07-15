// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF"]/*'/>
public enum SHCONTF
{
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_CHECKING_FOR_CHILDREN"]/*'/>
    SHCONTF_CHECKING_FOR_CHILDREN = 0x10,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_FOLDERS"]/*'/>
    SHCONTF_FOLDERS = 0x20,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_NONFOLDERS"]/*'/>
    SHCONTF_NONFOLDERS = 0x40,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_INCLUDEHIDDEN"]/*'/>
    SHCONTF_INCLUDEHIDDEN = 0x80,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_INIT_ON_FIRST_NEXT"]/*'/>
    SHCONTF_INIT_ON_FIRST_NEXT = 0x100,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_NETPRINTERSRCH"]/*'/>
    SHCONTF_NETPRINTERSRCH = 0x200,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_SHAREABLE"]/*'/>
    SHCONTF_SHAREABLE = 0x400,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_STORAGE"]/*'/>
    SHCONTF_STORAGE = 0x800,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_NAVIGATION_ENUM"]/*'/>
    SHCONTF_NAVIGATION_ENUM = 0x1000,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_FASTITEMS"]/*'/>
    SHCONTF_FASTITEMS = 0x2000,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_FLATLIST"]/*'/>
    SHCONTF_FLATLIST = 0x4000,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_ENABLE_ASYNC"]/*'/>
    SHCONTF_ENABLE_ASYNC = 0x8000,
    /// <include file='SHCONTF.xml' path='doc/member[@name="SHCONTF.SHCONTF_INCLUDESUPERHIDDEN"]/*'/>
    SHCONTF_INCLUDESUPERHIDDEN = 0x10000,
}