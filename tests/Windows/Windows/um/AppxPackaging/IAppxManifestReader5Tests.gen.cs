// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxManifestReader5"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IAppxManifestReader5Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxManifestReader5"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxManifestReader5).GUID, Is.EqualTo(IID_IAppxManifestReader5));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestReader5"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxManifestReader5>(), Is.EqualTo(sizeof(IAppxManifestReader5)));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestReader5"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxManifestReader5).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxManifestReader5"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxManifestReader5), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxManifestReader5), Is.EqualTo(4));
        }
    }
}