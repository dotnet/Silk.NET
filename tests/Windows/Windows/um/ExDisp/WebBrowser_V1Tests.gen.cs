// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WebBrowser_V1"/> struct.</summary>
public static unsafe partial class WebBrowser_V1Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "WebBrowser_V1"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(WebBrowser_V1).GUID, Is.EqualTo(IID_WebBrowser_V1));
    }

    /// <summary>Validates that the <see cref = "WebBrowser_V1"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WebBrowser_V1>(), Is.EqualTo(sizeof(WebBrowser_V1)));
    }

    /// <summary>Validates that the <see cref = "WebBrowser_V1"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WebBrowser_V1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WebBrowser_V1"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WebBrowser_V1), Is.EqualTo(1));
    }
}