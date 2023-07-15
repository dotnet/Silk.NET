// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxPackageReader"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IAppxPackageReaderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxPackageReader"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxPackageReader).GUID, Is.EqualTo(IID_IAppxPackageReader));
    }

    /// <summary>Validates that the <see cref = "IAppxPackageReader"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxPackageReader>(), Is.EqualTo(sizeof(IAppxPackageReader)));
    }

    /// <summary>Validates that the <see cref = "IAppxPackageReader"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxPackageReader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxPackageReader"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxPackageReader), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxPackageReader), Is.EqualTo(4));
        }
    }
}