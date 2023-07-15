// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumPublishedApps"/> struct.</summary>
public static unsafe partial class IEnumPublishedAppsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumPublishedApps"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumPublishedApps).GUID, Is.EqualTo(IID_IEnumPublishedApps));
    }

    /// <summary>Validates that the <see cref = "IEnumPublishedApps"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumPublishedApps>(), Is.EqualTo(sizeof(IEnumPublishedApps)));
    }

    /// <summary>Validates that the <see cref = "IEnumPublishedApps"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumPublishedApps).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumPublishedApps"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumPublishedApps), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumPublishedApps), Is.EqualTo(4));
        }
    }
}