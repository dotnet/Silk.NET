// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "AppHostWritableAdminManager"/> struct.</summary>
public static unsafe partial class AppHostWritableAdminManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AppHostWritableAdminManager"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(AppHostWritableAdminManager).GUID,
            Is.EqualTo(IID_AppHostWritableAdminManager)
        );
    }

    /// <summary>Validates that the <see cref = "AppHostWritableAdminManager"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<AppHostWritableAdminManager>(),
            Is.EqualTo(sizeof(AppHostWritableAdminManager))
        );
    }

    /// <summary>Validates that the <see cref = "AppHostWritableAdminManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AppHostWritableAdminManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AppHostWritableAdminManager"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AppHostWritableAdminManager), Is.EqualTo(1));
    }
}
