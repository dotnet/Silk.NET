// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "InkDesktopHost"/> struct.</summary>
public static unsafe partial class InkDesktopHostTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "InkDesktopHost"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(InkDesktopHost).GUID, Is.EqualTo(CLSID_InkDesktopHost));
    }

    /// <summary>Validates that the <see cref = "InkDesktopHost"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<InkDesktopHost>(), Is.EqualTo(sizeof(InkDesktopHost)));
    }

    /// <summary>Validates that the <see cref = "InkDesktopHost"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(InkDesktopHost).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "InkDesktopHost"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(InkDesktopHost), Is.EqualTo(1));
    }
}
