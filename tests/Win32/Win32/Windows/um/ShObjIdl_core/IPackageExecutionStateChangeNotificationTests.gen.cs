// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IPackageExecutionStateChangeNotification"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IPackageExecutionStateChangeNotificationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPackageExecutionStateChangeNotification"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPackageExecutionStateChangeNotification).GUID,
            Is.EqualTo(IID_IPackageExecutionStateChangeNotification)
        );
    }

    /// <summary>Validates that the <see cref = "IPackageExecutionStateChangeNotification"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPackageExecutionStateChangeNotification>(),
            Is.EqualTo(sizeof(IPackageExecutionStateChangeNotification))
        );
    }

    /// <summary>Validates that the <see cref = "IPackageExecutionStateChangeNotification"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPackageExecutionStateChangeNotification).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPackageExecutionStateChangeNotification"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPackageExecutionStateChangeNotification), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPackageExecutionStateChangeNotification), Is.EqualTo(4));
        }
    }
}
