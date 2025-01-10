// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICalendarFactory"/> struct.</summary>
public static unsafe partial class ICalendarFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICalendarFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICalendarFactory).GUID, Is.EqualTo(IID_ICalendarFactory));
    }

    /// <summary>Validates that the <see cref = "ICalendarFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICalendarFactory>(), Is.EqualTo(sizeof(ICalendarFactory)));
    }

    /// <summary>Validates that the <see cref = "ICalendarFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICalendarFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICalendarFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICalendarFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICalendarFactory), Is.EqualTo(4));
        }
    }
}
