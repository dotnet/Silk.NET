// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxManifestHostRuntimeDependency"/> struct.</summary>
public static unsafe partial class IAppxManifestHostRuntimeDependencyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxManifestHostRuntimeDependency"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxManifestHostRuntimeDependency).GUID, Is.EqualTo(IID_IAppxManifestHostRuntimeDependency));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestHostRuntimeDependency"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxManifestHostRuntimeDependency>(), Is.EqualTo(sizeof(IAppxManifestHostRuntimeDependency)));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestHostRuntimeDependency"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxManifestHostRuntimeDependency).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxManifestHostRuntimeDependency"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxManifestHostRuntimeDependency), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxManifestHostRuntimeDependency), Is.EqualTo(4));
        }
    }
}