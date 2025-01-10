// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IFileUnprotectOptionsFactory"/> struct.</summary>
public static unsafe partial class IFileUnprotectOptionsFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFileUnprotectOptionsFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IFileUnprotectOptionsFactory).GUID,
            Is.EqualTo(IID_IFileUnprotectOptionsFactory)
        );
    }

    /// <summary>Validates that the <see cref = "IFileUnprotectOptionsFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IFileUnprotectOptionsFactory>(),
            Is.EqualTo(sizeof(IFileUnprotectOptionsFactory))
        );
    }

    /// <summary>Validates that the <see cref = "IFileUnprotectOptionsFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFileUnprotectOptionsFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFileUnprotectOptionsFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFileUnprotectOptionsFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFileUnprotectOptionsFactory), Is.EqualTo(4));
        }
    }
}
