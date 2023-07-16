// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption"]/*'/>
public enum WICTiffCompressionOption
{
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionDontCare"]/*'/>
    WICTiffCompressionDontCare = 0,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionNone"]/*'/>
    WICTiffCompressionNone = 0x1,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionCCITT3"]/*'/>
    WICTiffCompressionCCITT3 = 0x2,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionCCITT4"]/*'/>
    WICTiffCompressionCCITT4 = 0x3,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionLZW"]/*'/>
    WICTiffCompressionLZW = 0x4,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionRLE"]/*'/>
    WICTiffCompressionRLE = 0x5,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionZIP"]/*'/>
    WICTiffCompressionZIP = 0x6,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTiffCompressionLZWHDifferencing"]/*'/>
    WICTiffCompressionLZWHDifferencing = 0x7,
    /// <include file='WICTiffCompressionOption.xml' path='doc/member[@name="WICTiffCompressionOption.WICTIFFCOMPRESSIONOPTION_FORCE_DWORD"]/*'/>
    WICTIFFCOMPRESSIONOPTION_FORCE_DWORD = 0x7fffffff,
}