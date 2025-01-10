// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPrintTask"/> struct.</summary>
public static unsafe partial class IPrintTaskTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPrintTask"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPrintTask).GUID, Is.EqualTo(IID_IPrintTask));
    }

    /// <summary>Validates that the <see cref = "IPrintTask"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPrintTask>(), Is.EqualTo(sizeof(IPrintTask)));
    }

    /// <summary>Validates that the <see cref = "IPrintTask"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPrintTask).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPrintTask"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPrintTask), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPrintTask), Is.EqualTo(4));
        }
    }
}
