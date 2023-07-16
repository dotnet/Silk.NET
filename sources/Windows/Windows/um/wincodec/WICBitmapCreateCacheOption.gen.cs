// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICBitmapCreateCacheOption.xml' path='doc/member[@name="WICBitmapCreateCacheOption"]/*'/>
public enum WICBitmapCreateCacheOption
{
    /// <include file='WICBitmapCreateCacheOption.xml' path='doc/member[@name="WICBitmapCreateCacheOption.WICBitmapNoCache"]/*'/>
    WICBitmapNoCache = 0,
    /// <include file='WICBitmapCreateCacheOption.xml' path='doc/member[@name="WICBitmapCreateCacheOption.WICBitmapCacheOnDemand"]/*'/>
    WICBitmapCacheOnDemand = 0x1,
    /// <include file='WICBitmapCreateCacheOption.xml' path='doc/member[@name="WICBitmapCreateCacheOption.WICBitmapCacheOnLoad"]/*'/>
    WICBitmapCacheOnLoad = 0x2,
    /// <include file='WICBitmapCreateCacheOption.xml' path='doc/member[@name="WICBitmapCreateCacheOption.WICBITMAPCREATECACHEOPTION_FORCE_DWORD"]/*'/>
    WICBITMAPCREATECACHEOPTION_FORCE_DWORD = 0x7fffffff,
}