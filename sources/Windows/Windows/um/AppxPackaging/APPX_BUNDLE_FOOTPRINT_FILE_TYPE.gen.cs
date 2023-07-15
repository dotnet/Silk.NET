// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum APPX_BUNDLE_FOOTPRINT_FILE_TYPE
{
    /// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE.APPX_BUNDLE_FOOTPRINT_FILE_TYPE_FIRST"]/*'/>
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_FIRST = 0,
    /// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE.APPX_BUNDLE_FOOTPRINT_FILE_TYPE_MANIFEST"]/*'/>
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_MANIFEST = 0,
    /// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE.APPX_BUNDLE_FOOTPRINT_FILE_TYPE_BLOCKMAP"]/*'/>
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_BLOCKMAP = 1,
    /// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE.APPX_BUNDLE_FOOTPRINT_FILE_TYPE_SIGNATURE"]/*'/>
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_SIGNATURE = 2,
    /// <include file='APPX_BUNDLE_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_FOOTPRINT_FILE_TYPE.APPX_BUNDLE_FOOTPRINT_FILE_TYPE_LAST"]/*'/>
    APPX_BUNDLE_FOOTPRINT_FILE_TYPE_LAST = 2,
}