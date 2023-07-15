// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxBundleWriter"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IAppxBundleWriterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxBundleWriter"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxBundleWriter).GUID, Is.EqualTo(IID_IAppxBundleWriter));
    }

    /// <summary>Validates that the <see cref = "IAppxBundleWriter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxBundleWriter>(), Is.EqualTo(sizeof(IAppxBundleWriter)));
    }

    /// <summary>Validates that the <see cref = "IAppxBundleWriter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxBundleWriter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxBundleWriter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxBundleWriter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxBundleWriter), Is.EqualTo(4));
        }
    }
}