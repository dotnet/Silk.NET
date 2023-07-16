// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "V1WinBioCredentialProvider"/> struct.</summary>
public static unsafe partial class V1WinBioCredentialProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "V1WinBioCredentialProvider"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(V1WinBioCredentialProvider).GUID, Is.EqualTo(IID_V1WinBioCredentialProvider));
    }

    /// <summary>Validates that the <see cref = "V1WinBioCredentialProvider"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<V1WinBioCredentialProvider>(), Is.EqualTo(sizeof(V1WinBioCredentialProvider)));
    }

    /// <summary>Validates that the <see cref = "V1WinBioCredentialProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(V1WinBioCredentialProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "V1WinBioCredentialProvider"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(V1WinBioCredentialProvider), Is.EqualTo(1));
    }
}