// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RASTERIZER_STATUS.xml' path='doc/member[@name="RASTERIZER_STATUS"]/*'/>
public partial struct RASTERIZER_STATUS
{
    /// <include file='RASTERIZER_STATUS.xml' path='doc/member[@name="RASTERIZER_STATUS.nSize"]/*'/>
    public short nSize;
    /// <include file='RASTERIZER_STATUS.xml' path='doc/member[@name="RASTERIZER_STATUS.wFlags"]/*'/>
    public short wFlags;
    /// <include file='RASTERIZER_STATUS.xml' path='doc/member[@name="RASTERIZER_STATUS.nLanguageID"]/*'/>
    public short nLanguageID;
}