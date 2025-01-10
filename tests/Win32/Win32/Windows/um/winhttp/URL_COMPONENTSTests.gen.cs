// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "URL_COMPONENTS"/> struct.</summary>
public static unsafe partial class URL_COMPONENTSTests
{
    /// <summary>Validates that the <see cref = "URL_COMPONENTS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<URL_COMPONENTS>(), Is.EqualTo(sizeof(URL_COMPONENTS)));
    }

    /// <summary>Validates that the <see cref = "URL_COMPONENTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(URL_COMPONENTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "URL_COMPONENTS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(URL_COMPONENTS), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(URL_COMPONENTS), Is.EqualTo(60));
        }
    }
}
