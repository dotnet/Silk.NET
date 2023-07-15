// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AppStartupLink"/> struct.</summary>
public static unsafe partial class AppStartupLinkTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AppStartupLink"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AppStartupLink).GUID, Is.EqualTo(IID_AppStartupLink));
    }

    /// <summary>Validates that the <see cref = "AppStartupLink"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AppStartupLink>(), Is.EqualTo(sizeof(AppStartupLink)));
    }

    /// <summary>Validates that the <see cref = "AppStartupLink"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AppStartupLink).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AppStartupLink"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AppStartupLink), Is.EqualTo(1));
    }
}