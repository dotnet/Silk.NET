// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IWebErrorStatics"/> struct.</summary>
public static unsafe partial class IWebErrorStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWebErrorStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWebErrorStatics).GUID, Is.EqualTo(IID_IWebErrorStatics));
    }

    /// <summary>Validates that the <see cref = "IWebErrorStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWebErrorStatics>(), Is.EqualTo(sizeof(IWebErrorStatics)));
    }

    /// <summary>Validates that the <see cref = "IWebErrorStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWebErrorStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWebErrorStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWebErrorStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWebErrorStatics), Is.EqualTo(4));
        }
    }
}
