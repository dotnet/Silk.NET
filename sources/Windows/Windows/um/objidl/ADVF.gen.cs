// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ADVF.xml' path='doc/member[@name="ADVF"]/*'/>
public enum ADVF
{
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVF_NODATA"]/*'/>
    ADVF_NODATA = 1,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVF_PRIMEFIRST"]/*'/>
    ADVF_PRIMEFIRST = 2,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVF_ONLYONCE"]/*'/>
    ADVF_ONLYONCE = 4,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVF_DATAONSTOP"]/*'/>
    ADVF_DATAONSTOP = 64,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVFCACHE_NOHANDLER"]/*'/>
    ADVFCACHE_NOHANDLER = 8,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVFCACHE_FORCEBUILTIN"]/*'/>
    ADVFCACHE_FORCEBUILTIN = 16,
    /// <include file='ADVF.xml' path='doc/member[@name="ADVF.ADVFCACHE_ONSAVE"]/*'/>
    ADVFCACHE_ONSAVE = 32,
}