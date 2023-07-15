// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAppxDigestProvider"/> struct.</summary>
public static unsafe partial class IAppxDigestProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxDigestProvider"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxDigestProvider).GUID, Is.EqualTo(IID_IAppxDigestProvider));
    }

    /// <summary>Validates that the <see cref = "IAppxDigestProvider"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxDigestProvider>(), Is.EqualTo(sizeof(IAppxDigestProvider)));
    }

    /// <summary>Validates that the <see cref = "IAppxDigestProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxDigestProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxDigestProvider"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxDigestProvider), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxDigestProvider), Is.EqualTo(4));
        }
    }
}