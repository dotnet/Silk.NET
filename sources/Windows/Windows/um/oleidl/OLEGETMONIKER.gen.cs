// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLEGETMONIKER.xml' path='doc/member[@name="OLEGETMONIKER"]/*'/>
public enum OLEGETMONIKER
{
    /// <include file='OLEGETMONIKER.xml' path='doc/member[@name="OLEGETMONIKER.OLEGETMONIKER_ONLYIFTHERE"]/*'/>
    OLEGETMONIKER_ONLYIFTHERE = 1,
    /// <include file='OLEGETMONIKER.xml' path='doc/member[@name="OLEGETMONIKER.OLEGETMONIKER_FORCEASSIGN"]/*'/>
    OLEGETMONIKER_FORCEASSIGN = 2,
    /// <include file='OLEGETMONIKER.xml' path='doc/member[@name="OLEGETMONIKER.OLEGETMONIKER_UNASSIGN"]/*'/>
    OLEGETMONIKER_UNASSIGN = 3,
    /// <include file='OLEGETMONIKER.xml' path='doc/member[@name="OLEGETMONIKER.OLEGETMONIKER_TEMPFORUSER"]/*'/>
    OLEGETMONIKER_TEMPFORUSER = 4,
}