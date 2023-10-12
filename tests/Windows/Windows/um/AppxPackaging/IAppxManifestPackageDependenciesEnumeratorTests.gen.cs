// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxManifestPackageDependenciesEnumerator"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IAppxManifestPackageDependenciesEnumeratorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxManifestPackageDependenciesEnumerator"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxManifestPackageDependenciesEnumerator).GUID, Is.EqualTo(IID_IAppxManifestPackageDependenciesEnumerator));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestPackageDependenciesEnumerator"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxManifestPackageDependenciesEnumerator>(), Is.EqualTo(sizeof(IAppxManifestPackageDependenciesEnumerator)));
    }

    /// <summary>Validates that the <see cref = "IAppxManifestPackageDependenciesEnumerator"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxManifestPackageDependenciesEnumerator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxManifestPackageDependenciesEnumerator"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxManifestPackageDependenciesEnumerator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxManifestPackageDependenciesEnumerator), Is.EqualTo(4));
        }
    }
}