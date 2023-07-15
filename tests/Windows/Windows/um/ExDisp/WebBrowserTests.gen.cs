// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WebBrowser"/> struct.</summary>
public static unsafe partial class WebBrowserTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "WebBrowser"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(WebBrowser).GUID, Is.EqualTo(IID_WebBrowser));
    }

    /// <summary>Validates that the <see cref = "WebBrowser"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WebBrowser>(), Is.EqualTo(sizeof(WebBrowser)));
    }

    /// <summary>Validates that the <see cref = "WebBrowser"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WebBrowser).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WebBrowser"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WebBrowser), Is.EqualTo(1));
    }
}