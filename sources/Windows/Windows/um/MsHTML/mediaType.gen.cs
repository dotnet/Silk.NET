// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='mediaType.xml' path='doc/member[@name="mediaType"]/*'/>
public enum mediaType
{
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeNotSet"]/*'/>
    mediaTypeNotSet = 0,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeAll"]/*'/>
    mediaTypeAll = 511,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeAural"]/*'/>
    mediaTypeAural = 1,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeBraille"]/*'/>
    mediaTypeBraille = 2,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeEmbossed"]/*'/>
    mediaTypeEmbossed = 4,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeHandheld"]/*'/>
    mediaTypeHandheld = 8,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypePrint"]/*'/>
    mediaTypePrint = 16,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeProjection"]/*'/>
    mediaTypeProjection = 32,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeScreen"]/*'/>
    mediaTypeScreen = 64,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeTty"]/*'/>
    mediaTypeTty = 128,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaTypeTv"]/*'/>
    mediaTypeTv = 256,
    /// <include file='mediaType.xml' path='doc/member[@name="mediaType.mediaType_Max"]/*'/>
    mediaType_Max = 2147483647,
}