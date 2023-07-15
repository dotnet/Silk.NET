// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICredentialProviderCredential"/> struct.</summary>
public static unsafe partial class ICredentialProviderCredentialTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICredentialProviderCredential"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICredentialProviderCredential).GUID, Is.EqualTo(IID_ICredentialProviderCredential));
    }

    /// <summary>Validates that the <see cref = "ICredentialProviderCredential"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICredentialProviderCredential>(), Is.EqualTo(sizeof(ICredentialProviderCredential)));
    }

    /// <summary>Validates that the <see cref = "ICredentialProviderCredential"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICredentialProviderCredential).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICredentialProviderCredential"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICredentialProviderCredential), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICredentialProviderCredential), Is.EqualTo(4));
        }
    }
}