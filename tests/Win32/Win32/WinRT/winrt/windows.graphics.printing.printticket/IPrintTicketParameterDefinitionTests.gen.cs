// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPrintTicketParameterDefinition"/> struct.</summary>
public static unsafe partial class IPrintTicketParameterDefinitionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPrintTicketParameterDefinition"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPrintTicketParameterDefinition).GUID,
            Is.EqualTo(IID_IPrintTicketParameterDefinition)
        );
    }

    /// <summary>Validates that the <see cref = "IPrintTicketParameterDefinition"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPrintTicketParameterDefinition>(),
            Is.EqualTo(sizeof(IPrintTicketParameterDefinition))
        );
    }

    /// <summary>Validates that the <see cref = "IPrintTicketParameterDefinition"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPrintTicketParameterDefinition).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPrintTicketParameterDefinition"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPrintTicketParameterDefinition), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPrintTicketParameterDefinition), Is.EqualTo(4));
        }
    }
}
