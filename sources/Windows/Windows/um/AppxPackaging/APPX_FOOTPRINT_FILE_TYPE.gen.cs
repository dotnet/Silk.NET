// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum APPX_FOOTPRINT_FILE_TYPE
{
    /// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE.APPX_FOOTPRINT_FILE_TYPE_MANIFEST"]/*'/>
    APPX_FOOTPRINT_FILE_TYPE_MANIFEST = 0,
    /// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE.APPX_FOOTPRINT_FILE_TYPE_BLOCKMAP"]/*'/>
    APPX_FOOTPRINT_FILE_TYPE_BLOCKMAP = 1,
    /// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE.APPX_FOOTPRINT_FILE_TYPE_SIGNATURE"]/*'/>
    APPX_FOOTPRINT_FILE_TYPE_SIGNATURE = 2,
    /// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE.APPX_FOOTPRINT_FILE_TYPE_CODEINTEGRITY"]/*'/>
    APPX_FOOTPRINT_FILE_TYPE_CODEINTEGRITY = 3,
    /// <include file='APPX_FOOTPRINT_FILE_TYPE.xml' path='doc/member[@name="APPX_FOOTPRINT_FILE_TYPE.APPX_FOOTPRINT_FILE_TYPE_CONTENTGROUPMAP"]/*'/>
    APPX_FOOTPRINT_FILE_TYPE_CONTENTGROUPMAP = 4,
}