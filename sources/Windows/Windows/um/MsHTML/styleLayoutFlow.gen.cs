// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleLayoutFlow.xml' path='doc/member[@name="styleLayoutFlow"]/*' />
public enum styleLayoutFlow
{
    /// <include file='styleLayoutFlow.xml' path='doc/member[@name="styleLayoutFlow.styleLayoutFlowHorizontal"]/*' />
    styleLayoutFlowHorizontal = 0,

    /// <include file='styleLayoutFlow.xml' path='doc/member[@name="styleLayoutFlow.styleLayoutFlowVerticalIdeographic"]/*' />
    styleLayoutFlowVerticalIdeographic = 1,

    /// <include file='styleLayoutFlow.xml' path='doc/member[@name="styleLayoutFlow.styleLayoutFlowNotSet"]/*' />
    styleLayoutFlowNotSet = 2,

    /// <include file='styleLayoutFlow.xml' path='doc/member[@name="styleLayoutFlow.styleLayoutFlow_Max"]/*' />
    styleLayoutFlow_Max = 2147483647,
}
