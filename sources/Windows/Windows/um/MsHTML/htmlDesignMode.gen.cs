// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlDesignMode.xml' path='doc/member[@name="htmlDesignMode"]/*'/>
public enum htmlDesignMode
{
    /// <include file='htmlDesignMode.xml' path='doc/member[@name="htmlDesignMode.htmlDesignModeInherit"]/*'/>
    htmlDesignModeInherit = -2,
    /// <include file='htmlDesignMode.xml' path='doc/member[@name="htmlDesignMode.htmlDesignModeOn"]/*'/>
    htmlDesignModeOn = -1,
    /// <include file='htmlDesignMode.xml' path='doc/member[@name="htmlDesignMode.htmlDesignModeOff"]/*'/>
    htmlDesignModeOff = 0,
    /// <include file='htmlDesignMode.xml' path='doc/member[@name="htmlDesignMode.htmlDesignMode_Max"]/*'/>
    htmlDesignMode_Max = 2147483647,
}