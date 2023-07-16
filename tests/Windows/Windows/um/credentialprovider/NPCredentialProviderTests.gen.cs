// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NPCredentialProvider"/> struct.</summary>
public static unsafe partial class NPCredentialProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "NPCredentialProvider"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(NPCredentialProvider).GUID, Is.EqualTo(IID_NPCredentialProvider));
    }

    /// <summary>Validates that the <see cref = "NPCredentialProvider"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NPCredentialProvider>(), Is.EqualTo(sizeof(NPCredentialProvider)));
    }

    /// <summary>Validates that the <see cref = "NPCredentialProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NPCredentialProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NPCredentialProvider"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NPCredentialProvider), Is.EqualTo(1));
    }
}