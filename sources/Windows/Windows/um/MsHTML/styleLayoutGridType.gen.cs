// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType"]/*'/>
public enum styleLayoutGridType
{
    /// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType.styleLayoutGridTypeNotSet"]/*'/>
    styleLayoutGridTypeNotSet = 0,
    /// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType.styleLayoutGridTypeLoose"]/*'/>
    styleLayoutGridTypeLoose = 1,
    /// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType.styleLayoutGridTypeStrict"]/*'/>
    styleLayoutGridTypeStrict = 2,
    /// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType.styleLayoutGridTypeFixed"]/*'/>
    styleLayoutGridTypeFixed = 3,
    /// <include file='styleLayoutGridType.xml' path='doc/member[@name="styleLayoutGridType.styleLayoutGridType_Max"]/*'/>
    styleLayoutGridType_Max = 2147483647,
}