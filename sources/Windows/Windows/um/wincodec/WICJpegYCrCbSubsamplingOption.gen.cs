// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption"]/*'/>
public enum WICJpegYCrCbSubsamplingOption
{
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJpegYCrCbSubsamplingDefault"]/*'/>
    WICJpegYCrCbSubsamplingDefault = 0,
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJpegYCrCbSubsampling420"]/*'/>
    WICJpegYCrCbSubsampling420 = 0x1,
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJpegYCrCbSubsampling422"]/*'/>
    WICJpegYCrCbSubsampling422 = 0x2,
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJpegYCrCbSubsampling444"]/*'/>
    WICJpegYCrCbSubsampling444 = 0x3,
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJpegYCrCbSubsampling440"]/*'/>
    WICJpegYCrCbSubsampling440 = 0x4,
    /// <include file='WICJpegYCrCbSubsamplingOption.xml' path='doc/member[@name="WICJpegYCrCbSubsamplingOption.WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD"]/*'/>
    WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD = 0x7fffffff,
}