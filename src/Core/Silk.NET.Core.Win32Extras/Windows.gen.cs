// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    public unsafe partial class Windows : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "ANYSIZE_ARRAY")]
        public const int AnysizeArray = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_ALLOCATION_ALIGNMENT")]
        public const int MemoryAllocationAlignment = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "X86_CACHE_ALIGNMENT_SIZE")]
        public const int X86CacheAlignmentSize = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "ARM_CACHE_ALIGNMENT_SIZE")]
        public const int ArmCacheAlignmentSize = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CACHE_ALIGNMENT_SIZE")]
        public const int SystemCacheAlignmentSize = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRAGMA_DEPRECATED_DDK")]
        public const int PragmaDeprecatedDdk = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "UCSCHAR_INVALID_CHARACTER")]
        public const uint UcscharInvalidCharacter = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MIN_UCSCHAR")]
        public const int MinUcschar = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_UCSCHAR")]
        public const int MaxUcschar = unchecked((int) 0x10FFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ALL_PROCESSOR_GROUPS")]
        public const int AllProcessorGroups = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_PROC_PER_GROUP")]
        public const int MaximumProcPerGroup = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_PROCESSORS")]
        public const int MaximumProcessors = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "APPLICATION_ERROR_MASK")]
        public const int ApplicationErrorMask = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ERROR_SEVERITY_SUCCESS")]
        public const int ErrorSeveritySuccess = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ERROR_SEVERITY_INFORMATIONAL")]
        public const int ErrorSeverityInformational = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "ERROR_SEVERITY_WARNING")]
        public const uint ErrorSeverityWarning = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "ERROR_SEVERITY_ERROR")]
        public const uint ErrorSeverityError = unchecked((uint) 0xFFFFFFFFC0000000);
        [NativeName("Type", "long long")]
        [NativeName("Name", "MAXLONGLONG")]
        public const long Maxlonglong = unchecked((long) 0x7FFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "UNICODE_STRING_MAX_CHARS")]
        public const int UnicodeStringMaxChars = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MINCHAR")]
        public const int Minchar = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXCHAR")]
        public const int Maxchar = unchecked((int) 0x7F);
        [NativeName("Type", "int")]
        [NativeName("Name", "MINSHORT")]
        public const int Minshort = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXSHORT")]
        public const int Maxshort = unchecked((int) 0x7FFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "MINLONG")]
        public const uint Minlong = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXLONG")]
        public const int Maxlong = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXBYTE")]
        public const int Maxbyte = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXWORD")]
        public const int Maxword = unchecked((int) 0xFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "MAXDWORD")]
        public const uint Maxdword = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_SHORT_ID_LENGTH")]
        public const int EnclaveShortIDLength = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_LONG_ID_LENGTH")]
        public const int EnclaveLongIDLength = unchecked((int) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "VER_SERVER_NT")]
        public const uint VerServerNT = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_WORKSTATION_NT")]
        public const int VerWorkstationNT = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_SMALLBUSINESS")]
        public const int VerSuiteSmallbusiness = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_ENTERPRISE")]
        public const int VerSuiteEnterprise = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_BACKOFFICE")]
        public const int VerSuiteBackoffice = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_COMMUNICATIONS")]
        public const int VerSuiteCommunications = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_TERMINAL")]
        public const int VerSuiteTerminal = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_SMALLBUSINESS_RESTRICTED")]
        public const int VerSuiteSmallbusinessRestricted = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_EMBEDDEDNT")]
        public const int VerSuiteEmbeddednt = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_DATACENTER")]
        public const int VerSuiteDatacenter = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_SINGLEUSERTS")]
        public const int VerSuiteSingleuserts = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_PERSONAL")]
        public const int VerSuitePersonal = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_BLADE")]
        public const int VerSuiteBlade = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_EMBEDDED_RESTRICTED")]
        public const int VerSuiteEmbeddedRestricted = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_SECURITY_APPLIANCE")]
        public const int VerSuiteSecurityAppliance = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_STORAGE_SERVER")]
        public const int VerSuiteStorageServer = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_COMPUTE_SERVER")]
        public const int VerSuiteComputeServer = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_WH_SERVER")]
        public const int VerSuiteWHServer = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITE_MULTIUSERTS")]
        public const int VerSuiteMultiuserts = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_UNDEFINED")]
        public const int ProductUndefined = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ULTIMATE")]
        public const int ProductUltimate = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_BASIC")]
        public const int ProductHomeBasic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_PREMIUM")]
        public const int ProductHomePremium = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE")]
        public const int ProductEnterprise = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_BASIC_N")]
        public const int ProductHomeBasicN = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_BUSINESS")]
        public const int ProductBusiness = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER")]
        public const int ProductStandardServer = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER")]
        public const int ProductDatacenterServer = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SMALLBUSINESS_SERVER")]
        public const int ProductSmallbusinessServer = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SERVER")]
        public const int ProductEnterpriseServer = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STARTER")]
        public const int ProductStarter = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER_CORE")]
        public const int ProductDatacenterServerCore = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER_CORE")]
        public const int ProductStandardServerCore = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SERVER_CORE")]
        public const int ProductEnterpriseServerCore = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SERVER_IA64")]
        public const int ProductEnterpriseServerIA64 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_BUSINESS_N")]
        public const int ProductBusinessN = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_WEB_SERVER")]
        public const int ProductWebServer = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLUSTER_SERVER")]
        public const int ProductClusterServer = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_SERVER")]
        public const int ProductHomeServer = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_EXPRESS_SERVER")]
        public const int ProductStorageExpressServer = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_STANDARD_SERVER")]
        public const int ProductStorageStandardServer = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_WORKGROUP_SERVER")]
        public const int ProductStorageWorkgroupServer = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_ENTERPRISE_SERVER")]
        public const int ProductStorageEnterpriseServer = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVER_FOR_SMALLBUSINESS")]
        public const int ProductServerForSmallbusiness = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SMALLBUSINESS_SERVER_PREMIUM")]
        public const int ProductSmallbusinessServerPremium = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_PREMIUM_N")]
        public const int ProductHomePremiumN = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_N")]
        public const int ProductEnterpriseN = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ULTIMATE_N")]
        public const int ProductUltimateN = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_WEB_SERVER_CORE")]
        public const int ProductWebServerCore = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT")]
        public const int ProductMediumbusinessServerManagement = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY")]
        public const int ProductMediumbusinessServerSecurity = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING")]
        public const int ProductMediumbusinessServerMessaging = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVER_FOUNDATION")]
        public const int ProductServerFoundation = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_PREMIUM_SERVER")]
        public const int ProductHomePremiumServer = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVER_FOR_SMALLBUSINESS_V")]
        public const int ProductServerForSmallbusinessV = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER_V")]
        public const int ProductStandardServerV = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER_V")]
        public const int ProductDatacenterServerV = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SERVER_V")]
        public const int ProductEnterpriseServerV = unchecked((int) 0x26);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER_CORE_V")]
        public const int ProductDatacenterServerCoreV = unchecked((int) 0x27);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER_CORE_V")]
        public const int ProductStandardServerCoreV = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SERVER_CORE_V")]
        public const int ProductEnterpriseServerCoreV = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HYPERV")]
        public const int ProductHyperv = unchecked((int) 0x2A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_EXPRESS_SERVER_CORE")]
        public const int ProductStorageExpressServerCore = unchecked((int) 0x2B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_STANDARD_SERVER_CORE")]
        public const int ProductStorageStandardServerCore = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_WORKGROUP_SERVER_CORE")]
        public const int ProductStorageWorkgroupServerCore = unchecked((int) 0x2D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE")]
        public const int ProductStorageEnterpriseServerCore = unchecked((int) 0x2E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STARTER_N")]
        public const int ProductStarterN = unchecked((int) 0x2F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL")]
        public const int ProductProfessional = unchecked((int) 0x30);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_N")]
        public const int ProductProfessionalN = unchecked((int) 0x31);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SB_SOLUTION_SERVER")]
        public const int ProductSBSolutionServer = unchecked((int) 0x32);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVER_FOR_SB_SOLUTIONS")]
        public const int ProductServerForSBSolutions = unchecked((int) 0x33);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER_SOLUTIONS")]
        public const int ProductStandardServerSolutions = unchecked((int) 0x34);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE")]
        public const int ProductStandardServerSolutionsCore = unchecked((int) 0x35);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SB_SOLUTION_SERVER_EM")]
        public const int ProductSBSolutionServerEM = unchecked((int) 0x36);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM")]
        public const int ProductServerForSBSolutionsEM = unchecked((int) 0x37);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SOLUTION_EMBEDDEDSERVER")]
        public const int ProductSolutionEmbeddedserver = unchecked((int) 0x38);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE")]
        public const int ProductSolutionEmbeddedserverCore = unchecked((int) 0x39);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_EMBEDDED")]
        public const int ProductProfessionalEmbedded = unchecked((int) 0x3A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT")]
        public const int ProductEssentialbusinessServerMgmt = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL")]
        public const int ProductEssentialbusinessServerAddl = unchecked((int) 0x3C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC")]
        public const int ProductEssentialbusinessServerMgmtsvc = unchecked((int) 0x3D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC")]
        public const int ProductEssentialbusinessServerAddlsvc = unchecked((int) 0x3E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE")]
        public const int ProductSmallbusinessServerPremiumCore = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLUSTER_SERVER_V")]
        public const int ProductClusterServerV = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED")]
        public const int ProductEmbedded = unchecked((int) 0x41);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STARTER_E")]
        public const int ProductStarterE = unchecked((int) 0x42);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_BASIC_E")]
        public const int ProductHomeBasicE = unchecked((int) 0x43);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOME_PREMIUM_E")]
        public const int ProductHomePremiumE = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_E")]
        public const int ProductProfessionalE = unchecked((int) 0x45);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_E")]
        public const int ProductEnterpriseE = unchecked((int) 0x46);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ULTIMATE_E")]
        public const int ProductUltimateE = unchecked((int) 0x47);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_EVALUATION")]
        public const int ProductEnterpriseEvaluation = unchecked((int) 0x48);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_MULTIPOINT_STANDARD_SERVER")]
        public const int ProductMultipointStandardServer = unchecked((int) 0x4C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_MULTIPOINT_PREMIUM_SERVER")]
        public const int ProductMultipointPremiumServer = unchecked((int) 0x4D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_EVALUATION_SERVER")]
        public const int ProductStandardEvaluationServer = unchecked((int) 0x4F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_EVALUATION_SERVER")]
        public const int ProductDatacenterEvaluationServer = unchecked((int) 0x50);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_N_EVALUATION")]
        public const int ProductEnterpriseNEvaluation = unchecked((int) 0x54);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_AUTOMOTIVE")]
        public const int ProductEmbeddedAutomotive = unchecked((int) 0x55);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY_A")]
        public const int ProductEmbeddedIndustryA = unchecked((int) 0x56);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_THINPC")]
        public const int ProductThinpc = unchecked((int) 0x57);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_A")]
        public const int ProductEmbeddedA = unchecked((int) 0x58);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY")]
        public const int ProductEmbeddedIndustry = unchecked((int) 0x59);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_E")]
        public const int ProductEmbeddedE = unchecked((int) 0x5A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY_E")]
        public const int ProductEmbeddedIndustryE = unchecked((int) 0x5B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY_A_E")]
        public const int ProductEmbeddedIndustryAE = unchecked((int) 0x5C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER")]
        public const int ProductStorageWorkgroupEvaluationServer = unchecked((int) 0x5F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER")]
        public const int ProductStorageStandardEvaluationServer = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_ARM")]
        public const int ProductCoreArm = unchecked((int) 0x61);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_N")]
        public const int ProductCoreN = unchecked((int) 0x62);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_COUNTRYSPECIFIC")]
        public const int ProductCoreCountryspecific = unchecked((int) 0x63);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_SINGLELANGUAGE")]
        public const int ProductCoreSinglelanguage = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE")]
        public const int ProductCore = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_WMC")]
        public const int ProductProfessionalWmc = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY_EVAL")]
        public const int ProductEmbeddedIndustryEval = unchecked((int) 0x69);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_INDUSTRY_E_EVAL")]
        public const int ProductEmbeddedIndustryEEval = unchecked((int) 0x6A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_EVAL")]
        public const int ProductEmbeddedEval = unchecked((int) 0x6B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EMBEDDED_E_EVAL")]
        public const int ProductEmbeddedEEval = unchecked((int) 0x6C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_NANO_SERVER")]
        public const int ProductNanoServer = unchecked((int) 0x6D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUD_STORAGE_SERVER")]
        public const int ProductCloudStorageServer = unchecked((int) 0x6E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_CONNECTED")]
        public const int ProductCoreConnected = unchecked((int) 0x6F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_STUDENT")]
        public const int ProductProfessionalStudent = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_CONNECTED_N")]
        public const int ProductCoreConnectedN = unchecked((int) 0x71);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_STUDENT_N")]
        public const int ProductProfessionalStudentN = unchecked((int) 0x72);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_CONNECTED_SINGLELANGUAGE")]
        public const int ProductCoreConnectedSinglelanguage = unchecked((int) 0x73);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC")]
        public const int ProductCoreConnectedCountryspecific = unchecked((int) 0x74);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CONNECTED_CAR")]
        public const int ProductConnectedCar = unchecked((int) 0x75);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_INDUSTRY_HANDHELD")]
        public const int ProductIndustryHandheld = unchecked((int) 0x76);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PPI_PRO")]
        public const int ProductPpiPro = unchecked((int) 0x77);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ARM64_SERVER")]
        public const int ProductArm64Server = unchecked((int) 0x78);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EDUCATION")]
        public const int ProductEducation = unchecked((int) 0x79);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_EDUCATION_N")]
        public const int ProductEducationN = unchecked((int) 0x7A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_IOTUAP")]
        public const int ProductIotuap = unchecked((int) 0x7B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER")]
        public const int ProductCloudHostInfrastructureServer = unchecked((int) 0x7C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_S")]
        public const int ProductEnterpriseS = unchecked((int) 0x7D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_S_N")]
        public const int ProductEnterpriseSN = unchecked((int) 0x7E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_S")]
        public const int ProductProfessionalS = unchecked((int) 0x7F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PROFESSIONAL_S_N")]
        public const int ProductProfessionalSN = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_S_EVALUATION")]
        public const int ProductEnterpriseSEvaluation = unchecked((int) 0x81);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_S_N_EVALUATION")]
        public const int ProductEnterpriseSNEvaluation = unchecked((int) 0x82);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOLOGRAPHIC")]
        public const int ProductHolographic = unchecked((int) 0x87);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HOLOGRAPHIC_BUSINESS")]
        public const int ProductHolographicBusiness = unchecked((int) 0x88);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_SINGLE_LANGUAGE")]
        public const int ProductProSingleLanguage = unchecked((int) 0x8A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_CHINA")]
        public const int ProductProChina = unchecked((int) 0x8B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SUBSCRIPTION")]
        public const int ProductEnterpriseSubscription = unchecked((int) 0x8C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISE_SUBSCRIPTION_N")]
        public const int ProductEnterpriseSubscriptionN = unchecked((int) 0x8D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_NANO_SERVER")]
        public const int ProductDatacenterNanoServer = unchecked((int) 0x8F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_NANO_SERVER")]
        public const int ProductStandardNanoServer = unchecked((int) 0x90);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_A_SERVER_CORE")]
        public const int ProductDatacenterAServerCore = unchecked((int) 0x91);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_A_SERVER_CORE")]
        public const int ProductStandardAServerCore = unchecked((int) 0x92);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_WS_SERVER_CORE")]
        public const int ProductDatacenterWSServerCore = unchecked((int) 0x93);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_WS_SERVER_CORE")]
        public const int ProductStandardWSServerCore = unchecked((int) 0x94);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_UTILITY_VM")]
        public const int ProductUtilityVM = unchecked((int) 0x95);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_EVALUATION_SERVER_CORE")]
        public const int ProductDatacenterEvaluationServerCore = unchecked((int) 0x9F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_STANDARD_EVALUATION_SERVER_CORE")]
        public const int ProductStandardEvaluationServerCore = unchecked((int) 0xA0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_WORKSTATION")]
        public const int ProductProWorkstation = unchecked((int) 0xA1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_WORKSTATION_N")]
        public const int ProductProWorkstationN = unchecked((int) 0xA2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_FOR_EDUCATION")]
        public const int ProductProForEducation = unchecked((int) 0xA4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_PRO_FOR_EDUCATION_N")]
        public const int ProductProForEducationN = unchecked((int) 0xA5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_AZURE_SERVER_CORE")]
        public const int ProductAzureServerCore = unchecked((int) 0xA8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_AZURE_NANO_SERVER")]
        public const int ProductAzureNanoServer = unchecked((int) 0xA9);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISEG")]
        public const int ProductEnterpriseg = unchecked((int) 0xAB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ENTERPRISEGN")]
        public const int ProductEnterprisegn = unchecked((int) 0xAC);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_SERVERRDSH")]
        public const int ProductServerrdsh = unchecked((int) 0xAF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUD")]
        public const int ProductCloud = unchecked((int) 0xB2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUDN")]
        public const int ProductCloudn = unchecked((int) 0xB3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_HUBOS")]
        public const int ProductHubos = unchecked((int) 0xB4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_ONECOREUPDATEOS")]
        public const int ProductOnecoreupdateos = unchecked((int) 0xB6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUDE")]
        public const int ProductCloude = unchecked((int) 0xB7);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_IOTOS")]
        public const int ProductIotos = unchecked((int) 0xB9);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUDEN")]
        public const int ProductClouden = unchecked((int) 0xBA);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_IOTEDGEOS")]
        public const int ProductIotedgeos = unchecked((int) 0xBB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_IOTENTERPRISE")]
        public const int ProductIotenterprise = unchecked((int) 0xBC);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_LITE")]
        public const int ProductLite = unchecked((int) 0xBD);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_IOTENTERPRISES")]
        public const int ProductIotenterprises = unchecked((int) 0xBF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_SYSTEMOS")]
        public const int ProductXboxSystemos = unchecked((int) 0xC0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_NATIVEOS")]
        public const int ProductXboxNativeos = unchecked((int) 0xC1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_GAMEOS")]
        public const int ProductXboxGameos = unchecked((int) 0xC2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_ERAOS")]
        public const int ProductXboxEraos = unchecked((int) 0xC3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_DURANGOHOSTOS")]
        public const int ProductXboxDurangohostos = unchecked((int) 0xC4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_XBOX_SCARLETTHOSTOS")]
        public const int ProductXboxScarletthostos = unchecked((int) 0xC5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_AZURE_SERVER_CLOUDHOST")]
        public const int ProductAzureServerCloudhost = unchecked((int) 0xC7);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_AZURE_SERVER_CLOUDMOS")]
        public const int ProductAzureServerCloudmos = unchecked((int) 0xC8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUDEDITIONN")]
        public const int ProductCloudeditionn = unchecked((int) 0xCA);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_CLOUDEDITION")]
        public const int ProductCloudedition = unchecked((int) 0xCB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_AZURESTACKHCI_SERVER_CORE")]
        public const int ProductAzurestackhciServerCore = unchecked((int) 0x196);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER_AZURE_EDITION")]
        public const int ProductDatacenterServerAzureEdition = unchecked((int) 0x197);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION")]
        public const int ProductDatacenterServerCoreAzureEdition = unchecked((int) 0x198);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "PRODUCT_UNLICENSED")]
        public const uint ProductUnlicensed = unchecked((uint) 0xFFFFFFFFABCDABCD);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_NEUTRAL")]
        public const int LangNeutral = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_INVARIANT")]
        public const int LangInvariant = unchecked((int) 0x7F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_AFRIKAANS")]
        public const int LangAfrikaans = unchecked((int) 0x36);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ALBANIAN")]
        public const int LangAlbanian = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ALSATIAN")]
        public const int LangAlsatian = unchecked((int) 0x84);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_AMHARIC")]
        public const int LangAmharic = unchecked((int) 0x5E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ARABIC")]
        public const int LangArabic = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ARMENIAN")]
        public const int LangArmenian = unchecked((int) 0x2B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ASSAMESE")]
        public const int LangAssamese = unchecked((int) 0x4D);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_AZERI")]
        public const int LangAzeri = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_AZERBAIJANI")]
        public const int LangAzerbaijani = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BANGLA")]
        public const int LangBangla = unchecked((int) 0x45);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BASHKIR")]
        public const int LangBashkir = unchecked((int) 0x6D);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BASQUE")]
        public const int LangBasque = unchecked((int) 0x2D);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BELARUSIAN")]
        public const int LangBelarusian = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BENGALI")]
        public const int LangBengali = unchecked((int) 0x45);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BRETON")]
        public const int LangBreton = unchecked((int) 0x7E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BOSNIAN")]
        public const int LangBosnian = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BOSNIAN_NEUTRAL")]
        public const int LangBosnianNeutral = unchecked((int) 0x781A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_BULGARIAN")]
        public const int LangBulgarian = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CATALAN")]
        public const int LangCatalan = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CENTRAL_KURDISH")]
        public const int LangCentralKurdish = unchecked((int) 0x92);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CHEROKEE")]
        public const int LangCherokee = unchecked((int) 0x5C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CHINESE")]
        public const int LangChinese = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CHINESE_SIMPLIFIED")]
        public const int LangChineseSimplified = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CHINESE_TRADITIONAL")]
        public const int LangChineseTraditional = unchecked((int) 0x7C04);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CORSICAN")]
        public const int LangCorsican = unchecked((int) 0x83);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CROATIAN")]
        public const int LangCroatian = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_CZECH")]
        public const int LangCzech = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_DANISH")]
        public const int LangDanish = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_DARI")]
        public const int LangDari = unchecked((int) 0x8C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_DIVEHI")]
        public const int LangDivehi = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_DUTCH")]
        public const int LangDutch = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ENGLISH")]
        public const int LangEnglish = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ESTONIAN")]
        public const int LangEstonian = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FAEROESE")]
        public const int LangFaeroese = unchecked((int) 0x38);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FARSI")]
        public const int LangFarsi = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FILIPINO")]
        public const int LangFilipino = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FINNISH")]
        public const int LangFinnish = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FRENCH")]
        public const int LangFrench = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FRISIAN")]
        public const int LangFrisian = unchecked((int) 0x62);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_FULAH")]
        public const int LangFulah = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GALICIAN")]
        public const int LangGalician = unchecked((int) 0x56);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GEORGIAN")]
        public const int LangGeorgian = unchecked((int) 0x37);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GERMAN")]
        public const int LangGerman = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GREEK")]
        public const int LangGreek = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GREENLANDIC")]
        public const int LangGreenlandic = unchecked((int) 0x6F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_GUJARATI")]
        public const int LangGujarati = unchecked((int) 0x47);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_HAUSA")]
        public const int LangHausa = unchecked((int) 0x68);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_HAWAIIAN")]
        public const int LangHawaiian = unchecked((int) 0x75);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_HEBREW")]
        public const int LangHebrew = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_HINDI")]
        public const int LangHindi = unchecked((int) 0x39);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_HUNGARIAN")]
        public const int LangHungarian = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ICELANDIC")]
        public const int LangIcelandic = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_IGBO")]
        public const int LangIgbo = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_INDONESIAN")]
        public const int LangIndonesian = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_INUKTITUT")]
        public const int LangInuktitut = unchecked((int) 0x5D);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_IRISH")]
        public const int LangIrish = unchecked((int) 0x3C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ITALIAN")]
        public const int LangItalian = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_JAPANESE")]
        public const int LangJapanese = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KANNADA")]
        public const int LangKannada = unchecked((int) 0x4B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KASHMIRI")]
        public const int LangKashmiri = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KAZAK")]
        public const int LangKazak = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KHMER")]
        public const int LangKhmer = unchecked((int) 0x53);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KICHE")]
        public const int LangKiche = unchecked((int) 0x86);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KINYARWANDA")]
        public const int LangKinyarwanda = unchecked((int) 0x87);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KONKANI")]
        public const int LangKonkani = unchecked((int) 0x57);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KOREAN")]
        public const int LangKorean = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_KYRGYZ")]
        public const int LangKyrgyz = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_LAO")]
        public const int LangLao = unchecked((int) 0x54);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_LATVIAN")]
        public const int LangLatvian = unchecked((int) 0x26);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_LITHUANIAN")]
        public const int LangLithuanian = unchecked((int) 0x27);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_LOWER_SORBIAN")]
        public const int LangLowerSorbian = unchecked((int) 0x2E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_LUXEMBOURGISH")]
        public const int LangLuxembourgish = unchecked((int) 0x6E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MACEDONIAN")]
        public const int LangMacedonian = unchecked((int) 0x2F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MALAY")]
        public const int LangMalay = unchecked((int) 0x3E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MALAYALAM")]
        public const int LangMalayalam = unchecked((int) 0x4C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MALTESE")]
        public const int LangMaltese = unchecked((int) 0x3A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MANIPURI")]
        public const int LangManipuri = unchecked((int) 0x58);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MAORI")]
        public const int LangMaori = unchecked((int) 0x81);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MAPUDUNGUN")]
        public const int LangMapudungun = unchecked((int) 0x7A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MARATHI")]
        public const int LangMarathi = unchecked((int) 0x4E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MOHAWK")]
        public const int LangMohawk = unchecked((int) 0x7C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_MONGOLIAN")]
        public const int LangMongolian = unchecked((int) 0x50);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_NEPALI")]
        public const int LangNepali = unchecked((int) 0x61);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_NORWEGIAN")]
        public const int LangNorwegian = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_OCCITAN")]
        public const int LangOccitan = unchecked((int) 0x82);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ODIA")]
        public const int LangOdia = unchecked((int) 0x48);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ORIYA")]
        public const int LangOriya = unchecked((int) 0x48);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_PASHTO")]
        public const int LangPashto = unchecked((int) 0x63);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_PERSIAN")]
        public const int LangPersian = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_POLISH")]
        public const int LangPolish = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_PORTUGUESE")]
        public const int LangPortuguese = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_PULAR")]
        public const int LangPular = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_PUNJABI")]
        public const int LangPunjabi = unchecked((int) 0x46);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_QUECHUA")]
        public const int LangQuechua = unchecked((int) 0x6B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ROMANIAN")]
        public const int LangRomanian = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ROMANSH")]
        public const int LangRomansh = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_RUSSIAN")]
        public const int LangRussian = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SAKHA")]
        public const int LangSakha = unchecked((int) 0x85);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SAMI")]
        public const int LangSami = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SANSKRIT")]
        public const int LangSanskrit = unchecked((int) 0x4F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SCOTTISH_GAELIC")]
        public const int LangScottishGaelic = unchecked((int) 0x91);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SERBIAN")]
        public const int LangSerbian = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SERBIAN_NEUTRAL")]
        public const int LangSerbianNeutral = unchecked((int) 0x7C1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SINDHI")]
        public const int LangSindhi = unchecked((int) 0x59);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SINHALESE")]
        public const int LangSinhalese = unchecked((int) 0x5B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SLOVAK")]
        public const int LangSlovak = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SLOVENIAN")]
        public const int LangSlovenian = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SOTHO")]
        public const int LangSotho = unchecked((int) 0x6C);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SPANISH")]
        public const int LangSpanish = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SWAHILI")]
        public const int LangSwahili = unchecked((int) 0x41);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SWEDISH")]
        public const int LangSwedish = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_SYRIAC")]
        public const int LangSyriac = unchecked((int) 0x5A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TAJIK")]
        public const int LangTajik = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TAMAZIGHT")]
        public const int LangTamazight = unchecked((int) 0x5F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TAMIL")]
        public const int LangTamil = unchecked((int) 0x49);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TATAR")]
        public const int LangTatar = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TELUGU")]
        public const int LangTelugu = unchecked((int) 0x4A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_THAI")]
        public const int LangThai = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TIBETAN")]
        public const int LangTibetan = unchecked((int) 0x51);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TIGRIGNA")]
        public const int LangTigrigna = unchecked((int) 0x73);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TIGRINYA")]
        public const int LangTigrinya = unchecked((int) 0x73);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TSWANA")]
        public const int LangTswana = unchecked((int) 0x32);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TURKISH")]
        public const int LangTurkish = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_TURKMEN")]
        public const int LangTurkmen = unchecked((int) 0x42);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_UIGHUR")]
        public const int LangUighur = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_UKRAINIAN")]
        public const int LangUkrainian = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_UPPER_SORBIAN")]
        public const int LangUpperSorbian = unchecked((int) 0x2E);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_URDU")]
        public const int LangUrdu = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_UZBEK")]
        public const int LangUzbek = unchecked((int) 0x43);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_VALENCIAN")]
        public const int LangValencian = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_VIETNAMESE")]
        public const int LangVietnamese = unchecked((int) 0x2A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_WELSH")]
        public const int LangWelsh = unchecked((int) 0x52);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_WOLOF")]
        public const int LangWolof = unchecked((int) 0x88);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_XHOSA")]
        public const int LangXhosa = unchecked((int) 0x34);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_YAKUT")]
        public const int LangYakut = unchecked((int) 0x85);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_YI")]
        public const int LangYI = unchecked((int) 0x78);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_YORUBA")]
        public const int LangYoruba = unchecked((int) 0x6A);
        [NativeName("Type", "int")]
        [NativeName("Name", "LANG_ZULU")]
        public const int LangZulu = unchecked((int) 0x35);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_NEUTRAL")]
        public const int SublangNeutral = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DEFAULT")]
        public const int SublangDefault = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SYS_DEFAULT")]
        public const int SublangSysDefault = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CUSTOM_DEFAULT")]
        public const int SublangCustomDefault = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CUSTOM_UNSPECIFIED")]
        public const int SublangCustomUnspecified = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UI_CUSTOM_DEFAULT")]
        public const int SublangUICustomDefault = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AFRIKAANS_SOUTH_AFRICA")]
        public const int SublangAfrikaansSouthAfrica = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ALBANIAN_ALBANIA")]
        public const int SublangAlbanianAlbania = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ALSATIAN_FRANCE")]
        public const int SublangAlsatianFrance = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AMHARIC_ETHIOPIA")]
        public const int SublangAmharicEthiopia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_SAUDI_ARABIA")]
        public const int SublangArabicSaudiArabia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_IRAQ")]
        public const int SublangArabicIraq = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_EGYPT")]
        public const int SublangArabicEgypt = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_LIBYA")]
        public const int SublangArabicLibya = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_ALGERIA")]
        public const int SublangArabicAlgeria = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_MOROCCO")]
        public const int SublangArabicMorocco = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_TUNISIA")]
        public const int SublangArabicTunisia = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_OMAN")]
        public const int SublangArabicOman = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_YEMEN")]
        public const int SublangArabicYemen = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_SYRIA")]
        public const int SublangArabicSyria = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_JORDAN")]
        public const int SublangArabicJordan = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_LEBANON")]
        public const int SublangArabicLebanon = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_KUWAIT")]
        public const int SublangArabicKuwait = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_UAE")]
        public const int SublangArabicUae = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_BAHRAIN")]
        public const int SublangArabicBahrain = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARABIC_QATAR")]
        public const int SublangArabicQatar = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ARMENIAN_ARMENIA")]
        public const int SublangArmenianArmenia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ASSAMESE_INDIA")]
        public const int SublangAssameseIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AZERI_LATIN")]
        public const int SublangAzeriLatin = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AZERI_CYRILLIC")]
        public const int SublangAzeriCyrillic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN")]
        public const int SublangAzerbaijaniAzerbaijanLatin = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC")]
        public const int SublangAzerbaijaniAzerbaijanCyrillic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BANGLA_INDIA")]
        public const int SublangBanglaIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BANGLA_BANGLADESH")]
        public const int SublangBanglaBangladesh = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BASHKIR_RUSSIA")]
        public const int SublangBashkirRussia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BASQUE_BASQUE")]
        public const int SublangBasqueBasque = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BELARUSIAN_BELARUS")]
        public const int SublangBelarusianBelarus = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BENGALI_INDIA")]
        public const int SublangBengaliIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BENGALI_BANGLADESH")]
        public const int SublangBengaliBangladesh = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN")]
        public const int SublangBosnianBosniaHerzegovinaLatin = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC")]
        public const int SublangBosnianBosniaHerzegovinaCyrillic = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BRETON_FRANCE")]
        public const int SublangBretonFrance = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_BULGARIAN_BULGARIA")]
        public const int SublangBulgarianBulgaria = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CATALAN_CATALAN")]
        public const int SublangCatalanCatalan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CENTRAL_KURDISH_IRAQ")]
        public const int SublangCentralKurdishIraq = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHEROKEE_CHEROKEE")]
        public const int SublangCherokeeCherokee = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHINESE_TRADITIONAL")]
        public const int SublangChineseTraditional = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHINESE_SIMPLIFIED")]
        public const int SublangChineseSimplified = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHINESE_HONGKONG")]
        public const int SublangChineseHongkong = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHINESE_SINGAPORE")]
        public const int SublangChineseSingapore = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CHINESE_MACAU")]
        public const int SublangChineseMacau = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CORSICAN_FRANCE")]
        public const int SublangCorsicanFrance = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CZECH_CZECH_REPUBLIC")]
        public const int SublangCzechCzechRepublic = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CROATIAN_CROATIA")]
        public const int SublangCroatianCroatia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN")]
        public const int SublangCroatianBosniaHerzegovinaLatin = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DANISH_DENMARK")]
        public const int SublangDanishDenmark = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DARI_AFGHANISTAN")]
        public const int SublangDariAfghanistan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DIVEHI_MALDIVES")]
        public const int SublangDivehiMaldives = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DUTCH")]
        public const int SublangDutch = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_DUTCH_BELGIAN")]
        public const int SublangDutchBelgian = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_US")]
        public const int SublangEnglishUS = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_UK")]
        public const int SublangEnglishUK = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_AUS")]
        public const int SublangEnglishAus = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_CAN")]
        public const int SublangEnglishCan = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_NZ")]
        public const int SublangEnglishNZ = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_EIRE")]
        public const int SublangEnglishEire = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_SOUTH_AFRICA")]
        public const int SublangEnglishSouthAfrica = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_JAMAICA")]
        public const int SublangEnglishJamaica = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_CARIBBEAN")]
        public const int SublangEnglishCaribbean = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_BELIZE")]
        public const int SublangEnglishBelize = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_TRINIDAD")]
        public const int SublangEnglishTrinidad = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_ZIMBABWE")]
        public const int SublangEnglishZimbabwe = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_PHILIPPINES")]
        public const int SublangEnglishPhilippines = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_INDIA")]
        public const int SublangEnglishIndia = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_MALAYSIA")]
        public const int SublangEnglishMalaysia = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ENGLISH_SINGAPORE")]
        public const int SublangEnglishSingapore = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ESTONIAN_ESTONIA")]
        public const int SublangEstonianEstonia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FAEROESE_FAROE_ISLANDS")]
        public const int SublangFaeroeseFaroeIslands = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FILIPINO_PHILIPPINES")]
        public const int SublangFilipinoPhilippines = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FINNISH_FINLAND")]
        public const int SublangFinnishFinland = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH")]
        public const int SublangFrench = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH_BELGIAN")]
        public const int SublangFrenchBelgian = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH_CANADIAN")]
        public const int SublangFrenchCanadian = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH_SWISS")]
        public const int SublangFrenchSwiss = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH_LUXEMBOURG")]
        public const int SublangFrenchLuxembourg = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRENCH_MONACO")]
        public const int SublangFrenchMonaco = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FRISIAN_NETHERLANDS")]
        public const int SublangFrisianNetherlands = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_FULAH_SENEGAL")]
        public const int SublangFulahSenegal = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GALICIAN_GALICIAN")]
        public const int SublangGalicianGalician = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GEORGIAN_GEORGIA")]
        public const int SublangGeorgianGeorgia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GERMAN")]
        public const int SublangGerman = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GERMAN_SWISS")]
        public const int SublangGermanSwiss = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GERMAN_AUSTRIAN")]
        public const int SublangGermanAustrian = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GERMAN_LUXEMBOURG")]
        public const int SublangGermanLuxembourg = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GERMAN_LIECHTENSTEIN")]
        public const int SublangGermanLiechtenstein = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GREEK_GREECE")]
        public const int SublangGreekGreece = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GREENLANDIC_GREENLAND")]
        public const int SublangGreenlandicGreenland = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_GUJARATI_INDIA")]
        public const int SublangGujaratiIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_HAUSA_NIGERIA_LATIN")]
        public const int SublangHausaNigeriaLatin = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_HAWAIIAN_US")]
        public const int SublangHawaiianUS = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_HEBREW_ISRAEL")]
        public const int SublangHebrewIsrael = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_HINDI_INDIA")]
        public const int SublangHindiIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_HUNGARIAN_HUNGARY")]
        public const int SublangHungarianHungary = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ICELANDIC_ICELAND")]
        public const int SublangIcelandicIceland = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_IGBO_NIGERIA")]
        public const int SublangIgboNigeria = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_INDONESIAN_INDONESIA")]
        public const int SublangIndonesianIndonesia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_INUKTITUT_CANADA")]
        public const int SublangInuktitutCanada = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_INUKTITUT_CANADA_LATIN")]
        public const int SublangInuktitutCanadaLatin = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_IRISH_IRELAND")]
        public const int SublangIrishIreland = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ITALIAN")]
        public const int SublangItalian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ITALIAN_SWISS")]
        public const int SublangItalianSwiss = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_JAPANESE_JAPAN")]
        public const int SublangJapaneseJapan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KANNADA_INDIA")]
        public const int SublangKannadaIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KASHMIRI_SASIA")]
        public const int SublangKashmiriSasia = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KASHMIRI_INDIA")]
        public const int SublangKashmiriIndia = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KAZAK_KAZAKHSTAN")]
        public const int SublangKazakKazakhstan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KHMER_CAMBODIA")]
        public const int SublangKhmerCambodia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KICHE_GUATEMALA")]
        public const int SublangKicheGuatemala = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KINYARWANDA_RWANDA")]
        public const int SublangKinyarwandaRwanda = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KONKANI_INDIA")]
        public const int SublangKonkaniIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KOREAN")]
        public const int SublangKorean = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_KYRGYZ_KYRGYZSTAN")]
        public const int SublangKyrgyzKyrgyzstan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_LAO_LAO")]
        public const int SublangLaoLao = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_LATVIAN_LATVIA")]
        public const int SublangLatvianLatvia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_LITHUANIAN")]
        public const int SublangLithuanian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_LOWER_SORBIAN_GERMANY")]
        public const int SublangLowerSorbianGermany = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_LUXEMBOURGISH_LUXEMBOURG")]
        public const int SublangLuxembourgishLuxembourg = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MACEDONIAN_MACEDONIA")]
        public const int SublangMacedonianMacedonia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MALAY_MALAYSIA")]
        public const int SublangMalayMalaysia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MALAY_BRUNEI_DARUSSALAM")]
        public const int SublangMalayBruneiDarussalam = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MALAYALAM_INDIA")]
        public const int SublangMalayalamIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MALTESE_MALTA")]
        public const int SublangMalteseMalta = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MAORI_NEW_ZEALAND")]
        public const int SublangMaoriNewZealand = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MAPUDUNGUN_CHILE")]
        public const int SublangMapudungunChile = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MARATHI_INDIA")]
        public const int SublangMarathiIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MOHAWK_MOHAWK")]
        public const int SublangMohawkMohawk = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA")]
        public const int SublangMongolianCyrillicMongolia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_MONGOLIAN_PRC")]
        public const int SublangMongolianPrc = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_NEPALI_INDIA")]
        public const int SublangNepaliIndia = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_NEPALI_NEPAL")]
        public const int SublangNepaliNepal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_NORWEGIAN_BOKMAL")]
        public const int SublangNorwegianBokmal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_NORWEGIAN_NYNORSK")]
        public const int SublangNorwegianNynorsk = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_OCCITAN_FRANCE")]
        public const int SublangOccitanFrance = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ODIA_INDIA")]
        public const int SublangOdiaIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ORIYA_INDIA")]
        public const int SublangOriyaIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PASHTO_AFGHANISTAN")]
        public const int SublangPashtoAfghanistan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PERSIAN_IRAN")]
        public const int SublangPersianIran = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_POLISH_POLAND")]
        public const int SublangPolishPoland = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PORTUGUESE")]
        public const int SublangPortuguese = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PORTUGUESE_BRAZILIAN")]
        public const int SublangPortugueseBrazilian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PULAR_SENEGAL")]
        public const int SublangPularSenegal = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PUNJABI_INDIA")]
        public const int SublangPunjabiIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_PUNJABI_PAKISTAN")]
        public const int SublangPunjabiPakistan = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_QUECHUA_BOLIVIA")]
        public const int SublangQuechuaBolivia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_QUECHUA_ECUADOR")]
        public const int SublangQuechuaEcuador = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_QUECHUA_PERU")]
        public const int SublangQuechuaPeru = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ROMANIAN_ROMANIA")]
        public const int SublangRomanianRomania = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ROMANSH_SWITZERLAND")]
        public const int SublangRomanshSwitzerland = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_RUSSIAN_RUSSIA")]
        public const int SublangRussianRussia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAKHA_RUSSIA")]
        public const int SublangSakhaRussia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_NORTHERN_NORWAY")]
        public const int SublangSamiNorthernNorway = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_NORTHERN_SWEDEN")]
        public const int SublangSamiNorthernSweden = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_NORTHERN_FINLAND")]
        public const int SublangSamiNorthernFinland = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_LULE_NORWAY")]
        public const int SublangSamiLuleNorway = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_LULE_SWEDEN")]
        public const int SublangSamiLuleSweden = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_SOUTHERN_NORWAY")]
        public const int SublangSamiSouthernNorway = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_SOUTHERN_SWEDEN")]
        public const int SublangSamiSouthernSweden = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_SKOLT_FINLAND")]
        public const int SublangSamiSkoltFinland = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SAMI_INARI_FINLAND")]
        public const int SublangSamiInariFinland = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SANSKRIT_INDIA")]
        public const int SublangSanskritIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SCOTTISH_GAELIC")]
        public const int SublangScottishGaelic = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN")]
        public const int SublangSerbianBosniaHerzegovinaLatin = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC")]
        public const int SublangSerbianBosniaHerzegovinaCyrillic = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_MONTENEGRO_LATIN")]
        public const int SublangSerbianMontenegroLatin = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC")]
        public const int SublangSerbianMontenegroCyrillic = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_SERBIA_LATIN")]
        public const int SublangSerbianSerbiaLatin = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_SERBIA_CYRILLIC")]
        public const int SublangSerbianSerbiaCyrillic = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_CROATIA")]
        public const int SublangSerbianCroatia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_LATIN")]
        public const int SublangSerbianLatin = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SERBIAN_CYRILLIC")]
        public const int SublangSerbianCyrillic = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SINDHI_INDIA")]
        public const int SublangSindhiIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SINDHI_PAKISTAN")]
        public const int SublangSindhiPakistan = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SINDHI_AFGHANISTAN")]
        public const int SublangSindhiAfghanistan = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SINHALESE_SRI_LANKA")]
        public const int SublangSinhaleseSriLanka = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA")]
        public const int SublangSothoNorthernSouthAfrica = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SLOVAK_SLOVAKIA")]
        public const int SublangSlovakSlovakia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SLOVENIAN_SLOVENIA")]
        public const int SublangSlovenianSlovenia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH")]
        public const int SublangSpanish = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_MEXICAN")]
        public const int SublangSpanishMexican = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_MODERN")]
        public const int SublangSpanishModern = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_GUATEMALA")]
        public const int SublangSpanishGuatemala = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_COSTA_RICA")]
        public const int SublangSpanishCostaRica = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_PANAMA")]
        public const int SublangSpanishPanama = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_DOMINICAN_REPUBLIC")]
        public const int SublangSpanishDominicanRepublic = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_VENEZUELA")]
        public const int SublangSpanishVenezuela = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_COLOMBIA")]
        public const int SublangSpanishColombia = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_PERU")]
        public const int SublangSpanishPeru = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_ARGENTINA")]
        public const int SublangSpanishArgentina = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_ECUADOR")]
        public const int SublangSpanishEcuador = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_CHILE")]
        public const int SublangSpanishChile = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_URUGUAY")]
        public const int SublangSpanishUruguay = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_PARAGUAY")]
        public const int SublangSpanishParaguay = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_BOLIVIA")]
        public const int SublangSpanishBolivia = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_EL_SALVADOR")]
        public const int SublangSpanishELSalvador = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_HONDURAS")]
        public const int SublangSpanishHonduras = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_NICARAGUA")]
        public const int SublangSpanishNicaragua = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_PUERTO_RICO")]
        public const int SublangSpanishPuertoRico = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SPANISH_US")]
        public const int SublangSpanishUS = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SWAHILI_KENYA")]
        public const int SublangSwahiliKenya = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SWEDISH")]
        public const int SublangSwedish = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SWEDISH_FINLAND")]
        public const int SublangSwedishFinland = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_SYRIAC_SYRIA")]
        public const int SublangSyriacSyria = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TAJIK_TAJIKISTAN")]
        public const int SublangTajikTajikistan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TAMAZIGHT_ALGERIA_LATIN")]
        public const int SublangTamazightAlgeriaLatin = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TAMAZIGHT_MOROCCO_TIFINAGH")]
        public const int SublangTamazightMoroccoTifinagh = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TAMIL_INDIA")]
        public const int SublangTamilIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TAMIL_SRI_LANKA")]
        public const int SublangTamilSriLanka = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TATAR_RUSSIA")]
        public const int SublangTatarRussia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TELUGU_INDIA")]
        public const int SublangTeluguIndia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_THAI_THAILAND")]
        public const int SublangThaiThailand = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TIBETAN_PRC")]
        public const int SublangTibetanPrc = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TIGRIGNA_ERITREA")]
        public const int SublangTigrignaEritrea = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TIGRINYA_ERITREA")]
        public const int SublangTigrinyaEritrea = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TIGRINYA_ETHIOPIA")]
        public const int SublangTigrinyaEthiopia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TSWANA_BOTSWANA")]
        public const int SublangTswanaBotswana = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TSWANA_SOUTH_AFRICA")]
        public const int SublangTswanaSouthAfrica = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TURKISH_TURKEY")]
        public const int SublangTurkishTurkey = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_TURKMEN_TURKMENISTAN")]
        public const int SublangTurkmenTurkmenistan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UIGHUR_PRC")]
        public const int SublangUighurPrc = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UKRAINIAN_UKRAINE")]
        public const int SublangUkrainianUkraine = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UPPER_SORBIAN_GERMANY")]
        public const int SublangUpperSorbianGermany = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_URDU_PAKISTAN")]
        public const int SublangUrduPakistan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_URDU_INDIA")]
        public const int SublangUrduIndia = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UZBEK_LATIN")]
        public const int SublangUzbekLatin = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_UZBEK_CYRILLIC")]
        public const int SublangUzbekCyrillic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_VALENCIAN_VALENCIA")]
        public const int SublangValencianValencia = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_VIETNAMESE_VIETNAM")]
        public const int SublangVietnameseVietnam = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_WELSH_UNITED_KINGDOM")]
        public const int SublangWelshUnitedKingdom = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_WOLOF_SENEGAL")]
        public const int SublangWolofSenegal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_XHOSA_SOUTH_AFRICA")]
        public const int SublangXhosaSouthAfrica = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_YAKUT_RUSSIA")]
        public const int SublangYakutRussia = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_YI_PRC")]
        public const int SublangYIPrc = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_YORUBA_NIGERIA")]
        public const int SublangYorubaNigeria = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUBLANG_ZULU_SOUTH_AFRICA")]
        public const int SublangZuluSouthAfrica = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_DEFAULT")]
        public const int SortDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_INVARIANT_MATH")]
        public const int SortInvariantMath = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_JAPANESE_XJIS")]
        public const int SortJapaneseXjis = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_JAPANESE_UNICODE")]
        public const int SortJapaneseUnicode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_JAPANESE_RADICALSTROKE")]
        public const int SortJapaneseRadicalstroke = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_BIG5")]
        public const int SortChineseBig5 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_PRCP")]
        public const int SortChinesePrcp = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_UNICODE")]
        public const int SortChineseUnicode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_PRC")]
        public const int SortChinesePrc = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_BOPOMOFO")]
        public const int SortChineseBopomofo = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_CHINESE_RADICALSTROKE")]
        public const int SortChineseRadicalstroke = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_KOREAN_KSC")]
        public const int SortKoreanKsc = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_KOREAN_UNICODE")]
        public const int SortKoreanUnicode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_GERMAN_PHONE_BOOK")]
        public const int SortGermanPhoneBook = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_HUNGARIAN_DEFAULT")]
        public const int SortHungarianDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_HUNGARIAN_TECHNICAL")]
        public const int SortHungarianTechnical = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_GEORGIAN_TRADITIONAL")]
        public const int SortGeorgianTraditional = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SORT_GEORGIAN_MODERN")]
        public const int SortGeorgianModern = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "NLS_VALID_LOCALE_MASK")]
        public const int NlsValidLocaleMask = unchecked((int) 0xFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCALE_NAME_MAX_LENGTH")]
        public const int LocaleNameMaxLength = unchecked((int) 0x55);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCALE_TRANSIENT_KEYBOARD1")]
        public const int LocaleTransientKeyboard1 = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCALE_TRANSIENT_KEYBOARD2")]
        public const int LocaleTransientKeyboard2 = unchecked((int) 0x2400);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCALE_TRANSIENT_KEYBOARD3")]
        public const int LocaleTransientKeyboard3 = unchecked((int) 0x2800);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCALE_TRANSIENT_KEYBOARD4")]
        public const int LocaleTransientKeyboard4 = unchecked((int) 0x2C00);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_WAIT_OBJECTS")]
        public const int MaximumWaitObjects = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_SUSPEND_COUNT")]
        public const int MaximumSuspendCount = unchecked((int) 0x7F);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_ARM64")]
        public const int ContextArm64 = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "CONTEXT_ARM64_UNWOUND_TO_CALL")]
        public const int ContextArm64UnwoundToCall = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "CONTEXT_ARM64_RET_TO_GUEST")]
        public const int ContextArm64RetToGuest = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "CONTEXT_UNWOUND_TO_CALL")]
        public const int ContextUnwoundToCall = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "CONTEXT_RET_TO_GUEST")]
        public const int ContextRetToGuest = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ARM64_MAX_BREAKPOINTS")]
        public const int Arm64MaxBreakpoints = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ARM64_MAX_WATCHPOINTS")]
        public const int Arm64MaxWatchpoints = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "UNW_FLAG_NHANDLER")]
        public const int UnwFlagNhandler = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "UNW_FLAG_EHANDLER")]
        public const int UnwFlagEhandler = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "UNW_FLAG_UHANDLER")]
        public const int UnwFlagUhandler = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "NONVOL_INT_NUMREG_ARM64")]
        public const int NonvolIntNumregArm64 = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "NONVOL_FP_NUMREG_ARM64")]
        public const int NonvolFPNumregArm64 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "_MM_HINT_T0")]
        public const int MMHintT0 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "_MM_HINT_T1")]
        public const int MMHintT1 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "_MM_HINT_T2")]
        public const int MMHintT2 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "_MM_HINT_NTA")]
        public const int MMHintNta = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_TEMPORAL_LEVEL_1")]
        public const int PFTemporalLevel1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_TEMPORAL_LEVEL_2")]
        public const int PFTemporalLevel2 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_TEMPORAL_LEVEL_3")]
        public const int PFTemporalLevel3 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_NON_TEMPORAL_LEVEL_ALL")]
        public const int PFNonTemporalLevelAll = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_READ_FAULT")]
        public const int ExceptionReadFault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_WRITE_FAULT")]
        public const int ExceptionWriteFault = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_EXECUTE_FAULT")]
        public const int ExceptionExecuteFault = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SIZE_OF_80387_REGISTERS")]
        public const int SizeOf80387Registers = unchecked((int) 0x50);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_i386")]
        public const int ContextI386 = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_i486")]
        public const int ContextI486 = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_EXCEPTION_ACTIVE")]
        public const int ContextExceptionActive = unchecked((int) 0x8000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_SERVICE_ACTIVE")]
        public const int ContextServiceActive = unchecked((int) 0x10000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "CONTEXT_EXCEPTION_REQUEST")]
        public const int ContextExceptionRequest = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "CONTEXT_EXCEPTION_REPORTING")]
        public const uint ContextExceptionReporting = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_SUPPORTED_EXTENSION")]
        public const int MaximumSupportedExtension = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_CONTEXT_i386")]
        public const int Wow64ContextI386 = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_CONTEXT_i486")]
        public const int Wow64ContextI486 = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_CONTEXT_EXCEPTION_ACTIVE")]
        public const int Wow64ContextExceptionActive = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_CONTEXT_SERVICE_ACTIVE")]
        public const int Wow64ContextServiceActive = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_CONTEXT_EXCEPTION_REQUEST")]
        public const int Wow64ContextExceptionRequest = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "WOW64_CONTEXT_EXCEPTION_REPORTING")]
        public const uint Wow64ContextExceptionReporting = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_SIZE_OF_80387_REGISTERS")]
        public const int Wow64SizeOf80387Registers = unchecked((int) 0x50);
        [NativeName("Type", "int")]
        [NativeName("Name", "WOW64_MAXIMUM_SUPPORTED_EXTENSION")]
        public const int Wow64MaximumSupportedExtension = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_NONCONTINUABLE")]
        public const int ExceptionNoncontinuable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_UNWINDING")]
        public const int ExceptionUnwinding = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_EXIT_UNWIND")]
        public const int ExceptionExitUnwind = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_STACK_INVALID")]
        public const int ExceptionStackInvalid = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_NESTED_CALL")]
        public const int ExceptionNestedCall = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_TARGET_UNWIND")]
        public const int ExceptionTargetUnwind = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_COLLIDED_UNWIND")]
        public const int ExceptionCollidedUnwind = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_SOFTWARE_ORIGINATE")]
        public const int ExceptionSoftwareOriginate = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_MAXIMUM_PARAMETERS")]
        public const int ExceptionMaximumParameters = unchecked((int) 0xF);
        [NativeName("Type", "long")]
        [NativeName("Name", "DELETE")]
        public const int Delete = unchecked((int) 0x10000);
        [NativeName("Type", "long")]
        [NativeName("Name", "READ_CONTROL")]
        public const int ReadControl = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "WRITE_DAC")]
        public const int WriteDac = unchecked((int) 0x40000);
        [NativeName("Type", "long")]
        [NativeName("Name", "WRITE_OWNER")]
        public const int WriteOwner = unchecked((int) 0x80000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SYNCHRONIZE")]
        public const int Synchronize = unchecked((int) 0x100000);
        [NativeName("Type", "long")]
        [NativeName("Name", "STANDARD_RIGHTS_REQUIRED")]
        public const int StandardRightsRequired = unchecked((int) 0xF0000);
        [NativeName("Type", "long")]
        [NativeName("Name", "STANDARD_RIGHTS_READ")]
        public const int StandardRightsRead = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "STANDARD_RIGHTS_WRITE")]
        public const int StandardRightsWrite = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "STANDARD_RIGHTS_EXECUTE")]
        public const int StandardRightsExecute = unchecked((int) 0x20000);
        [NativeName("Type", "long")]
        [NativeName("Name", "STANDARD_RIGHTS_ALL")]
        public const int StandardRightsAll = unchecked((int) 0x1F0000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SPECIFIC_RIGHTS_ALL")]
        public const int SpecificRightsAll = unchecked((int) 0xFFFF);
        [NativeName("Type", "long")]
        [NativeName("Name", "ACCESS_SYSTEM_SECURITY")]
        public const int AccessSystemSecurity = unchecked((int) 0x1000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "MAXIMUM_ALLOWED")]
        public const int MaximumAllowed = unchecked((int) 0x2000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "GENERIC_READ")]
        public const uint GenericRead = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "GENERIC_WRITE")]
        public const int GenericWrite = unchecked((int) 0x40000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "GENERIC_EXECUTE")]
        public const int GenericExecute = unchecked((int) 0x20000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "GENERIC_ALL")]
        public const int GenericAll = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SID_REVISION")]
        public const int SidRevision = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SID_MAX_SUB_AUTHORITIES")]
        public const int SidMaxSubAuthorities = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SID_RECOMMENDED_SUB_AUTHORITIES")]
        public const int SidRecommendedSubAuthorities = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SID_HASH_SIZE")]
        public const int SidHashSize = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NULL_RID")]
        public const int SecurityNullRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WORLD_RID")]
        public const int SecurityWorldRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_RID")]
        public const int SecurityLocalRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_LOGON_RID")]
        public const int SecurityLocalLogonRid = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CREATOR_OWNER_RID")]
        public const int SecurityCreatorOwnerRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CREATOR_GROUP_RID")]
        public const int SecurityCreatorGroupRid = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CREATOR_OWNER_SERVER_RID")]
        public const int SecurityCreatorOwnerServerRid = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CREATOR_GROUP_SERVER_RID")]
        public const int SecurityCreatorGroupServerRid = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CREATOR_OWNER_RIGHTS_RID")]
        public const int SecurityCreatorOwnerRightsRid = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_DIALUP_RID")]
        public const int SecurityDialupRid = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NETWORK_RID")]
        public const int SecurityNetworkRid = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BATCH_RID")]
        public const int SecurityBatchRid = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_INTERACTIVE_RID")]
        public const int SecurityInteractiveRid = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOGON_IDS_RID")]
        public const int SecurityLogonIdsRid = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOGON_IDS_RID_COUNT")]
        public const int SecurityLogonIdsRidCount = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_SERVICE_RID")]
        public const int SecurityServiceRid = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_ANONYMOUS_LOGON_RID")]
        public const int SecurityAnonymousLogonRid = unchecked((int) 0x7);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROXY_RID")]
        public const int SecurityProxyRid = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_ENTERPRISE_CONTROLLERS_RID")]
        public const int SecurityEnterpriseControllersRid = unchecked((int) 0x9);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_SERVER_LOGON_RID")]
        public const int SecurityServerLogonRid = unchecked((int) 0x9);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PRINCIPAL_SELF_RID")]
        public const int SecurityPrincipalSelfRid = unchecked((int) 0xA);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATED_USER_RID")]
        public const int SecurityAuthenticatedUserRid = unchecked((int) 0xB);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_RESTRICTED_CODE_RID")]
        public const int SecurityRestrictedCodeRid = unchecked((int) 0xC);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_TERMINAL_SERVER_RID")]
        public const int SecurityTerminalServerRid = unchecked((int) 0xD);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_REMOTE_LOGON_RID")]
        public const int SecurityRemoteLogonRid = unchecked((int) 0xE);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_THIS_ORGANIZATION_RID")]
        public const int SecurityThisOrganizationRid = unchecked((int) 0xF);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_IUSER_RID")]
        public const int SecurityIuserRid = unchecked((int) 0x11);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_SYSTEM_RID")]
        public const int SecurityLocalSystemRid = unchecked((int) 0x12);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_SERVICE_RID")]
        public const int SecurityLocalServiceRid = unchecked((int) 0x13);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NETWORK_SERVICE_RID")]
        public const int SecurityNetworkServiceRid = unchecked((int) 0x14);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NT_NON_UNIQUE")]
        public const int SecurityNTNonUnique = unchecked((int) 0x15);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT")]
        public const int SecurityNTNonUniqueSubAuthCount = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID")]
        public const int SecurityEnterpriseReadonlyControllersRid = unchecked((int) 0x16);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BUILTIN_DOMAIN_RID")]
        public const int SecurityBuiltinDomainRid = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WRITE_RESTRICTED_CODE_RID")]
        public const int SecurityWriteRestrictedCodeRid = unchecked((int) 0x21);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PACKAGE_BASE_RID")]
        public const int SecurityPackageBaseRid = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PACKAGE_RID_COUNT")]
        public const int SecurityPackageRidCount = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PACKAGE_NTLM_RID")]
        public const int SecurityPackageNtlmRid = unchecked((int) 0xA);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PACKAGE_SCHANNEL_RID")]
        public const int SecurityPackageSchannelRid = unchecked((int) 0xE);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PACKAGE_DIGEST_RID")]
        public const int SecurityPackageDigestRid = unchecked((int) 0x15);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CRED_TYPE_BASE_RID")]
        public const int SecurityCredTypeBaseRid = unchecked((int) 0x41);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CRED_TYPE_RID_COUNT")]
        public const int SecurityCredTypeRidCount = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CRED_TYPE_THIS_ORG_CERT_RID")]
        public const int SecurityCredTypeThisOrgCertRid = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MIN_BASE_RID")]
        public const int SecurityMinBaseRid = unchecked((int) 0x50);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_SERVICE_ID_BASE_RID")]
        public const int SecurityServiceIDBaseRid = unchecked((int) 0x50);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_SERVICE_ID_RID_COUNT")]
        public const int SecurityServiceIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_RESERVED_ID_BASE_RID")]
        public const int SecurityReservedIDBaseRid = unchecked((int) 0x51);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_APPPOOL_ID_BASE_RID")]
        public const int SecurityApppoolIDBaseRid = unchecked((int) 0x52);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_APPPOOL_ID_RID_COUNT")]
        public const int SecurityApppoolIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_VIRTUALSERVER_ID_BASE_RID")]
        public const int SecurityVirtualserverIDBaseRid = unchecked((int) 0x53);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_VIRTUALSERVER_ID_RID_COUNT")]
        public const int SecurityVirtualserverIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_USERMODEDRIVERHOST_ID_BASE_RID")]
        public const int SecurityUsermodedriverhostIDBaseRid = unchecked((int) 0x54);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT")]
        public const int SecurityUsermodedriverhostIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID")]
        public const int SecurityCloudInfrastructureServicesIDBaseRid = unchecked((int) 0x55);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT")]
        public const int SecurityCloudInfrastructureServicesIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WMIHOST_ID_BASE_RID")]
        public const int SecurityWmihostIDBaseRid = unchecked((int) 0x56);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WMIHOST_ID_RID_COUNT")]
        public const int SecurityWmihostIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_TASK_ID_BASE_RID")]
        public const int SecurityTaskIDBaseRid = unchecked((int) 0x57);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_NFS_ID_BASE_RID")]
        public const int SecurityNfsIDBaseRid = unchecked((int) 0x58);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_COM_ID_BASE_RID")]
        public const int SecurityComIDBaseRid = unchecked((int) 0x59);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WINDOW_MANAGER_BASE_RID")]
        public const int SecurityWindowManagerBaseRid = unchecked((int) 0x5A);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_RDV_GFX_BASE_RID")]
        public const int SecurityRdvGfxBaseRid = unchecked((int) 0x5B);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_DASHOST_ID_BASE_RID")]
        public const int SecurityDashostIDBaseRid = unchecked((int) 0x5C);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_DASHOST_ID_RID_COUNT")]
        public const int SecurityDashostIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_USERMANAGER_ID_BASE_RID")]
        public const int SecurityUsermanagerIDBaseRid = unchecked((int) 0x5D);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_USERMANAGER_ID_RID_COUNT")]
        public const int SecurityUsermanagerIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WINRM_ID_BASE_RID")]
        public const int SecurityWinrmIDBaseRid = unchecked((int) 0x5E);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WINRM_ID_RID_COUNT")]
        public const int SecurityWinrmIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CCG_ID_BASE_RID")]
        public const int SecurityCcgIDBaseRid = unchecked((int) 0x5F);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_UMFD_BASE_RID")]
        public const int SecurityUmfdBaseRid = unchecked((int) 0x60);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_VIRTUALACCOUNT_ID_RID_COUNT")]
        public const int SecurityVirtualaccountIDRidCount = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MAX_BASE_RID")]
        public const int SecurityMaxBaseRid = unchecked((int) 0x6F);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MAX_ALWAYS_FILTERED")]
        public const int SecurityMaxAlwaysFiltered = unchecked((int) 0x3E7);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MIN_NEVER_FILTERED")]
        public const int SecurityMinNeverFiltered = unchecked((int) 0x3E8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_OTHER_ORGANIZATION_RID")]
        public const int SecurityOtherOrganizationRid = unchecked((int) 0x3E8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_WINDOWSMOBILE_ID_BASE_RID")]
        public const int SecurityWindowsmobileIDBaseRid = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_INSTALLER_GROUP_CAPABILITY_BASE")]
        public const int SecurityInstallerGroupCapabilityBase = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT")]
        public const int SecurityInstallerGroupCapabilityRidCount = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_INSTALLER_CAPABILITY_RID_COUNT")]
        public const int SecurityInstallerCapabilityRidCount = unchecked((int) 0xA);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_ACCOUNT_RID")]
        public const int SecurityLocalAccountRid = unchecked((int) 0x71);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID")]
        public const int SecurityLocalAccountAndAdminRid = unchecked((int) 0x72);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED")]
        public const int DomainGroupRidAuthorizationDataIsCompounded = unchecked((int) 0x1F0);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS")]
        public const int DomainGroupRidAuthorizationDataContainsClaims = unchecked((int) 0x1F1);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS")]
        public const int DomainGroupRidEnterpriseReadonlyDomainControllers = unchecked((int) 0x1F2);
        [NativeName("Type", "long")]
        [NativeName("Name", "FOREST_USER_RID_MAX")]
        public const int ForestUserRidMax = unchecked((int) 0x1F3);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_ADMIN")]
        public const int DomainUserRidAdmin = unchecked((int) 0x1F4);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_GUEST")]
        public const int DomainUserRidGuest = unchecked((int) 0x1F5);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_KRBTGT")]
        public const int DomainUserRidKrbtgt = unchecked((int) 0x1F6);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_DEFAULT_ACCOUNT")]
        public const int DomainUserRidDefaultAccount = unchecked((int) 0x1F7);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_WDAG_ACCOUNT")]
        public const int DomainUserRidWdagAccount = unchecked((int) 0x1F8);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_USER_RID_MAX")]
        public const int DomainUserRidMax = unchecked((int) 0x3E7);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_ADMINS")]
        public const int DomainGroupRidAdmins = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_USERS")]
        public const int DomainGroupRidUsers = unchecked((int) 0x201);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_GUESTS")]
        public const int DomainGroupRidGuests = unchecked((int) 0x202);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_COMPUTERS")]
        public const int DomainGroupRidComputers = unchecked((int) 0x203);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_CONTROLLERS")]
        public const int DomainGroupRidControllers = unchecked((int) 0x204);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_CERT_ADMINS")]
        public const int DomainGroupRidCertAdmins = unchecked((int) 0x205);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_SCHEMA_ADMINS")]
        public const int DomainGroupRidSchemaAdmins = unchecked((int) 0x206);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_ENTERPRISE_ADMINS")]
        public const int DomainGroupRidEnterpriseAdmins = unchecked((int) 0x207);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_POLICY_ADMINS")]
        public const int DomainGroupRidPolicyAdmins = unchecked((int) 0x208);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_READONLY_CONTROLLERS")]
        public const int DomainGroupRidReadonlyControllers = unchecked((int) 0x209);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS")]
        public const int DomainGroupRidCloneableControllers = unchecked((int) 0x20A);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_CDC_RESERVED")]
        public const int DomainGroupRidCdcReserved = unchecked((int) 0x20C);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_PROTECTED_USERS")]
        public const int DomainGroupRidProtectedUsers = unchecked((int) 0x20D);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_KEY_ADMINS")]
        public const int DomainGroupRidKeyAdmins = unchecked((int) 0x20E);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS")]
        public const int DomainGroupRidEnterpriseKeyAdmins = unchecked((int) 0x20F);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_ADMINS")]
        public const int DomainAliasRidAdmins = unchecked((int) 0x220);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_USERS")]
        public const int DomainAliasRidUsers = unchecked((int) 0x221);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_GUESTS")]
        public const int DomainAliasRidGuests = unchecked((int) 0x222);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_POWER_USERS")]
        public const int DomainAliasRidPowerUsers = unchecked((int) 0x223);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_ACCOUNT_OPS")]
        public const int DomainAliasRidAccountOps = unchecked((int) 0x224);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_SYSTEM_OPS")]
        public const int DomainAliasRidSystemOps = unchecked((int) 0x225);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_PRINT_OPS")]
        public const int DomainAliasRidPrintOps = unchecked((int) 0x226);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_BACKUP_OPS")]
        public const int DomainAliasRidBackupOps = unchecked((int) 0x227);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_REPLICATOR")]
        public const int DomainAliasRidReplicator = unchecked((int) 0x228);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_RAS_SERVERS")]
        public const int DomainAliasRidRasServers = unchecked((int) 0x229);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_PREW2KCOMPACCESS")]
        public const int DomainAliasRidPrew2Kcompaccess = unchecked((int) 0x22A);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS")]
        public const int DomainAliasRidRemoteDesktopUsers = unchecked((int) 0x22B);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS")]
        public const int DomainAliasRidNetworkConfigurationOps = unchecked((int) 0x22C);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS")]
        public const int DomainAliasRidIncomingForestTrustBuilders = unchecked((int) 0x22D);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_MONITORING_USERS")]
        public const int DomainAliasRidMonitoringUsers = unchecked((int) 0x22E);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_LOGGING_USERS")]
        public const int DomainAliasRidLoggingUsers = unchecked((int) 0x22F);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS")]
        public const int DomainAliasRidAuthorizationaccess = unchecked((int) 0x230);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS")]
        public const int DomainAliasRidTSLicenseServers = unchecked((int) 0x231);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_DCOM_USERS")]
        public const int DomainAliasRidDcomUsers = unchecked((int) 0x232);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_IUSERS")]
        public const int DomainAliasRidIusers = unchecked((int) 0x238);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_CRYPTO_OPERATORS")]
        public const int DomainAliasRidCryptoOperators = unchecked((int) 0x239);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP")]
        public const int DomainAliasRidCacheablePrincipalsGroup = unchecked((int) 0x23B);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP")]
        public const int DomainAliasRidNonCacheablePrincipalsGroup = unchecked((int) 0x23C);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP")]
        public const int DomainAliasRidEventLogReadersGroup = unchecked((int) 0x23D);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP")]
        public const int DomainAliasRidCertsvcDcomAccessGroup = unchecked((int) 0x23E);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS")]
        public const int DomainAliasRidRdsRemoteAccessServers = unchecked((int) 0x23F);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS")]
        public const int DomainAliasRidRdsEndpointServers = unchecked((int) 0x240);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS")]
        public const int DomainAliasRidRdsManagementServers = unchecked((int) 0x241);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_HYPER_V_ADMINS")]
        public const int DomainAliasRidHyperVAdmins = unchecked((int) 0x242);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS")]
        public const int DomainAliasRidAccessControlAssistanceOps = unchecked((int) 0x243);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS")]
        public const int DomainAliasRidRemoteManagementUsers = unchecked((int) 0x244);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT")]
        public const int DomainAliasRidDefaultAccount = unchecked((int) 0x245);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS")]
        public const int DomainAliasRidStorageReplicaAdmins = unchecked((int) 0x246);
        [NativeName("Type", "long")]
        [NativeName("Name", "DOMAIN_ALIAS_RID_DEVICE_OWNERS")]
        public const int DomainAliasRidDeviceOwners = unchecked((int) 0x247);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_APP_PACKAGE_BASE_RID")]
        public const int SecurityAppPackageBaseRid = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT")]
        public const int SecurityBuiltinAppPackageRidCount = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_APP_PACKAGE_RID_COUNT")]
        public const int SecurityAppPackageRidCount = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_BASE_RID")]
        public const int SecurityCapabilityBaseRid = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_CAPABILITY_APP_RID")]
        public const int SecurityCapabilityAppRid = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BUILTIN_CAPABILITY_RID_COUNT")]
        public const int SecurityBuiltinCapabilityRidCount = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_RID_COUNT")]
        public const int SecurityCapabilityRidCount = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PARENT_PACKAGE_RID_COUNT")]
        public const int SecurityParentPackageRidCount = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CHILD_PACKAGE_RID_COUNT")]
        public const int SecurityChildPackageRidCount = unchecked((int) 0xC);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE")]
        public const int SecurityBuiltinPackageAnyPackage = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE")]
        public const int SecurityBuiltinPackageAnyRestrictedPackage = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_INTERNET_CLIENT")]
        public const int SecurityCapabilityInternetClient = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER")]
        public const int SecurityCapabilityInternetClientServer = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER")]
        public const int SecurityCapabilityPrivateNetworkClientServer = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_PICTURES_LIBRARY")]
        public const int SecurityCapabilityPicturesLibrary = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_VIDEOS_LIBRARY")]
        public const int SecurityCapabilityVideosLibrary = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_MUSIC_LIBRARY")]
        public const int SecurityCapabilityMusicLibrary = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_DOCUMENTS_LIBRARY")]
        public const int SecurityCapabilityDocumentsLibrary = unchecked((int) 0x7);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION")]
        public const int SecurityCapabilityEnterpriseAuthentication = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES")]
        public const int SecurityCapabilitySharedUserCertificates = unchecked((int) 0x9);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_REMOVABLE_STORAGE")]
        public const int SecurityCapabilityRemovableStorage = unchecked((int) 0xA);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_APPOINTMENTS")]
        public const int SecurityCapabilityAppointments = unchecked((int) 0xB);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_CONTACTS")]
        public const int SecurityCapabilityContacts = unchecked((int) 0xC);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_CAPABILITY_INTERNET_EXPLORER")]
        public const int SecurityCapabilityInternetExplorer = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_UNTRUSTED_RID")]
        public const int SecurityMandatoryUntrustedRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_LOW_RID")]
        public const int SecurityMandatoryLowRid = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_MEDIUM_RID")]
        public const int SecurityMandatoryMediumRid = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_HIGH_RID")]
        public const int SecurityMandatoryHighRid = unchecked((int) 0x3000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_SYSTEM_RID")]
        public const int SecurityMandatorySystemRid = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_PROTECTED_PROCESS_RID")]
        public const int SecurityMandatoryProtectedProcessRid = unchecked((int) 0x5000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_MANDATORY_MAXIMUM_USER_RID")]
        public const int SecurityMandatoryMaximumUserRid = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT")]
        public const int SecurityAuthenticationAuthorityRidCount = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID")]
        public const int SecurityAuthenticationAuthorityAssertedRid = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID")]
        public const int SecurityAuthenticationServiceAssertedRid = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID")]
        public const int SecurityAuthenticationFreshKeyAuthRid = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_KEY_TRUST_RID")]
        public const int SecurityAuthenticationKeyTrustRid = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID")]
        public const int SecurityAuthenticationKeyPropertyMfaRid = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID")]
        public const int SecurityAuthenticationKeyPropertyAttestationRid = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT")]
        public const int SecurityProcessTrustAuthorityRidCount = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID")]
        public const int SecurityProcessProtectionTypeFullRid = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID")]
        public const int SecurityProcessProtectionTypeLiteRid = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID")]
        public const int SecurityProcessProtectionTypeNoneRid = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID")]
        public const int SecurityProcessProtectionLevelWintcbRid = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID")]
        public const int SecurityProcessProtectionLevelWindowsRid = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID")]
        public const int SecurityProcessProtectionLevelAppRid = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID")]
        public const int SecurityProcessProtectionLevelAntimalwareRid = unchecked((int) 0x600);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID")]
        public const int SecurityProcessProtectionLevelAuthenticodeRid = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID")]
        public const int SecurityProcessProtectionLevelNoneRid = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_TRUSTED_INSTALLER_RID1")]
        public const int SecurityTrustedInstallerRid1 = unchecked((int) 0x38FB89B5);
        [NativeName("Type", "long long")]
        [NativeName("Name", "SECURITY_TRUSTED_INSTALLER_RID2")]
        public const long SecurityTrustedInstallerRid2 = unchecked((long) 0xCBC28419);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_TRUSTED_INSTALLER_RID3")]
        public const int SecurityTrustedInstallerRid3 = unchecked((int) 0x6D236C5C);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_TRUSTED_INSTALLER_RID4")]
        public const int SecurityTrustedInstallerRid4 = unchecked((int) 0x6E770057);
        [NativeName("Type", "long long")]
        [NativeName("Name", "SECURITY_TRUSTED_INSTALLER_RID5")]
        public const long SecurityTrustedInstallerRid5 = unchecked((long) 0x876402C0);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_MANDATORY")]
        public const int SEGroupMandatory = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_ENABLED_BY_DEFAULT")]
        public const int SEGroupEnabledByDefault = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_ENABLED")]
        public const int SEGroupEnabled = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_OWNER")]
        public const int SEGroupOwner = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_USE_FOR_DENY_ONLY")]
        public const int SEGroupUseForDenyOnly = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_INTEGRITY")]
        public const int SEGroupIntegrity = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_INTEGRITY_ENABLED")]
        public const int SEGroupIntegrityEnabled = unchecked((int) 0x40);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "SE_GROUP_LOGON_ID")]
        public const uint SEGroupLogonID = unchecked((uint) 0xFFFFFFFFC0000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_GROUP_RESOURCE")]
        public const int SEGroupResource = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION")]
        public const int AclRevision = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION_DS")]
        public const int AclRevisionDS = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION1")]
        public const int AclRevision1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MIN_ACL_REVISION")]
        public const int MinAclRevision = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION2")]
        public const int AclRevision2 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION3")]
        public const int AclRevision3 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACL_REVISION4")]
        public const int AclRevision4 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_ACL_REVISION")]
        public const int MaxAclRevision = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MIN_MS_ACE_TYPE")]
        public const int AccessMinMSAceType = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_ALLOWED_ACE_TYPE")]
        public const int AccessAllowedAceType = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_DENIED_ACE_TYPE")]
        public const int AccessDeniedAceType = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_AUDIT_ACE_TYPE")]
        public const int SystemAuditAceType = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ALARM_ACE_TYPE")]
        public const int SystemAlarmAceType = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_V2_ACE_TYPE")]
        public const int AccessMaxMSV2AceType = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_ALLOWED_COMPOUND_ACE_TYPE")]
        public const int AccessAllowedCompoundAceType = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_V3_ACE_TYPE")]
        public const int AccessMaxMSV3AceType = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MIN_MS_OBJECT_ACE_TYPE")]
        public const int AccessMinMSObjectAceType = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_ALLOWED_OBJECT_ACE_TYPE")]
        public const int AccessAllowedObjectAceType = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_DENIED_OBJECT_ACE_TYPE")]
        public const int AccessDeniedObjectAceType = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_AUDIT_OBJECT_ACE_TYPE")]
        public const int SystemAuditObjectAceType = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ALARM_OBJECT_ACE_TYPE")]
        public const int SystemAlarmObjectAceType = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_OBJECT_ACE_TYPE")]
        public const int AccessMaxMSObjectAceType = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_V4_ACE_TYPE")]
        public const int AccessMaxMSV4AceType = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_ACE_TYPE")]
        public const int AccessMaxMSAceType = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_ALLOWED_CALLBACK_ACE_TYPE")]
        public const int AccessAllowedCallbackAceType = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_DENIED_CALLBACK_ACE_TYPE")]
        public const int AccessDeniedCallbackAceType = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE")]
        public const int AccessAllowedCallbackObjectAceType = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE")]
        public const int AccessDeniedCallbackObjectAceType = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_AUDIT_CALLBACK_ACE_TYPE")]
        public const int SystemAuditCallbackAceType = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ALARM_CALLBACK_ACE_TYPE")]
        public const int SystemAlarmCallbackAceType = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE")]
        public const int SystemAuditCallbackObjectAceType = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE")]
        public const int SystemAlarmCallbackObjectAceType = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MANDATORY_LABEL_ACE_TYPE")]
        public const int SystemMandatoryLabelAceType = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE")]
        public const int SystemResourceAttributeAceType = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCOPED_POLICY_ID_ACE_TYPE")]
        public const int SystemScopedPolicyIDAceType = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE")]
        public const int SystemProcessTrustLabelAceType = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ACCESS_FILTER_ACE_TYPE")]
        public const int SystemAccessFilterAceType = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_MS_V5_ACE_TYPE")]
        public const int AccessMaxMSV5AceType = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "OBJECT_INHERIT_ACE")]
        public const int ObjectInheritAce = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CONTAINER_INHERIT_ACE")]
        public const int ContainerInheritAce = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "NO_PROPAGATE_INHERIT_ACE")]
        public const int NoPropagateInheritAce = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "INHERIT_ONLY_ACE")]
        public const int InheritOnlyAce = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "INHERITED_ACE")]
        public const int InheritedAce = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "VALID_INHERIT_FLAGS")]
        public const int ValidInheritFlags = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "CRITICAL_ACE_FLAG")]
        public const int CriticalAceFlag = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SUCCESSFUL_ACCESS_ACE_FLAG")]
        public const int SuccessfulAccessAceFlag = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAILED_ACCESS_ACE_FLAG")]
        public const int FailedAccessAceFlag = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRUST_PROTECTED_FILTER_ACE_FLAG")]
        public const int TrustProtectedFilterAceFlag = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MANDATORY_LABEL_NO_WRITE_UP")]
        public const int SystemMandatoryLabelNoWriteUp = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MANDATORY_LABEL_NO_READ_UP")]
        public const int SystemMandatoryLabelNoReadUp = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP")]
        public const int SystemMandatoryLabelNoExecuteUp = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK")]
        public const int SystemProcessTrustLabelValidMask = unchecked((int) 0xFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK")]
        public const uint SystemProcessTrustNoconstraintMask = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ACCESS_FILTER_VALID_MASK")]
        public const int SystemAccessFilterValidMask = unchecked((int) 0xFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK")]
        public const uint SystemAccessFilterNoconstraintMask = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACE_OBJECT_TYPE_PRESENT")]
        public const int AceObjectTypePresent = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACE_INHERITED_OBJECT_TYPE_PRESENT")]
        public const int AceInheritedObjectTypePresent = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_DESCRIPTOR_REVISION")]
        public const int SecurityDescriptorRevision = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_DESCRIPTOR_REVISION1")]
        public const int SecurityDescriptorRevision1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_OWNER_DEFAULTED")]
        public const int SEOwnerDefaulted = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_GROUP_DEFAULTED")]
        public const int SEGroupDefaulted = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_DACL_PRESENT")]
        public const int SEDaclPresent = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_DACL_DEFAULTED")]
        public const int SEDaclDefaulted = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SACL_PRESENT")]
        public const int SESaclPresent = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SACL_DEFAULTED")]
        public const int SESaclDefaulted = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_DACL_AUTO_INHERIT_REQ")]
        public const int SEDaclAutoInheritReq = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SACL_AUTO_INHERIT_REQ")]
        public const int SESaclAutoInheritReq = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_DACL_AUTO_INHERITED")]
        public const int SEDaclAutoInherited = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SACL_AUTO_INHERITED")]
        public const int SESaclAutoInherited = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_DACL_PROTECTED")]
        public const int SEDaclProtected = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SACL_PROTECTED")]
        public const int SESaclProtected = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_RM_CONTROL_VALID")]
        public const int SERMControlValid = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SELF_RELATIVE")]
        public const int SESelfRelative = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_OBJECT_GUID")]
        public const int AccessObjectGuid = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_PROPERTY_SET_GUID")]
        public const int AccessPropertySetGuid = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_PROPERTY_GUID")]
        public const int AccessPropertyGuid = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_MAX_LEVEL")]
        public const int AccessMaxLevel = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIT_ALLOW_NO_PRIVILEGE")]
        public const int AuditAllowNoPrivilege = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "ACCESS_DS_SOURCE_A")]
        public const string AccessDSSourceA = unchecked((string) "DS");
        [NativeName("Type", "")]
        [NativeName("Name", "ACCESS_DS_SOURCE_W")]
        public const string AccessDSSourceW = unchecked((string) "DS");
        [NativeName("Type", "")]
        [NativeName("Name", "ACCESS_DS_OBJECT_TYPE_NAME_A")]
        public const string AccessDSObjectTypeNameA = unchecked((string) "Directory Service Object");
        [NativeName("Type", "")]
        [NativeName("Name", "ACCESS_DS_OBJECT_TYPE_NAME_W")]
        public const string AccessDSObjectTypeNameW = unchecked((string) "Directory Service Object");
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_PRIVILEGE_ENABLED_BY_DEFAULT")]
        public const int SEPrivilegeEnabledByDefault = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_PRIVILEGE_ENABLED")]
        public const int SEPrivilegeEnabled = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "SE_PRIVILEGE_REMOVED")]
        public const int SEPrivilegeRemoved = unchecked((int) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "SE_PRIVILEGE_USED_FOR_ACCESS")]
        public const uint SEPrivilegeUsedForAccess = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PRIVILEGE_SET_ALL_NECESSARY")]
        public const int PrivilegeSetAllNecessary = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_REASON_TYPE_MASK")]
        public const int AccessReasonTypeMask = unchecked((int) 0xFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_REASON_DATA_MASK")]
        public const int AccessReasonDataMask = unchecked((int) 0xFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "ACCESS_REASON_STAGING_MASK")]
        public const uint AccessReasonStagingMask = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACCESS_REASON_EXDATA_MASK")]
        public const int AccessReasonExdataMask = unchecked((int) 0x7F000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE")]
        public const int SESecurityDescriptorFlagNoOwnerAce = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE")]
        public const int SESecurityDescriptorFlagNoLabelAce = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE")]
        public const int SESecurityDescriptorFlagNoAccessFilterAce = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SECURITY_DESCRIPTOR_VALID_FLAGS")]
        public const int SESecurityDescriptorValidFlags = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING")]
        public const int SEAccessCheckFlagNoLearningModeLogging = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_ACCESS_CHECK_VALID_FLAGS")]
        public const int SEAccessCheckValidFlags = unchecked((int) 0x8);
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CREATE_TOKEN_NAME")]
        public const string SECreateTokenName = unchecked((string) "SeCreateTokenPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_ASSIGNPRIMARYTOKEN_NAME")]
        public const string SEAssignprimarytokenName = unchecked((string) "SeAssignPrimaryTokenPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_LOCK_MEMORY_NAME")]
        public const string SELockMemoryName = unchecked((string) "SeLockMemoryPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_INCREASE_QUOTA_NAME")]
        public const string SEIncreaseQuotaName = unchecked((string) "SeIncreaseQuotaPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_UNSOLICITED_INPUT_NAME")]
        public const string SEUnsolicitedInputName = unchecked((string) "SeUnsolicitedInputPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_MACHINE_ACCOUNT_NAME")]
        public const string SEMachineAccountName = unchecked((string) "SeMachineAccountPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_TCB_NAME")]
        public const string SETcbName = unchecked((string) "SeTcbPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SECURITY_NAME")]
        public const string SESecurityName = unchecked((string) "SeSecurityPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_TAKE_OWNERSHIP_NAME")]
        public const string SETakeOwnershipName = unchecked((string) "SeTakeOwnershipPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_LOAD_DRIVER_NAME")]
        public const string SELoadDriverName = unchecked((string) "SeLoadDriverPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SYSTEM_PROFILE_NAME")]
        public const string SESystemProfileName = unchecked((string) "SeSystemProfilePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SYSTEMTIME_NAME")]
        public const string SESystemtimeName = unchecked((string) "SeSystemtimePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_PROF_SINGLE_PROCESS_NAME")]
        public const string SEProfSingleProcessName = unchecked((string) "SeProfileSingleProcessPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_INC_BASE_PRIORITY_NAME")]
        public const string SEIncBasePriorityName = unchecked((string) "SeIncreaseBasePriorityPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CREATE_PAGEFILE_NAME")]
        public const string SECreatePagefileName = unchecked((string) "SeCreatePagefilePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CREATE_PERMANENT_NAME")]
        public const string SECreatePermanentName = unchecked((string) "SeCreatePermanentPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_BACKUP_NAME")]
        public const string SEBackupName = unchecked((string) "SeBackupPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_RESTORE_NAME")]
        public const string SERestoreName = unchecked((string) "SeRestorePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SHUTDOWN_NAME")]
        public const string SEShutdownName = unchecked((string) "SeShutdownPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_DEBUG_NAME")]
        public const string SEDebugName = unchecked((string) "SeDebugPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_AUDIT_NAME")]
        public const string SEAuditName = unchecked((string) "SeAuditPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SYSTEM_ENVIRONMENT_NAME")]
        public const string SESystemEnvironmentName = unchecked((string) "SeSystemEnvironmentPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CHANGE_NOTIFY_NAME")]
        public const string SEChangeNotifyName = unchecked((string) "SeChangeNotifyPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_REMOTE_SHUTDOWN_NAME")]
        public const string SERemoteShutdownName = unchecked((string) "SeRemoteShutdownPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_UNDOCK_NAME")]
        public const string SEUndockName = unchecked((string) "SeUndockPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SYNC_AGENT_NAME")]
        public const string SESyncAgentName = unchecked((string) "SeSyncAgentPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_ENABLE_DELEGATION_NAME")]
        public const string SEEnableDelegationName = unchecked((string) "SeEnableDelegationPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_MANAGE_VOLUME_NAME")]
        public const string SEManageVolumeName = unchecked((string) "SeManageVolumePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_IMPERSONATE_NAME")]
        public const string SEImpersonateName = unchecked((string) "SeImpersonatePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CREATE_GLOBAL_NAME")]
        public const string SECreateGlobalName = unchecked((string) "SeCreateGlobalPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_TRUSTED_CREDMAN_ACCESS_NAME")]
        public const string SETrustedCredmanAccessName = unchecked((string) "SeTrustedCredManAccessPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_RELABEL_NAME")]
        public const string SERelabelName = unchecked((string) "SeRelabelPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_INC_WORKING_SET_NAME")]
        public const string SEIncWorkingSetName = unchecked((string) "SeIncreaseWorkingSetPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_TIME_ZONE_NAME")]
        public const string SETimeZoneName = unchecked((string) "SeTimeZonePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CREATE_SYMBOLIC_LINK_NAME")]
        public const string SECreateSymbolicLinkName = unchecked((string) "SeCreateSymbolicLinkPrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME")]
        public const string SEDelegateSessionUserImpersonateName = unchecked((string) "SeDelegateSessionUserImpersonatePrivilege");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_ACTIVATE_AS_USER_CAPABILITY")]
        public const string SEActivateAsUserCapability = unchecked((string) "activateAsUser");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_CONSTRAINED_IMPERSONATION_CAPABILITY")]
        public const string SEConstrainedImpersonationCapability = unchecked((string) "constrainedImpersonation");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_SESSION_IMPERSONATION_CAPABILITY")]
        public const string SESessionImpersonationCapability = unchecked((string) "sessionImpersonation");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_MUMA_CAPABILITY")]
        public const string SEMumaCapability = unchecked((string) "muma");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY")]
        public const string SEDevelopmentModeNetworkCapability = unchecked((string) "developmentModeNetwork");
        [NativeName("Type", "")]
        [NativeName("Name", "SE_PERMISSIVE_LEARNING_MODE_CAPABILITY")]
        public const string SEPermissiveLearningModeCapability = unchecked((string) "permissiveLearningMode");
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_ASSIGN_PRIMARY")]
        public const int TokenAssignPrimary = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_DUPLICATE")]
        public const int TokenDuplicate = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_IMPERSONATE")]
        public const int TokenImpersonate = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_QUERY")]
        public const int TokenQuery = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_QUERY_SOURCE")]
        public const int TokenQuerySource = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_ADJUST_PRIVILEGES")]
        public const int TokenAdjustPrivileges = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_ADJUST_GROUPS")]
        public const int TokenAdjustGroups = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_ADJUST_DEFAULT")]
        public const int TokenAdjustDefault = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_ADJUST_SESSIONID")]
        public const int TokenAdjustSessionid = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "TOKEN_EXECUTE")]
        public const int TokenExecute = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_MANDATORY_POLICY_OFF")]
        public const int TokenMandatoryPolicyOff = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_MANDATORY_POLICY_NO_WRITE_UP")]
        public const int TokenMandatoryPolicyNoWriteUp = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN")]
        public const int TokenMandatoryPolicyNewProcessMin = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POLICY_AUDIT_SUBCATEGORY_COUNT")]
        public const int PolicyAuditSubcategoryCount = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "TOKEN_SOURCE_LENGTH")]
        public const int TokenSourceLength = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID")]
        public const int ClaimSecurityAttributeTypeInvalid = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64")]
        public const int ClaimSecurityAttributeTypeInt64 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64")]
        public const int ClaimSecurityAttributeTypeUint64 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING")]
        public const int ClaimSecurityAttributeTypeString = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN")]
        public const int ClaimSecurityAttributeTypeFqbn = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_SID")]
        public const int ClaimSecurityAttributeTypeSid = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN")]
        public const int ClaimSecurityAttributeTypeBoolean = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING")]
        public const int ClaimSecurityAttributeTypeOctetString = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE")]
        public const int ClaimSecurityAttributeNonInheritable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE")]
        public const int ClaimSecurityAttributeValueCaseSensitive = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY")]
        public const int ClaimSecurityAttributeUseForDenyOnly = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT")]
        public const int ClaimSecurityAttributeDisabledByDefault = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_DISABLED")]
        public const int ClaimSecurityAttributeDisabled = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_MANDATORY")]
        public const int ClaimSecurityAttributeMandatory = unchecked((int) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS")]
        public const uint ClaimSecurityAttributeCustomFlags = unchecked((uint) 0xFFFFFFFFFFFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1")]
        public const int ClaimSecurityAttributesInformationVersionV1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION")]
        public const int ClaimSecurityAttributesInformationVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_DYNAMIC_TRACKING")]
        public const int SecurityDynamicTracking = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECURITY_STATIC_TRACKING")]
        public const int SecurityStaticTracking = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DISABLE_MAX_PRIVILEGE")]
        public const int DisableMaxPrivilege = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SANDBOX_INERT")]
        public const int SandboxInert = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "LUA_TOKEN")]
        public const int LuaToken = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "WRITE_RESTRICTED")]
        public const int WriteRestricted = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "OWNER_SECURITY_INFORMATION")]
        public const int OwnerSecurityInformation = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "GROUP_SECURITY_INFORMATION")]
        public const int GroupSecurityInformation = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "DACL_SECURITY_INFORMATION")]
        public const int DaclSecurityInformation = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "SACL_SECURITY_INFORMATION")]
        public const int SaclSecurityInformation = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "LABEL_SECURITY_INFORMATION")]
        public const int LabelSecurityInformation = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "ATTRIBUTE_SECURITY_INFORMATION")]
        public const int AttributeSecurityInformation = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "SCOPE_SECURITY_INFORMATION")]
        public const int ScopeSecurityInformation = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "PROCESS_TRUST_LABEL_SECURITY_INFORMATION")]
        public const int ProcessTrustLabelSecurityInformation = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "ACCESS_FILTER_SECURITY_INFORMATION")]
        public const int AccessFilterSecurityInformation = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "BACKUP_SECURITY_INFORMATION")]
        public const int BackupSecurityInformation = unchecked((int) 0x10000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "PROTECTED_DACL_SECURITY_INFORMATION")]
        public const uint ProtectedDaclSecurityInformation = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "PROTECTED_SACL_SECURITY_INFORMATION")]
        public const int ProtectedSaclSecurityInformation = unchecked((int) 0x40000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "UNPROTECTED_DACL_SECURITY_INFORMATION")]
        public const int UnprotectedDaclSecurityInformation = unchecked((int) 0x20000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "UNPROTECTED_SACL_SECURITY_INFORMATION")]
        public const int UnprotectedSaclSecurityInformation = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_UNCHECKED")]
        public const int SESigningLevelUnchecked = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_UNSIGNED")]
        public const int SESigningLevelUnsigned = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_ENTERPRISE")]
        public const int SESigningLevelEnterprise = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_1")]
        public const int SESigningLevelCustom1 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_DEVELOPER")]
        public const int SESigningLevelDeveloper = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_AUTHENTICODE")]
        public const int SESigningLevelAuthenticode = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_2")]
        public const int SESigningLevelCustom2 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_STORE")]
        public const int SESigningLevelStore = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_3")]
        public const int SESigningLevelCustom3 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_ANTIMALWARE")]
        public const int SESigningLevelAntimalware = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_MICROSOFT")]
        public const int SESigningLevelMicrosoft = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_4")]
        public const int SESigningLevelCustom4 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_5")]
        public const int SESigningLevelCustom5 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_DYNAMIC_CODEGEN")]
        public const int SESigningLevelDynamicCodegen = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_WINDOWS")]
        public const int SESigningLevelWindows = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_7")]
        public const int SESigningLevelCustom7 = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_WINDOWS_TCB")]
        public const int SESigningLevelWindowsTcb = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_SIGNING_LEVEL_CUSTOM_6")]
        public const int SESigningLevelCustom6 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SE_LEARNING_MODE_FLAG_PERMISSIVE")]
        public const int SELearningModeFlagPermissive = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_TERMINATE")]
        public const int ProcessTerminate = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_CREATE_THREAD")]
        public const int ProcessCreateThread = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_SET_SESSIONID")]
        public const int ProcessSetSessionid = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_VM_OPERATION")]
        public const int ProcessVMOperation = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_VM_READ")]
        public const int ProcessVMRead = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_VM_WRITE")]
        public const int ProcessVMWrite = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_DUP_HANDLE")]
        public const int ProcessDupHandle = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_CREATE_PROCESS")]
        public const int ProcessCreateProcess = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_SET_QUOTA")]
        public const int ProcessSetQuota = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_SET_INFORMATION")]
        public const int ProcessSetInformation = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_QUERY_INFORMATION")]
        public const int ProcessQueryInformation = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_SUSPEND_RESUME")]
        public const int ProcessSuspendResume = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_QUERY_LIMITED_INFORMATION")]
        public const int ProcessQueryLimitedInformation = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_SET_LIMITED_INFORMATION")]
        public const int ProcessSetLimitedInformation = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_TERMINATE")]
        public const int ThreadTerminate = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_SUSPEND_RESUME")]
        public const int ThreadSuspendResume = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_GET_CONTEXT")]
        public const int ThreadGetContext = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_SET_CONTEXT")]
        public const int ThreadSetContext = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_QUERY_INFORMATION")]
        public const int ThreadQueryInformation = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_SET_INFORMATION")]
        public const int ThreadSetInformation = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_SET_THREAD_TOKEN")]
        public const int ThreadSetThreadToken = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_IMPERSONATE")]
        public const int ThreadImpersonate = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_DIRECT_IMPERSONATION")]
        public const int ThreadDirectImpersonation = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_SET_LIMITED_INFORMATION")]
        public const int ThreadSetLimitedInformation = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_QUERY_LIMITED_INFORMATION")]
        public const int ThreadQueryLimitedInformation = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_RESUME")]
        public const int ThreadResume = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_ASSIGN_PROCESS")]
        public const int JobObjectAssignProcess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SET_ATTRIBUTES")]
        public const int JobObjectSetAttributes = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_QUERY")]
        public const int JobObjectQuery = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_TERMINATE")]
        public const int JobObjectTerminate = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SET_SECURITY_ATTRIBUTES")]
        public const int JobObjectSetSecurityAttributes = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_IMPERSONATE")]
        public const int JobObjectImpersonate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FLS_MAXIMUM_AVAILABLE")]
        public const int FlsMaximumAvailable = unchecked((int) 0xFF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TLS_MINIMUM_AVAILABLE")]
        public const int TlsMinimumAvailable = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_DYNAMIC_CODE_ALLOW")]
        public const int ThreadDynamicCodeAllow = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_BASE_PRIORITY_LOWRT")]
        public const int ThreadBasePriorityLowrt = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_BASE_PRIORITY_MAX")]
        public const int ThreadBasePriorityMax = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPONENT_KTM")]
        public const int ComponentKtm = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPONENT_VALID_FLAGS")]
        public const int ComponentValidFlags = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_LOWEST")]
        public const int MemoryPriorityLowest = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_VERY_LOW")]
        public const int MemoryPriorityVeryLow = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_LOW")]
        public const int MemoryPriorityLow = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_MEDIUM")]
        public const int MemoryPriorityMedium = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_BELOW_NORMAL")]
        public const int MemoryPriorityBelowNormal = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PRIORITY_NORMAL")]
        public const int MemoryPriorityNormal = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DYNAMIC_EH_CONTINUATION_TARGET_ADD")]
        public const int DynamicEHContinuationTargetAdd = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED")]
        public const int DynamicEHContinuationTargetProcessed = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD")]
        public const int DynamicEnforcedAddressRangeAdd = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED")]
        public const int DynamicEnforcedAddressRangeProcessed = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "QUOTA_LIMITS_HARDWS_MIN_ENABLE")]
        public const int QuotaLimitsHardwsMinEnable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "QUOTA_LIMITS_HARDWS_MIN_DISABLE")]
        public const int QuotaLimitsHardwsMinDisable = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "QUOTA_LIMITS_HARDWS_MAX_ENABLE")]
        public const int QuotaLimitsHardwsMaxEnable = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "QUOTA_LIMITS_HARDWS_MAX_DISABLE")]
        public const int QuotaLimitsHardwsMaxDisable = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "QUOTA_LIMITS_USE_DEFAULT_LIMITS")]
        public const int QuotaLimitsUseDefaultLimits = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_HW_COUNTERS")]
        public const int MaxHWCounters = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "THREAD_PROFILING_FLAG_DISPATCH")]
        public const int ThreadProfilingFlagDispatch = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG")]
        public const int JobObjectNetRateControlMaxDscpTag = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_TERMINATE_AT_END_OF_JOB")]
        public const int JobObjectTerminateATEndOfJob = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_POST_AT_END_OF_JOB")]
        public const int JobObjectPostATEndOfJob = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_END_OF_JOB_TIME")]
        public const int JobObjectMsgEndOfJobTime = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_END_OF_PROCESS_TIME")]
        public const int JobObjectMsgEndOfProcessTime = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT")]
        public const int JobObjectMsgActiveProcessLimit = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO")]
        public const int JobObjectMsgActiveProcessZero = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_NEW_PROCESS")]
        public const int JobObjectMsgNewProcess = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_EXIT_PROCESS")]
        public const int JobObjectMsgExitProcess = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS")]
        public const int JobObjectMsgAbnormalExitProcess = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT")]
        public const int JobObjectMsgProcessMemoryLimit = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_JOB_MEMORY_LIMIT")]
        public const int JobObjectMsgJobMemoryLimit = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_NOTIFICATION_LIMIT")]
        public const int JobObjectMsgNotificationLimit = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT")]
        public const int JobObjectMsgJobCycleTimeLimit = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_SILO_TERMINATED")]
        public const int JobObjectMsgSiloTerminated = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_MINIMUM")]
        public const int JobObjectMsgMinimum = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_MSG_MAXIMUM")]
        public const int JobObjectMsgMaximum = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_WORKINGSET")]
        public const int JobObjectLimitWorkingset = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_PROCESS_TIME")]
        public const int JobObjectLimitProcessTime = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_TIME")]
        public const int JobObjectLimitJobTime = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_ACTIVE_PROCESS")]
        public const int JobObjectLimitActiveProcess = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_AFFINITY")]
        public const int JobObjectLimitAffinity = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_PRIORITY_CLASS")]
        public const int JobObjectLimitPriorityClass = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME")]
        public const int JobObjectLimitPreserveJobTime = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_SCHEDULING_CLASS")]
        public const int JobObjectLimitSchedulingClass = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_PROCESS_MEMORY")]
        public const int JobObjectLimitProcessMemory = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_MEMORY")]
        public const int JobObjectLimitJobMemory = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH")]
        public const int JobObjectLimitJobMemoryHigh = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION")]
        public const int JobObjectLimitDieOnUnhandledException = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_BREAKAWAY_OK")]
        public const int JobObjectLimitBreakawayOK = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK")]
        public const int JobObjectLimitSilentBreakawayOK = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE")]
        public const int JobObjectLimitKillOnJobClose = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_SUBSET_AFFINITY")]
        public const int JobObjectLimitSubsetAffinity = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_MEMORY_LOW")]
        public const int JobObjectLimitJobMemoryLow = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_READ_BYTES")]
        public const int JobObjectLimitJobReadBytes = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_JOB_WRITE_BYTES")]
        public const int JobObjectLimitJobWriteBytes = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_RATE_CONTROL")]
        public const int JobObjectLimitRateControl = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_CPU_RATE_CONTROL")]
        public const int JobObjectLimitCpuRateControl = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_IO_RATE_CONTROL")]
        public const int JobObjectLimitIORateControl = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_NET_RATE_CONTROL")]
        public const int JobObjectLimitNetRateControl = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_LIMIT_VALID_FLAGS")]
        public const int JobObjectLimitValidFlags = unchecked((int) 0x7FFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS")]
        public const int JobObjectBasicLimitValidFlags = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS")]
        public const int JobObjectExtendedLimitValidFlags = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_NONE")]
        public const int JobObjectUilimitNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_HANDLES")]
        public const int JobObjectUilimitHandles = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_READCLIPBOARD")]
        public const int JobObjectUilimitReadclipboard = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_WRITECLIPBOARD")]
        public const int JobObjectUilimitWriteclipboard = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS")]
        public const int JobObjectUilimitSystemparameters = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_DISPLAYSETTINGS")]
        public const int JobObjectUilimitDisplaysettings = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_GLOBALATOMS")]
        public const int JobObjectUilimitGlobalatoms = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_DESKTOP")]
        public const int JobObjectUilimitDesktop = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_EXITWINDOWS")]
        public const int JobObjectUilimitExitwindows = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UILIMIT_ALL")]
        public const int JobObjectUilimitAll = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_UI_VALID_FLAGS")]
        public const int JobObjectUIValidFlags = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SECURITY_NO_ADMIN")]
        public const int JobObjectSecurityNoAdmin = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SECURITY_RESTRICTED_TOKEN")]
        public const int JobObjectSecurityRestrictedToken = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SECURITY_ONLY_TOKEN")]
        public const int JobObjectSecurityOnlyToken = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SECURITY_FILTER_TOKENS")]
        public const int JobObjectSecurityFilterTokens = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_SECURITY_VALID_FLAGS")]
        public const int JobObjectSecurityValidFlags = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_ENABLE")]
        public const int JobObjectCpuRateControlEnable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED")]
        public const int JobObjectCpuRateControlWeightBased = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP")]
        public const int JobObjectCpuRateControlHardCap = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY")]
        public const int JobObjectCpuRateControlNotify = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE")]
        public const int JobObjectCpuRateControlMinMaxRate = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS")]
        public const int JobObjectCpuRateControlValidFlags = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PARTITION_QUERY_ACCESS")]
        public const int MemoryPartitionQueryAccess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEMORY_PARTITION_MODIFY_ACCESS")]
        public const int MemoryPartitionModifyAccess = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_MODIFY_STATE")]
        public const int EventModifyState = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "MUTANT_QUERY_STATE")]
        public const int MutantQueryState = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEMAPHORE_MODIFY_STATE")]
        public const int SemaphoreModifyState = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TIMER_QUERY_STATE")]
        public const int TimerQueryState = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TIMER_MODIFY_STATE")]
        public const int TimerModifyState = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TIME_ZONE_ID_UNKNOWN")]
        public const int TimeZoneIDUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TIME_ZONE_ID_STANDARD")]
        public const int TimeZoneIDStandard = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TIME_ZONE_ID_DAYLIGHT")]
        public const int TimeZoneIDDaylight = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "LTP_PC_SMT")]
        public const int LtpPCSmt = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CACHE_FULLY_ASSOCIATIVE")]
        public const int CacheFullyAssociative = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_SET_INFORMATION_PARKED")]
        public const int SystemCpuSetInformationParked = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_SET_INFORMATION_ALLOCATED")]
        public const int SystemCpuSetInformationAllocated = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS")]
        public const int SystemCpuSetInformationAllocatedToTargetProcess = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_SET_INFORMATION_REALTIME")]
        public const int SystemCpuSetInformationRealtime = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_INTEL_386")]
        public const int ProcessorIntel386 = unchecked((int) 0x182);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_INTEL_486")]
        public const int ProcessorIntel486 = unchecked((int) 0x1E6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_INTEL_PENTIUM")]
        public const int ProcessorIntelPentium = unchecked((int) 0x24A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_INTEL_IA64")]
        public const int ProcessorIntelIA64 = unchecked((int) 0x898);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_AMD_X8664")]
        public const int ProcessorAmdX8664 = unchecked((int) 0x21D8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_MIPS_R4000")]
        public const int ProcessorMipsR4000 = unchecked((int) 0xFA0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ALPHA_21064")]
        public const int ProcessorAlpha21064 = unchecked((int) 0x5248);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PPC_601")]
        public const int ProcessorPpc601 = unchecked((int) 0x259);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PPC_603")]
        public const int ProcessorPpc603 = unchecked((int) 0x25B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PPC_604")]
        public const int ProcessorPpc604 = unchecked((int) 0x25C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PPC_620")]
        public const int ProcessorPpc620 = unchecked((int) 0x26C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_HITACHI_SH3")]
        public const int ProcessorHitachiSH3 = unchecked((int) 0x2713);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_HITACHI_SH3E")]
        public const int ProcessorHitachiSH3E = unchecked((int) 0x2714);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_HITACHI_SH4")]
        public const int ProcessorHitachiSH4 = unchecked((int) 0x2715);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_MOTOROLA_821")]
        public const int ProcessorMotorola821 = unchecked((int) 0x335);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_SHx_SH3")]
        public const int ProcessorSHxSH3 = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_SHx_SH4")]
        public const int ProcessorSHxSH4 = unchecked((int) 0x68);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_STRONGARM")]
        public const int ProcessorStrongarm = unchecked((int) 0xA11);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARM720")]
        public const int ProcessorArm720 = unchecked((int) 0x720);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARM820")]
        public const int ProcessorArm820 = unchecked((int) 0x820);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARM920")]
        public const int ProcessorArm920 = unchecked((int) 0x920);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARM_7TDMI")]
        public const int ProcessorArm7Tdmi = unchecked((int) 0x11171);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_OPTIL")]
        public const int ProcessorOptil = unchecked((int) 0x494F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_INTEL")]
        public const int ProcessorArchitectureIntel = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_MIPS")]
        public const int ProcessorArchitectureMips = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_ALPHA")]
        public const int ProcessorArchitectureAlpha = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_PPC")]
        public const int ProcessorArchitecturePpc = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_SHX")]
        public const int ProcessorArchitectureShx = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_ARM")]
        public const int ProcessorArchitectureArm = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_IA64")]
        public const int ProcessorArchitectureIA64 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_ALPHA64")]
        public const int ProcessorArchitectureAlpha64 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_MSIL")]
        public const int ProcessorArchitectureMsil = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_AMD64")]
        public const int ProcessorArchitectureAmd64 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_IA32_ON_WIN64")]
        public const int ProcessorArchitectureIA32OnWin64 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_NEUTRAL")]
        public const int ProcessorArchitectureNeutral = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_ARM64")]
        public const int ProcessorArchitectureArm64 = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64")]
        public const int ProcessorArchitectureArm32OnWin64 = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_IA32_ON_ARM64")]
        public const int ProcessorArchitectureIA32OnArm64 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_ARCHITECTURE_UNKNOWN")]
        public const int ProcessorArchitectureUnknown = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_FLOATING_POINT_PRECISION_ERRATA")]
        public const int PFFloatingPointPrecisionErrata = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_FLOATING_POINT_EMULATED")]
        public const int PFFloatingPointEmulated = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_COMPARE_EXCHANGE_DOUBLE")]
        public const int PFCompareExchangeDouble = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_MMX_INSTRUCTIONS_AVAILABLE")]
        public const int PFMmxInstructionsAvailable = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_PPC_MOVEMEM_64BIT_OK")]
        public const int PFPpcMovemem64BitOK = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ALPHA_BYTE_INSTRUCTIONS")]
        public const int PFAlphaByteInstructions = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_XMMI_INSTRUCTIONS_AVAILABLE")]
        public const int PFXmmiInstructionsAvailable = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_3DNOW_INSTRUCTIONS_AVAILABLE")]
        public const int PF3DnowInstructionsAvailable = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_RDTSC_INSTRUCTION_AVAILABLE")]
        public const int PFRdtscInstructionAvailable = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_PAE_ENABLED")]
        public const int PFPaeEnabled = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_XMMI64_INSTRUCTIONS_AVAILABLE")]
        public const int PFXmmi64InstructionsAvailable = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SSE_DAZ_MODE_AVAILABLE")]
        public const int PFSseDazModeAvailable = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_NX_ENABLED")]
        public const int PFNXEnabled = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SSE3_INSTRUCTIONS_AVAILABLE")]
        public const int PFSse3InstructionsAvailable = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_COMPARE_EXCHANGE128")]
        public const int PFCompareExchange128 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_COMPARE64_EXCHANGE128")]
        public const int PFCompare64Exchange128 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_CHANNELS_ENABLED")]
        public const int PFChannelsEnabled = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_XSAVE_ENABLED")]
        public const int PFXsaveEnabled = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_VFP_32_REGISTERS_AVAILABLE")]
        public const int PFArmVfp32RegistersAvailable = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_NEON_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmNeonInstructionsAvailable = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SECOND_LEVEL_ADDRESS_TRANSLATION")]
        public const int PFSecondLevelAddressTranslation = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_VIRT_FIRMWARE_ENABLED")]
        public const int PFVirtFirmwareEnabled = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_RDWRFSGSBASE_AVAILABLE")]
        public const int PFRdwrfsgsbaseAvailable = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_FASTFAIL_AVAILABLE")]
        public const int PFFastfailAvailable = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE")]
        public const int PFArmDivideInstructionAvailable = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_64BIT_LOADSTORE_ATOMIC")]
        public const int PFArm64BitLoadstoreAtomic = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_EXTERNAL_CACHE_AVAILABLE")]
        public const int PFArmExternalCacheAvailable = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmFmacInstructionsAvailable = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_RDRAND_INSTRUCTION_AVAILABLE")]
        public const int PFRdrandInstructionAvailable = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V8_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV8InstructionsAvailable = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV8CryptoInstructionsAvailable = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV8Crc32InstructionsAvailable = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_RDTSCP_INSTRUCTION_AVAILABLE")]
        public const int PFRdtscpInstructionAvailable = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_RDPID_INSTRUCTION_AVAILABLE")]
        public const int PFRdpidInstructionAvailable = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV81AtomicInstructionsAvailable = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_MONITORX_INSTRUCTION_AVAILABLE")]
        public const int PFMonitorxInstructionAvailable = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SSSE3_INSTRUCTIONS_AVAILABLE")]
        public const int PFSsse3InstructionsAvailable = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SSE4_1_INSTRUCTIONS_AVAILABLE")]
        public const int PFSse41InstructionsAvailable = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_SSE4_2_INSTRUCTIONS_AVAILABLE")]
        public const int PFSse42InstructionsAvailable = unchecked((int) 0x26);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_AVX_INSTRUCTIONS_AVAILABLE")]
        public const int PFAvxInstructionsAvailable = unchecked((int) 0x27);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_AVX2_INSTRUCTIONS_AVAILABLE")]
        public const int PFAvx2InstructionsAvailable = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_AVX512F_INSTRUCTIONS_AVAILABLE")]
        public const int PFAvx512fInstructionsAvailable = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ERMS_AVAILABLE")]
        public const int PFErmsAvailable = unchecked((int) 0x2A);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV82DPInstructionsAvailable = unchecked((int) 0x2B);
        [NativeName("Type", "int")]
        [NativeName("Name", "PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE")]
        public const int PFArmV83JscvtInstructionsAvailable = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_LEGACY_FLOATING_POINT")]
        public const int XstateLegacyFloatingPoint = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_LEGACY_SSE")]
        public const int XstateLegacySse = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_GSSE")]
        public const int XstateGsse = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AVX")]
        public const int XstateAvx = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_MPX_BNDREGS")]
        public const int XstateMpxBndregs = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_MPX_BNDCSR")]
        public const int XstateMpxBndcsr = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AVX512_KMASK")]
        public const int XstateAvx512Kmask = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AVX512_ZMM_H")]
        public const int XstateAvx512ZmmH = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AVX512_ZMM")]
        public const int XstateAvx512Zmm = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_IPT")]
        public const int XstateIpt = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_PASID")]
        public const int XstatePasid = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_CET_U")]
        public const int XstateCetU = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_CET_S")]
        public const int XstateCetS = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AMX_TILE_CONFIG")]
        public const int XstateAmxTileConfig = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_AMX_TILE_DATA")]
        public const int XstateAmxTileData = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_LWP")]
        public const int XstateLwp = unchecked((int) 0x3E);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXIMUM_XSTATE_FEATURES")]
        public const int MaximumXstateFeatures = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_COMPACTION_ENABLE")]
        public const int XstateCompactionEnable = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_ALIGN_BIT")]
        public const int XstateAlignBit = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_XFD_BIT")]
        public const int XstateXfdBit = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_CONTROLFLAG_XSAVEOPT_MASK")]
        public const int XstateControlflagXsaveoptMask = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_CONTROLFLAG_XSAVEC_MASK")]
        public const int XstateControlflagXsavecMask = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XSTATE_CONTROLFLAG_XFD_MASK")]
        public const int XstateControlflagXfdMask = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFG_CALL_TARGET_VALID")]
        public const int CfgCallTargetValid = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFG_CALL_TARGET_PROCESSED")]
        public const int CfgCallTargetProcessed = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID")]
        public const int CfgCallTargetConvertExportSuppressedToValid = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFG_CALL_TARGET_VALID_XFG")]
        public const int CfgCallTargetValidXfg = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFG_CALL_TARGET_CONVERT_XFG_TO_CFG")]
        public const int CfgCallTargetConvertXfgToCfg = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_QUERY")]
        public const int SectionQuery = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_MAP_WRITE")]
        public const int SectionMapWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_MAP_READ")]
        public const int SectionMapRead = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_MAP_EXECUTE")]
        public const int SectionMapExecute = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_EXTEND_SIZE")]
        public const int SectionExtendSize = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SECTION_MAP_EXECUTE_EXPLICIT")]
        public const int SectionMapExecuteExplicit = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SESSION_QUERY_ACCESS")]
        public const int SessionQueryAccess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SESSION_MODIFY_ACCESS")]
        public const int SessionModifyAccess = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_NOACCESS")]
        public const int PageNoaccess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_READONLY")]
        public const int PageReadonly = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_READWRITE")]
        public const int PageReadwrite = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_WRITECOPY")]
        public const int PageWritecopy = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_EXECUTE")]
        public const int PageExecute = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_EXECUTE_READ")]
        public const int PageExecuteRead = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_EXECUTE_READWRITE")]
        public const int PageExecuteReadwrite = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_EXECUTE_WRITECOPY")]
        public const int PageExecuteWritecopy = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GUARD")]
        public const int PageGuard = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_NOCACHE")]
        public const int PageNocache = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_WRITECOMBINE")]
        public const int PageWritecombine = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_NOACCESS")]
        public const int PageGraphicsNoaccess = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_READONLY")]
        public const int PageGraphicsReadonly = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_READWRITE")]
        public const int PageGraphicsReadwrite = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_EXECUTE")]
        public const int PageGraphicsExecute = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_EXECUTE_READ")]
        public const int PageGraphicsExecuteRead = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_EXECUTE_READWRITE")]
        public const int PageGraphicsExecuteReadwrite = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_COHERENT")]
        public const int PageGraphicsCoherent = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_GRAPHICS_NOCACHE")]
        public const int PageGraphicsNocache = unchecked((int) 0x40000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "PAGE_ENCLAVE_THREAD_CONTROL")]
        public const uint PageEnclaveThreadControl = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "PAGE_REVERT_TO_FILE_MAP")]
        public const uint PageRevertToFileMap = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_TARGETS_NO_UPDATE")]
        public const int PageTargetsNoUpdate = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_TARGETS_INVALID")]
        public const int PageTargetsInvalid = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_ENCLAVE_UNVALIDATED")]
        public const int PageEnclaveUnvalidated = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PAGE_ENCLAVE_MASK")]
        public const int PageEnclaveMask = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_COMMIT")]
        public const int MemCommit = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_RESERVE")]
        public const int MemReserve = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_REPLACE_PLACEHOLDER")]
        public const int MemReplacePlaceholder = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_RESERVE_PLACEHOLDER")]
        public const int MemReservePlaceholder = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_RESET")]
        public const int MemReset = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_TOP_DOWN")]
        public const int MemTopDown = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_WRITE_WATCH")]
        public const int MemWriteWatch = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_PHYSICAL")]
        public const int MemPhysical = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_ROTATE")]
        public const int MemRotate = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_DIFFERENT_IMAGE_BASE_OK")]
        public const int MemDifferentImageBaseOK = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_RESET_UNDO")]
        public const int MemResetUndo = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_LARGE_PAGES")]
        public const int MemLargePages = unchecked((int) 0x20000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "MEM_4MB_PAGES")]
        public const uint Mem4MBPages = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_UNMAP_WITH_TRANSIENT_BOOST")]
        public const int MemUnmapWithTransientBoost = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_COALESCE_PLACEHOLDERS")]
        public const int MemCoalescePlaceholders = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_PRESERVE_PLACEHOLDER")]
        public const int MemPreservePlaceholder = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_DECOMMIT")]
        public const int MemDecommit = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_RELEASE")]
        public const int MemRelease = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_FREE")]
        public const int MemFree = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_GRAPHICS")]
        public const int MemExtendedParameterGraphics = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_NONPAGED")]
        public const int MemExtendedParameterNonpaged = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL")]
        public const int MemExtendedParameterZeroPagesOptional = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_NONPAGED_LARGE")]
        public const int MemExtendedParameterNonpagedLarge = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_NONPAGED_HUGE")]
        public const int MemExtendedParameterNonpagedHuge = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES")]
        public const int MemExtendedParameterSoftFaultPages = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_EC_CODE")]
        public const int MemExtendedParameterECCode = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_EXTENDED_PARAMETER_TYPE_BITS")]
        public const int MemExtendedParameterTypeBits = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_HUGE_PAGES")]
        public const int SecHugePages = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_PARTITION_OWNER_HANDLE")]
        public const int SecPartitionOwnerHandle = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_64K_PAGES")]
        public const int Sec64KPages = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_FILE")]
        public const int SecFile = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_IMAGE")]
        public const int SecImage = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_PROTECTED_IMAGE")]
        public const int SecProtectedImage = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_RESERVE")]
        public const int SecReserve = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_COMMIT")]
        public const int SecCommit = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_NOCACHE")]
        public const int SecNocache = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEC_WRITECOMBINE")]
        public const int SecWritecombine = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SEC_LARGE_PAGES")]
        public const uint SecLargePages = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_PRIVATE")]
        public const int MemPrivate = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_MAPPED")]
        public const int MemMapped = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MEM_IMAGE")]
        public const int MemImage = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WRITE_WATCH_FLAG_RESET")]
        public const int WriteWatchFlagReset = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_TYPE_SGX")]
        public const int EnclaveTypeSgx = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_TYPE_SGX2")]
        public const int EnclaveTypeSgx2 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_TYPE_VBS")]
        public const int EnclaveTypeVbs = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_VBS_FLAG_DEBUG")]
        public const int EnclaveVbsFlagDebug = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENCLAVE_TYPE_VBS_BASIC")]
        public const int EnclaveTypeVbsBasic = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "VBS_BASIC_PAGE_MEASURED_DATA")]
        public const int VbsBasicPageMeasuredData = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VBS_BASIC_PAGE_UNMEASURED_DATA")]
        public const int VbsBasicPageUnmeasuredData = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VBS_BASIC_PAGE_ZERO_FILL")]
        public const int VbsBasicPageZeroFill = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "VBS_BASIC_PAGE_THREAD_DESCRIPTOR")]
        public const int VbsBasicPageThreadDescriptor = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "VBS_BASIC_PAGE_SYSTEM_CALL")]
        public const int VbsBasicPageSystemCall = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEDICATED_MEMORY_CACHE_ELIGIBLE")]
        public const int DedicatedMemoryCacheEligible = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_READ_DATA")]
        public const int FileReadData = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_LIST_DIRECTORY")]
        public const int FileListDirectory = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_WRITE_DATA")]
        public const int FileWriteData = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ADD_FILE")]
        public const int FileAddFile = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_APPEND_DATA")]
        public const int FileAppendData = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ADD_SUBDIRECTORY")]
        public const int FileAddSubdirectory = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_CREATE_PIPE_INSTANCE")]
        public const int FileCreatePipeInstance = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_READ_EA")]
        public const int FileReadEA = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_WRITE_EA")]
        public const int FileWriteEA = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_EXECUTE")]
        public const int FileExecute = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_TRAVERSE")]
        public const int FileTraverse = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_DELETE_CHILD")]
        public const int FileDeleteChild = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_READ_ATTRIBUTES")]
        public const int FileReadAttributes = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_WRITE_ATTRIBUTES")]
        public const int FileWriteAttributes = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SHARE_READ")]
        public const int FileShareRead = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SHARE_WRITE")]
        public const int FileShareWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SHARE_DELETE")]
        public const int FileShareDelete = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_READONLY")]
        public const int FileAttributeReadonly = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_HIDDEN")]
        public const int FileAttributeHidden = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_SYSTEM")]
        public const int FileAttributeSystem = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_DIRECTORY")]
        public const int FileAttributeDirectory = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_ARCHIVE")]
        public const int FileAttributeArchive = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_DEVICE")]
        public const int FileAttributeDevice = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_NORMAL")]
        public const int FileAttributeNormal = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_TEMPORARY")]
        public const int FileAttributeTemporary = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_SPARSE_FILE")]
        public const int FileAttributeSparseFile = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_REPARSE_POINT")]
        public const int FileAttributeReparsePoint = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_COMPRESSED")]
        public const int FileAttributeCompressed = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_OFFLINE")]
        public const int FileAttributeOffline = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_NOT_CONTENT_INDEXED")]
        public const int FileAttributeNotContentIndexed = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_ENCRYPTED")]
        public const int FileAttributeEncrypted = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_INTEGRITY_STREAM")]
        public const int FileAttributeIntegrityStream = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_VIRTUAL")]
        public const int FileAttributeVirtual = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_NO_SCRUB_DATA")]
        public const int FileAttributeNoScrubData = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_EA")]
        public const int FileAttributeEA = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_PINNED")]
        public const int FileAttributePinned = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_UNPINNED")]
        public const int FileAttributeUnpinned = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_RECALL_ON_OPEN")]
        public const int FileAttributeRecallOnOpen = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS")]
        public const int FileAttributeRecallOnDataAccess = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TREE_CONNECT_ATTRIBUTE_PRIVACY")]
        public const int TreeConnectAttributePrivacy = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TREE_CONNECT_ATTRIBUTE_INTEGRITY")]
        public const int TreeConnectAttributeIntegrity = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TREE_CONNECT_ATTRIBUTE_GLOBAL")]
        public const int TreeConnectAttributeGlobal = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TREE_CONNECT_ATTRIBUTE_PINNED")]
        public const int TreeConnectAttributePinned = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL")]
        public const int FileAttributeStrictlySequential = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_FILE_NAME")]
        public const int FileNotifyChangeFileName = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_DIR_NAME")]
        public const int FileNotifyChangeDirName = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_ATTRIBUTES")]
        public const int FileNotifyChangeAttributes = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_SIZE")]
        public const int FileNotifyChangeSize = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_LAST_WRITE")]
        public const int FileNotifyChangeLastWrite = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_LAST_ACCESS")]
        public const int FileNotifyChangeLastAccess = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_CREATION")]
        public const int FileNotifyChangeCreation = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NOTIFY_CHANGE_SECURITY")]
        public const int FileNotifyChangeSecurity = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ACTION_ADDED")]
        public const int FileActionAdded = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ACTION_REMOVED")]
        public const int FileActionRemoved = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ACTION_MODIFIED")]
        public const int FileActionModified = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ACTION_RENAMED_OLD_NAME")]
        public const int FileActionRenamedOldName = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_ACTION_RENAMED_NEW_NAME")]
        public const int FileActionRenamedNewName = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_CASE_SENSITIVE_SEARCH")]
        public const int FileCaseSensitiveSearch = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_CASE_PRESERVED_NAMES")]
        public const int FileCasePreservedNames = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_UNICODE_ON_DISK")]
        public const int FileUnicodeOnDisk = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_PERSISTENT_ACLS")]
        public const int FilePersistentAcls = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_FILE_COMPRESSION")]
        public const int FileFileCompression = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_VOLUME_QUOTAS")]
        public const int FileVolumeQuotas = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_SPARSE_FILES")]
        public const int FileSupportsSparseFiles = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_REPARSE_POINTS")]
        public const int FileSupportsReparsePoints = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_REMOTE_STORAGE")]
        public const int FileSupportsRemoteStorage = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_RETURNS_CLEANUP_RESULT_INFO")]
        public const int FileReturnsCleanupResultInfo = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_POSIX_UNLINK_RENAME")]
        public const int FileSupportsPosixUnlinkRename = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_BYPASS_IO")]
        public const int FileSupportsBypassIO = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_VOLUME_IS_COMPRESSED")]
        public const int FileVolumeIsCompressed = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_OBJECT_IDS")]
        public const int FileSupportsObjectIds = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_ENCRYPTION")]
        public const int FileSupportsEncryption = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_NAMED_STREAMS")]
        public const int FileNamedStreams = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_READ_ONLY_VOLUME")]
        public const int FileReadOnlyVolume = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SEQUENTIAL_WRITE_ONCE")]
        public const int FileSequentialWriteOnce = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_TRANSACTIONS")]
        public const int FileSupportsTransactions = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_HARD_LINKS")]
        public const int FileSupportsHardLinks = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_EXTENDED_ATTRIBUTES")]
        public const int FileSupportsExtendedAttributes = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_OPEN_BY_FILE_ID")]
        public const int FileSupportsOpenByFileID = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_USN_JOURNAL")]
        public const int FileSupportsUsnJournal = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_INTEGRITY_STREAMS")]
        public const int FileSupportsIntegrityStreams = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_BLOCK_REFCOUNTING")]
        public const int FileSupportsBlockRefcounting = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_SPARSE_VDL")]
        public const int FileSupportsSparseVdl = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_DAX_VOLUME")]
        public const int FileDaxVolume = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_SUPPORTS_GHOSTING")]
        public const int FileSupportsGhosting = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILE_CS_FLAG_CASE_SENSITIVE_DIR")]
        public const int FileCSFlagCaseSensitiveDir = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FLUSH_FLAGS_FILE_DATA_ONLY")]
        public const int FlushFlagsFileDataOnly = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FLUSH_FLAGS_NO_SYNC")]
        public const int FlushFlagsNoSync = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FLUSH_FLAGS_FILE_DATA_SYNC_ONLY")]
        public const int FlushFlagsFileDataSyncOnly = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IO_REPARSE_TAG_RESERVED_ZERO")]
        public const int IOReparseTagReservedZero = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IO_REPARSE_TAG_RESERVED_ONE")]
        public const int IOReparseTagReservedOne = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IO_REPARSE_TAG_RESERVED_TWO")]
        public const int IOReparseTagReservedTwo = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IO_REPARSE_TAG_RESERVED_RANGE")]
        public const int IOReparseTagReservedRange = unchecked((int) 0x2);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_MOUNT_POINT")]
        public const uint IOReparseTagMountPoint = unchecked((uint) 0xFFFFFFFFA0000003);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_HSM")]
        public const uint IOReparseTagHsm = unchecked((uint) 0xFFFFFFFFC0000004);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_HSM2")]
        public const uint IOReparseTagHsm2 = unchecked((uint) 0xFFFFFFFF80000006);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_SIS")]
        public const uint IOReparseTagSis = unchecked((uint) 0xFFFFFFFF80000007);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WIM")]
        public const uint IOReparseTagWim = unchecked((uint) 0xFFFFFFFF80000008);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CSV")]
        public const uint IOReparseTagCsv = unchecked((uint) 0xFFFFFFFF80000009);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_DFS")]
        public const uint IOReparseTagDfs = unchecked((uint) 0xFFFFFFFF8000000A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_SYMLINK")]
        public const uint IOReparseTagSymlink = unchecked((uint) 0xFFFFFFFFA000000C);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_DFSR")]
        public const uint IOReparseTagDfsr = unchecked((uint) 0xFFFFFFFF80000012);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_DEDUP")]
        public const uint IOReparseTagDedup = unchecked((uint) 0xFFFFFFFF80000013);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_NFS")]
        public const uint IOReparseTagNfs = unchecked((uint) 0xFFFFFFFF80000014);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_FILE_PLACEHOLDER")]
        public const uint IOReparseTagFilePlaceholder = unchecked((uint) 0xFFFFFFFF80000015);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WOF")]
        public const uint IOReparseTagWof = unchecked((uint) 0xFFFFFFFF80000017);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WCI")]
        public const uint IOReparseTagWci = unchecked((uint) 0xFFFFFFFF80000018);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WCI_1")]
        public const uint IOReparseTagWci1 = unchecked((uint) 0xFFFFFFFF90001018);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_GLOBAL_REPARSE")]
        public const uint IOReparseTagGlobalReparse = unchecked((uint) 0xFFFFFFFFA0000019);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD")]
        public const uint IOReparseTagCloud = unchecked((uint) 0xFFFFFFFF9000001A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_1")]
        public const uint IOReparseTagCloud1 = unchecked((uint) 0xFFFFFFFF9000101A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_2")]
        public const uint IOReparseTagCloud2 = unchecked((uint) 0xFFFFFFFF9000201A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_3")]
        public const uint IOReparseTagCloud3 = unchecked((uint) 0xFFFFFFFF9000301A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_4")]
        public const uint IOReparseTagCloud4 = unchecked((uint) 0xFFFFFFFF9000401A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_5")]
        public const uint IOReparseTagCloud5 = unchecked((uint) 0xFFFFFFFF9000501A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_6")]
        public const uint IOReparseTagCloud6 = unchecked((uint) 0xFFFFFFFF9000601A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_7")]
        public const uint IOReparseTagCloud7 = unchecked((uint) 0xFFFFFFFF9000701A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_8")]
        public const uint IOReparseTagCloud8 = unchecked((uint) 0xFFFFFFFF9000801A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_9")]
        public const uint IOReparseTagCloud9 = unchecked((uint) 0xFFFFFFFF9000901A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_A")]
        public const uint IOReparseTagCloudA = unchecked((uint) 0xFFFFFFFF9000A01A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_B")]
        public const uint IOReparseTagCloudB = unchecked((uint) 0xFFFFFFFF9000B01A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_C")]
        public const uint IOReparseTagCloudC = unchecked((uint) 0xFFFFFFFF9000C01A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_D")]
        public const uint IOReparseTagCloudD = unchecked((uint) 0xFFFFFFFF9000D01A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_E")]
        public const uint IOReparseTagCloudE = unchecked((uint) 0xFFFFFFFF9000E01A);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_F")]
        public const uint IOReparseTagCloudF = unchecked((uint) 0xFFFFFFFF9000F01A);
        [NativeName("Type", "long")]
        [NativeName("Name", "IO_REPARSE_TAG_CLOUD_MASK")]
        public const int IOReparseTagCloudMask = unchecked((int) 0xF000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_APPEXECLINK")]
        public const uint IOReparseTagAppexeclink = unchecked((uint) 0xFFFFFFFF8000001B);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_PROJFS")]
        public const uint IOReparseTagProjfs = unchecked((uint) 0xFFFFFFFF9000001C);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_STORAGE_SYNC")]
        public const uint IOReparseTagStorageSync = unchecked((uint) 0xFFFFFFFF8000001E);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WCI_TOMBSTONE")]
        public const uint IOReparseTagWciTombstone = unchecked((uint) 0xFFFFFFFFA000001F);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_UNHANDLED")]
        public const uint IOReparseTagUnhandled = unchecked((uint) 0xFFFFFFFF80000020);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_ONEDRIVE")]
        public const uint IOReparseTagOnedrive = unchecked((uint) 0xFFFFFFFF80000021);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_PROJFS_TOMBSTONE")]
        public const uint IOReparseTagProjfsTombstone = unchecked((uint) 0xFFFFFFFFA0000022);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_AF_UNIX")]
        public const uint IOReparseTagAFUnix = unchecked((uint) 0xFFFFFFFF80000023);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WCI_LINK")]
        public const uint IOReparseTagWciLink = unchecked((uint) 0xFFFFFFFFA0000027);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_WCI_LINK_1")]
        public const uint IOReparseTagWciLink1 = unchecked((uint) 0xFFFFFFFFA0001027);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "IO_REPARSE_TAG_DATALESS_CIM")]
        public const uint IOReparseTagDatalessCim = unchecked((uint) 0xFFFFFFFFA0000028);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_RESUME")]
        public const int ScrubDataInputFlagResume = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC")]
        public const int ScrubDataInputFlagSkipInSync = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA")]
        public const int ScrubDataInputFlagSkipNonIntegrityData = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY")]
        public const int ScrubDataInputFlagIgnoreRedundancy = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_SKIP_DATA")]
        public const int ScrubDataInputFlagSkipData = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID")]
        public const int ScrubDataInputFlagScrubByObjectID = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED")]
        public const int ScrubDataInputFlagOplockNotAcquired = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE")]
        public const int ScrubDataOutputFlagIncomplete = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE")]
        public const int ScrubDataOutputFlagNonUserDataRange = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED")]
        public const int ScrubDataOutputFlagParityExtentDataReturned = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED")]
        public const int ScrubDataOutputFlagResumeContextLengthSpecified = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS")]
        public const int ShuffleFileFlagSkipInitializingNewClusters = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IO_COMPLETION_MODIFY_STATE")]
        public const int IOCompletionModifyState = unchecked((int) 0x2);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "IO_QOS_MAX_RESERVATION")]
        public const ulong IOQosMaxReservation = unchecked((ulong) 0x3B9ACA00);
        [NativeName("Type", "")]
        [NativeName("Name", "SMB_CCF_APP_INSTANCE_EA_NAME")]
        public const string SmbCcfAppInstanceEAName = unchecked((string) "ClusteredApplicationInstance");
        [NativeName("Type", "int")]
        [NativeName("Name", "NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR")]
        public const int NetworkAppInstanceCsvFlagsValidOnlyIFCsvCoordinator = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DUPLICATE_CLOSE_SOURCE")]
        public const int DuplicateCloseSource = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DUPLICATE_SAME_ACCESS")]
        public const int DuplicateSameAccess = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_INDEX_NOTHING")]
        public const int PowerbuttonActionIndexNothing = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_INDEX_SLEEP")]
        public const int PowerbuttonActionIndexSleep = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_INDEX_HIBERNATE")]
        public const int PowerbuttonActionIndexHibernate = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_INDEX_SHUTDOWN")]
        public const int PowerbuttonActionIndexShutdown = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY")]
        public const int PowerbuttonActionIndexTurnOffTheDisplay = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_VALUE_NOTHING")]
        public const int PowerbuttonActionValueNothing = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_VALUE_SLEEP")]
        public const int PowerbuttonActionValueSleep = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_VALUE_HIBERNATE")]
        public const int PowerbuttonActionValueHibernate = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_VALUE_SHUTDOWN")]
        public const int PowerbuttonActionValueShutdown = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY")]
        public const int PowerbuttonActionValueTurnOffTheDisplay = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_IDEAL")]
        public const int PerfstatePolicyChangeIdeal = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_SINGLE")]
        public const int PerfstatePolicyChangeSingle = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_ROCKET")]
        public const int PerfstatePolicyChangeRocket = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE")]
        public const int PerfstatePolicyChangeIdealAggressive = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_DECREASE_MAX")]
        public const int PerfstatePolicyChangeDecreaseMax = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFSTATE_POLICY_CHANGE_INCREASE_MAX")]
        public const int PerfstatePolicyChangeIncreaseMax = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_THROTTLE_DISABLED")]
        public const int ProcessorThrottleDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_THROTTLE_ENABLED")]
        public const int ProcessorThrottleEnabled = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_THROTTLE_AUTOMATIC")]
        public const int ProcessorThrottleAutomatic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_POLICY_DISABLED")]
        public const int ProcessorPerfBoostPolicyDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_POLICY_MAX")]
        public const int ProcessorPerfBoostPolicyMax = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_DISABLED")]
        public const int ProcessorPerfBoostModeDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_ENABLED")]
        public const int ProcessorPerfBoostModeEnabled = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE")]
        public const int ProcessorPerfBoostModeAggressive = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED")]
        public const int ProcessorPerfBoostModeEfficientEnabled = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE")]
        public const int ProcessorPerfBoostModeEfficientAggressive = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED")]
        public const int ProcessorPerfBoostModeAggressiveATGuaranteed = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED")]
        public const int ProcessorPerfBoostModeEfficientAggressiveATGuaranteed = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_BOOST_MODE_MAX")]
        public const int ProcessorPerfBoostModeMax = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED")]
        public const int ProcessorPerfAutonomousModeDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED")]
        public const int ProcessorPerfAutonomousModeEnabled = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_PERFORMANCE_PREFERENCE")]
        public const int ProcessorPerfPerformancePreference = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_ENERGY_PREFERENCE")]
        public const int ProcessorPerfEnergyPreference = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW")]
        public const int ProcessorPerfMinimumActivityWindow = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW")]
        public const int ProcessorPerfMaximumActivityWindow = unchecked((int) 0x4BB2A980);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_DUTY_CYCLING_DISABLED")]
        public const int ProcessorDutyCyclingDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_DUTY_CYCLING_ENABLED")]
        public const int ProcessorDutyCyclingEnabled = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CORE_PARKING_POLICY_CHANGE_IDEAL")]
        public const int CoreParkingPolicyChangeIdeal = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "CORE_PARKING_POLICY_CHANGE_SINGLE")]
        public const int CoreParkingPolicyChangeSingle = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CORE_PARKING_POLICY_CHANGE_ROCKET")]
        public const int CoreParkingPolicyChangeRocket = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CORE_PARKING_POLICY_CHANGE_MULTISTEP")]
        public const int CoreParkingPolicyChangeMultistep = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "CORE_PARKING_POLICY_CHANGE_MAX")]
        public const int CoreParkingPolicyChangeMax = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_DEVICE_IDLE_POLICY_PERFORMANCE")]
        public const int PowerDeviceIdlePolicyPerformance = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_DEVICE_IDLE_POLICY_CONSERVATIVE")]
        public const int PowerDeviceIdlePolicyConservative = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_CONNECTIVITY_IN_STANDBY_DISABLED")]
        public const int PowerConnectivityInStandbyDisabled = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_CONNECTIVITY_IN_STANDBY_ENABLED")]
        public const int PowerConnectivityInStandbyEnabled = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED")]
        public const int PowerConnectivityInStandbySystemManaged = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_DISCONNECTED_STANDBY_MODE_NORMAL")]
        public const int PowerDisconnectedStandbyModeNormal = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE")]
        public const int PowerDisconnectedStandbyModeAggressive = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_SYSTEM_MAXIMUM")]
        public const int PowerSystemMaximum = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "DIAGNOSTIC_REASON_VERSION")]
        public const int DiagnosticReasonVersion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DIAGNOSTIC_REASON_SIMPLE_STRING")]
        public const int DiagnosticReasonSimpleString = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DIAGNOSTIC_REASON_DETAILED_STRING")]
        public const int DiagnosticReasonDetailedString = unchecked((int) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "DIAGNOSTIC_REASON_NOT_SPECIFIED")]
        public const uint DiagnosticReasonNotSpecified = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_REQUEST_CONTEXT_VERSION")]
        public const int PowerRequestContextVersion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_REQUEST_CONTEXT_SIMPLE_STRING")]
        public const int PowerRequestContextSimpleString = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_REQUEST_CONTEXT_DETAILED_STRING")]
        public const int PowerRequestContextDetailedString = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_D0_SUPPORTED")]
        public const int PdcapD0Supported = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_D1_SUPPORTED")]
        public const int PdcapD1Supported = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_D2_SUPPORTED")]
        public const int PdcapD2Supported = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_D3_SUPPORTED")]
        public const int PdcapD3Supported = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_WAKE_FROM_D0_SUPPORTED")]
        public const int PdcapWakeFromD0Supported = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_WAKE_FROM_D1_SUPPORTED")]
        public const int PdcapWakeFromD1Supported = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_WAKE_FROM_D2_SUPPORTED")]
        public const int PdcapWakeFromD2Supported = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_WAKE_FROM_D3_SUPPORTED")]
        public const int PdcapWakeFromD3Supported = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "PDCAP_WARM_EJECT_SUPPORTED")]
        public const int PdcapWarmEjectSupported = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_SETTING_VALUE_VERSION")]
        public const int PowerSettingValueVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_PLATFORM_ROLE_V1")]
        public const int PowerPlatformRoleV1 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_PLATFORM_ROLE_V2")]
        public const int PowerPlatformRoleV2 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_PLATFORM_ROLE_VERSION")]
        public const int PowerPlatformRoleVersion = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROC_IDLE_BUCKET_COUNT")]
        public const int ProcIdleBucketCount = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROC_IDLE_BUCKET_COUNT_EX")]
        public const int ProcIdleBucketCountEX = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACPI_PPM_SOFTWARE_ALL")]
        public const int AcpiPpmSoftwareAll = unchecked((int) 0xFC);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACPI_PPM_SOFTWARE_ANY")]
        public const int AcpiPpmSoftwareAny = unchecked((int) 0xFD);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACPI_PPM_HARDWARE_ALL")]
        public const int AcpiPpmHardwareAll = unchecked((int) 0xFE);
        [NativeName("Type", "int")]
        [NativeName("Name", "MS_PPM_SOFTWARE_ALL")]
        public const int MSPpmSoftwareAll = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_ACPI1C2")]
        public const int PpmFirmwareAcpi1C2 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_ACPI1C3")]
        public const int PpmFirmwareAcpi1C3 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_ACPI1TSTATES")]
        public const int PpmFirmwareAcpi1Tstates = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_CST")]
        public const int PpmFirmwareCst = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_CSD")]
        public const int PpmFirmwareCsd = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PCT")]
        public const int PpmFirmwarePct = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PSS")]
        public const int PpmFirmwarePss = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_XPSS")]
        public const int PpmFirmwareXpss = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PPC")]
        public const int PpmFirmwarePpc = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PSD")]
        public const int PpmFirmwarePsd = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PTC")]
        public const int PpmFirmwarePtc = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_TSS")]
        public const int PpmFirmwareTss = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_TPC")]
        public const int PpmFirmwareTpc = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_TSD")]
        public const int PpmFirmwareTsd = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PCCH")]
        public const int PpmFirmwarePcch = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PCCP")]
        public const int PpmFirmwarePccp = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_OSC")]
        public const int PpmFirmwareOsc = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_PDC")]
        public const int PpmFirmwarePdc = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_CPC")]
        public const int PpmFirmwareCpc = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_FIRMWARE_LPI")]
        public const int PpmFirmwareLpi = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_PERFORMANCE_IMPLEMENTATION_NONE")]
        public const int PpmPerformanceImplementationNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_PERFORMANCE_IMPLEMENTATION_PSTATES")]
        public const int PpmPerformanceImplementationPstates = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_PERFORMANCE_IMPLEMENTATION_PCCV1")]
        public const int PpmPerformanceImplementationPccv1 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_PERFORMANCE_IMPLEMENTATION_CPPC")]
        public const int PpmPerformanceImplementationCppc = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_PERFORMANCE_IMPLEMENTATION_PEP")]
        public const int PpmPerformanceImplementationPep = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_IDLE_IMPLEMENTATION_NONE")]
        public const int PpmIdleImplementationNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_IDLE_IMPLEMENTATION_CSTATES")]
        public const int PpmIdleImplementationCstates = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_IDLE_IMPLEMENTATION_PEP")]
        public const int PpmIdleImplementationPep = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_IDLE_IMPLEMENTATION_MICROPEP")]
        public const int PpmIdleImplementationMicropep = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PPM_IDLE_IMPLEMENTATION_LPISTATES")]
        public const int PpmIdleImplementationLpistates = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_QUERY_ALLOWED")]
        public const int PowerActionQueryAllowed = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_UI_ALLOWED")]
        public const int PowerActionUIAllowed = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_OVERRIDE_APPS")]
        public const int PowerActionOverrideApps = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_HIBERBOOT")]
        public const int PowerActionHiberboot = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_USER_NOTIFY")]
        public const int PowerActionUserNotify = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_DOZE_TO_HIBERNATE")]
        public const int PowerActionDozeToHibernate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_ACPI_CRITICAL")]
        public const int PowerActionAcpiCritical = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_ACPI_USER_NOTIFY")]
        public const int PowerActionAcpiUserNotify = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_DIRECTED_DRIPS")]
        public const int PowerActionDirectedDrips = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_PSEUDO_TRANSITION")]
        public const int PowerActionPseudoTransition = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_LIGHTEST_FIRST")]
        public const int PowerActionLightestFirst = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_LOCK_CONSOLE")]
        public const int PowerActionLockConsole = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_ACTION_DISABLE_WAKES")]
        public const int PowerActionDisableWakes = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "POWER_ACTION_CRITICAL")]
        public const uint PowerActionCritical = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_LEVEL_USER_NOTIFY_TEXT")]
        public const int PowerLevelUserNotifyText = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_LEVEL_USER_NOTIFY_SOUND")]
        public const int PowerLevelUserNotifySound = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_LEVEL_USER_NOTIFY_EXEC")]
        public const int PowerLevelUserNotifyExec = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_USER_NOTIFY_BUTTON")]
        public const int PowerUserNotifyButton = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_USER_NOTIFY_SHUTDOWN")]
        public const int PowerUserNotifyShutdown = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "POWER_USER_NOTIFY_FORCED_SHUTDOWN")]
        public const int PowerUserNotifyForcedShutdown = unchecked((int) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "POWER_FORCE_TRIGGER_RESET")]
        public const uint PowerForceTriggerReset = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK")]
        public const int BatteryDischargeFlagsEventcodeMask = unchecked((int) 0x7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "BATTERY_DISCHARGE_FLAGS_ENABLE")]
        public const uint BatteryDischargeFlagsEnable = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "NUM_DISCHARGE_POLICIES")]
        public const int NumDischargePolicies = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "DISCHARGE_POLICY_CRITICAL")]
        public const int DischargePolicyCritical = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DISCHARGE_POLICY_LOW")]
        public const int DischargePolicyLow = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESSOR_IDLESTATE_POLICY_COUNT")]
        public const int ProcessorIdlestatePolicyCount = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PO_THROTTLE_NONE")]
        public const int POThrottleNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "PO_THROTTLE_CONSTANT")]
        public const int POThrottleConstant = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PO_THROTTLE_DEGRADE")]
        public const int POThrottleDegrade = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PO_THROTTLE_ADAPTIVE")]
        public const int POThrottleAdaptive = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "PO_THROTTLE_MAXIMUM")]
        public const int POThrottleMaximum = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "HIBERFILE_TYPE_NONE")]
        public const int HiberfileTypeNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "HIBERFILE_TYPE_REDUCED")]
        public const int HiberfileTypeReduced = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HIBERFILE_TYPE_FULL")]
        public const int HiberfileTypeFull = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "HIBERFILE_TYPE_MAX")]
        public const int HiberfileTypeMax = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DOS_SIGNATURE")]
        public const int ImageDosSignature = unchecked((int) 0x5A4D);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_OS2_SIGNATURE")]
        public const int ImageOS2Signature = unchecked((int) 0x454E);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_OS2_SIGNATURE_LE")]
        public const int ImageOS2SignatureLE = unchecked((int) 0x454C);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_VXD_SIGNATURE")]
        public const int ImageVxdSignature = unchecked((int) 0x454C);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_NT_SIGNATURE")]
        public const int ImageNTSignature = unchecked((int) 0x4550);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SIZEOF_FILE_HEADER")]
        public const int ImageSizeofFileHeader = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_RELOCS_STRIPPED")]
        public const int ImageFileRelocsStripped = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_EXECUTABLE_IMAGE")]
        public const int ImageFileExecutableImage = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_LINE_NUMS_STRIPPED")]
        public const int ImageFileLineNumsStripped = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_LOCAL_SYMS_STRIPPED")]
        public const int ImageFileLocalSymsStripped = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_AGGRESIVE_WS_TRIM")]
        public const int ImageFileAggresiveWSTrim = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_LARGE_ADDRESS_AWARE")]
        public const int ImageFileLargeAddressAware = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_BYTES_REVERSED_LO")]
        public const int ImageFileBytesReversedLO = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_32BIT_MACHINE")]
        public const int ImageFile32BitMachine = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_DEBUG_STRIPPED")]
        public const int ImageFileDebugStripped = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP")]
        public const int ImageFileRemovableRunFromSwap = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_NET_RUN_FROM_SWAP")]
        public const int ImageFileNetRunFromSwap = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_SYSTEM")]
        public const int ImageFileSystem = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_DLL")]
        public const int ImageFileDll = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_UP_SYSTEM_ONLY")]
        public const int ImageFileUpSystemOnly = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_BYTES_REVERSED_HI")]
        public const int ImageFileBytesReversedHI = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_UNKNOWN")]
        public const int ImageFileMachineUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_TARGET_HOST")]
        public const int ImageFileMachineTargetHost = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_I386")]
        public const int ImageFileMachineI386 = unchecked((int) 0x14C);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_R3000")]
        public const int ImageFileMachineR3000 = unchecked((int) 0x162);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_R4000")]
        public const int ImageFileMachineR4000 = unchecked((int) 0x166);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_R10000")]
        public const int ImageFileMachineR10000 = unchecked((int) 0x168);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_WCEMIPSV2")]
        public const int ImageFileMachineWcemipsv2 = unchecked((int) 0x169);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_ALPHA")]
        public const int ImageFileMachineAlpha = unchecked((int) 0x184);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_SH3")]
        public const int ImageFileMachineSH3 = unchecked((int) 0x1A2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_SH3DSP")]
        public const int ImageFileMachineSH3Dsp = unchecked((int) 0x1A3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_SH3E")]
        public const int ImageFileMachineSH3E = unchecked((int) 0x1A4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_SH4")]
        public const int ImageFileMachineSH4 = unchecked((int) 0x1A6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_SH5")]
        public const int ImageFileMachineSH5 = unchecked((int) 0x1A8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_ARM")]
        public const int ImageFileMachineArm = unchecked((int) 0x1C0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_THUMB")]
        public const int ImageFileMachineThumb = unchecked((int) 0x1C2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_ARMNT")]
        public const int ImageFileMachineArmnt = unchecked((int) 0x1C4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_AM33")]
        public const int ImageFileMachineAM33 = unchecked((int) 0x1D3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_POWERPC")]
        public const int ImageFileMachinePowerpc = unchecked((int) 0x1F0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_POWERPCFP")]
        public const int ImageFileMachinePowerpcfp = unchecked((int) 0x1F1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_IA64")]
        public const int ImageFileMachineIA64 = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_MIPS16")]
        public const int ImageFileMachineMips16 = unchecked((int) 0x266);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_ALPHA64")]
        public const int ImageFileMachineAlpha64 = unchecked((int) 0x284);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_MIPSFPU")]
        public const int ImageFileMachineMipsfpu = unchecked((int) 0x366);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_MIPSFPU16")]
        public const int ImageFileMachineMipsfpu16 = unchecked((int) 0x466);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_AXP64")]
        public const int ImageFileMachineAxp64 = unchecked((int) 0x284);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_TRICORE")]
        public const int ImageFileMachineTricore = unchecked((int) 0x520);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_CEF")]
        public const int ImageFileMachineCef = unchecked((int) 0xCEF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_EBC")]
        public const int ImageFileMachineEbc = unchecked((int) 0xEBC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_AMD64")]
        public const int ImageFileMachineAmd64 = unchecked((int) 0x8664);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_M32R")]
        public const int ImageFileMachineM32R = unchecked((int) 0x9041);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_ARM64")]
        public const int ImageFileMachineArm64 = unchecked((int) 0xAA64);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_FILE_MACHINE_CEE")]
        public const int ImageFileMachineCee = unchecked((int) 0xC0EE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_NUMBEROF_DIRECTORY_ENTRIES")]
        public const int ImageNumberofDirectoryEntries = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_NT_OPTIONAL_HDR32_MAGIC")]
        public const int ImageNTOptionalHdr32Magic = unchecked((int) 0x10B);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_NT_OPTIONAL_HDR64_MAGIC")]
        public const int ImageNTOptionalHdr64Magic = unchecked((int) 0x20B);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ROM_OPTIONAL_HDR_MAGIC")]
        public const int ImageRomOptionalHdrMagic = unchecked((int) 0x107);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_NT_OPTIONAL_HDR_MAGIC")]
        public const int ImageNTOptionalHdrMagic = unchecked((int) 0x10B);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_UNKNOWN")]
        public const int ImageSubsystemUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_NATIVE")]
        public const int ImageSubsystemNative = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_WINDOWS_GUI")]
        public const int ImageSubsystemWindowsGui = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_WINDOWS_CUI")]
        public const int ImageSubsystemWindowsCui = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_OS2_CUI")]
        public const int ImageSubsystemOS2Cui = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_POSIX_CUI")]
        public const int ImageSubsystemPosixCui = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_NATIVE_WINDOWS")]
        public const int ImageSubsystemNativeWindows = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_WINDOWS_CE_GUI")]
        public const int ImageSubsystemWindowsCEGui = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_EFI_APPLICATION")]
        public const int ImageSubsystemEfiApplication = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER")]
        public const int ImageSubsystemEfiBootServiceDriver = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER")]
        public const int ImageSubsystemEfiRuntimeDriver = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_EFI_ROM")]
        public const int ImageSubsystemEfiRom = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_XBOX")]
        public const int ImageSubsystemXbox = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION")]
        public const int ImageSubsystemWindowsBootApplication = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG")]
        public const int ImageSubsystemXboxCodeCatalog = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA")]
        public const int ImageDllcharacteristicsHighEntropyVA = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE")]
        public const int ImageDllcharacteristicsDynamicBase = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY")]
        public const int ImageDllcharacteristicsForceIntegrity = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_NX_COMPAT")]
        public const int ImageDllcharacteristicsNXCompat = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_NO_ISOLATION")]
        public const int ImageDllcharacteristicsNoIsolation = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_NO_SEH")]
        public const int ImageDllcharacteristicsNoSeh = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_NO_BIND")]
        public const int ImageDllcharacteristicsNoBind = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_APPCONTAINER")]
        public const int ImageDllcharacteristicsAppcontainer = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_WDM_DRIVER")]
        public const int ImageDllcharacteristicsWdmDriver = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_GUARD_CF")]
        public const int ImageDllcharacteristicsGuardCF = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE")]
        public const int ImageDllcharacteristicsTerminalServerAware = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_EXPORT")]
        public const int ImageDirectoryEntryExport = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_IMPORT")]
        public const int ImageDirectoryEntryImport = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_RESOURCE")]
        public const int ImageDirectoryEntryResource = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_EXCEPTION")]
        public const int ImageDirectoryEntryException = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_SECURITY")]
        public const int ImageDirectoryEntrySecurity = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_BASERELOC")]
        public const int ImageDirectoryEntryBasereloc = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_DEBUG")]
        public const int ImageDirectoryEntryDebug = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_ARCHITECTURE")]
        public const int ImageDirectoryEntryArchitecture = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_GLOBALPTR")]
        public const int ImageDirectoryEntryGlobalptr = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_TLS")]
        public const int ImageDirectoryEntryTls = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG")]
        public const int ImageDirectoryEntryLoadConfig = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT")]
        public const int ImageDirectoryEntryBoundImport = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_IAT")]
        public const int ImageDirectoryEntryIat = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT")]
        public const int ImageDirectoryEntryDelayImport = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR")]
        public const int ImageDirectoryEntryComDescriptor = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SIZEOF_SHORT_NAME")]
        public const int ImageSizeofShortName = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SIZEOF_SECTION_HEADER")]
        public const int ImageSizeofSectionHeader = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_TYPE_NO_PAD")]
        public const int ImageScnTypeNoPad = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_CNT_CODE")]
        public const int ImageScnCntCode = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_CNT_INITIALIZED_DATA")]
        public const int ImageScnCntInitializedData = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_CNT_UNINITIALIZED_DATA")]
        public const int ImageScnCntUninitializedData = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_LNK_OTHER")]
        public const int ImageScnLnkOther = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_LNK_INFO")]
        public const int ImageScnLnkInfo = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_LNK_REMOVE")]
        public const int ImageScnLnkRemove = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_LNK_COMDAT")]
        public const int ImageScnLnkComdat = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_NO_DEFER_SPEC_EXC")]
        public const int ImageScnNoDeferSpecExc = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_GPREL")]
        public const int ImageScnGprel = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_FARDATA")]
        public const int ImageScnMemFardata = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_PURGEABLE")]
        public const int ImageScnMemPurgeable = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_16BIT")]
        public const int ImageScnMem16Bit = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_LOCKED")]
        public const int ImageScnMemLocked = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_PRELOAD")]
        public const int ImageScnMemPreload = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_1BYTES")]
        public const int ImageScnAlign1Bytes = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_2BYTES")]
        public const int ImageScnAlign2Bytes = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_4BYTES")]
        public const int ImageScnAlign4Bytes = unchecked((int) 0x300000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_8BYTES")]
        public const int ImageScnAlign8Bytes = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_16BYTES")]
        public const int ImageScnAlign16Bytes = unchecked((int) 0x500000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_32BYTES")]
        public const int ImageScnAlign32Bytes = unchecked((int) 0x600000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_64BYTES")]
        public const int ImageScnAlign64Bytes = unchecked((int) 0x700000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_128BYTES")]
        public const int ImageScnAlign128Bytes = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_256BYTES")]
        public const int ImageScnAlign256Bytes = unchecked((int) 0x900000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_512BYTES")]
        public const int ImageScnAlign512Bytes = unchecked((int) 0xA00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_1024BYTES")]
        public const int ImageScnAlign1024Bytes = unchecked((int) 0xB00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_2048BYTES")]
        public const int ImageScnAlign2048Bytes = unchecked((int) 0xC00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_4096BYTES")]
        public const int ImageScnAlign4096Bytes = unchecked((int) 0xD00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_8192BYTES")]
        public const int ImageScnAlign8192Bytes = unchecked((int) 0xE00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_ALIGN_MASK")]
        public const int ImageScnAlignMask = unchecked((int) 0xF00000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_LNK_NRELOC_OVFL")]
        public const int ImageScnLnkNrelocOvfl = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_DISCARDABLE")]
        public const int ImageScnMemDiscardable = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_NOT_CACHED")]
        public const int ImageScnMemNotCached = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_NOT_PAGED")]
        public const int ImageScnMemNotPaged = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_SHARED")]
        public const int ImageScnMemShared = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_EXECUTE")]
        public const int ImageScnMemExecute = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_MEM_READ")]
        public const int ImageScnMemRead = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_SCN_MEM_WRITE")]
        public const uint ImageScnMemWrite = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SCN_SCALE_INDEX")]
        public const int ImageScnScaleIndex = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SIZEOF_SYMBOL")]
        public const int ImageSizeofSymbol = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_SECTION_MAX")]
        public const int ImageSymSectionMax = unchecked((int) 0xFEFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_SECTION_MAX_EX")]
        public const int ImageSymSectionMaxEX = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_NULL")]
        public const int ImageSymTypeNull = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_VOID")]
        public const int ImageSymTypeVoid = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_CHAR")]
        public const int ImageSymTypeChar = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_SHORT")]
        public const int ImageSymTypeShort = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_INT")]
        public const int ImageSymTypeInt = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_LONG")]
        public const int ImageSymTypeLong = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_FLOAT")]
        public const int ImageSymTypeFloat = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_DOUBLE")]
        public const int ImageSymTypeDouble = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_STRUCT")]
        public const int ImageSymTypeStruct = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_UNION")]
        public const int ImageSymTypeUnion = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_ENUM")]
        public const int ImageSymTypeEnum = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_MOE")]
        public const int ImageSymTypeMoe = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_BYTE")]
        public const int ImageSymTypeByte = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_WORD")]
        public const int ImageSymTypeWord = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_UINT")]
        public const int ImageSymTypeUint = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_DWORD")]
        public const int ImageSymTypeDword = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_TYPE_PCODE")]
        public const int ImageSymTypePcode = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_DTYPE_NULL")]
        public const int ImageSymDtypeNull = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_DTYPE_POINTER")]
        public const int ImageSymDtypePointer = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_DTYPE_FUNCTION")]
        public const int ImageSymDtypeFunction = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_DTYPE_ARRAY")]
        public const int ImageSymDtypeArray = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_NULL")]
        public const int ImageSymClassNull = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_AUTOMATIC")]
        public const int ImageSymClassAutomatic = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_EXTERNAL")]
        public const int ImageSymClassExternal = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_STATIC")]
        public const int ImageSymClassStatic = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_REGISTER")]
        public const int ImageSymClassRegister = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_EXTERNAL_DEF")]
        public const int ImageSymClassExternalDef = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_LABEL")]
        public const int ImageSymClassLabel = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_UNDEFINED_LABEL")]
        public const int ImageSymClassUndefinedLabel = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_MEMBER_OF_STRUCT")]
        public const int ImageSymClassMemberOfStruct = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_ARGUMENT")]
        public const int ImageSymClassArgument = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_STRUCT_TAG")]
        public const int ImageSymClassStructTag = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_MEMBER_OF_UNION")]
        public const int ImageSymClassMemberOfUnion = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_UNION_TAG")]
        public const int ImageSymClassUnionTag = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_TYPE_DEFINITION")]
        public const int ImageSymClassTypeDefinition = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_UNDEFINED_STATIC")]
        public const int ImageSymClassUndefinedStatic = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_ENUM_TAG")]
        public const int ImageSymClassEnumTag = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_MEMBER_OF_ENUM")]
        public const int ImageSymClassMemberOfEnum = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_REGISTER_PARAM")]
        public const int ImageSymClassRegisterParam = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_BIT_FIELD")]
        public const int ImageSymClassBitField = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_FAR_EXTERNAL")]
        public const int ImageSymClassFarExternal = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_BLOCK")]
        public const int ImageSymClassBlock = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_FUNCTION")]
        public const int ImageSymClassFunction = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_END_OF_STRUCT")]
        public const int ImageSymClassEndOfStruct = unchecked((int) 0x66);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_FILE")]
        public const int ImageSymClassFile = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_SECTION")]
        public const int ImageSymClassSection = unchecked((int) 0x68);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_WEAK_EXTERNAL")]
        public const int ImageSymClassWeakExternal = unchecked((int) 0x69);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SYM_CLASS_CLR_TOKEN")]
        public const int ImageSymClassClrToken = unchecked((int) 0x6B);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_BTMASK")]
        public const int NBtmask = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_TMASK")]
        public const int NTmask = unchecked((int) 0x30);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_TMASK1")]
        public const int NTmask1 = unchecked((int) 0xC0);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_TMASK2")]
        public const int NTmask2 = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_BTSHFT")]
        public const int NBtshft = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "N_TSHIFT")]
        public const int NTshift = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_NODUPLICATES")]
        public const int ImageComdatSelectNoduplicates = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_ANY")]
        public const int ImageComdatSelectAny = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_SAME_SIZE")]
        public const int ImageComdatSelectSameSize = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_EXACT_MATCH")]
        public const int ImageComdatSelectExactMatch = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_ASSOCIATIVE")]
        public const int ImageComdatSelectAssociative = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_LARGEST")]
        public const int ImageComdatSelectLargest = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_COMDAT_SELECT_NEWEST")]
        public const int ImageComdatSelectNewest = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY")]
        public const int ImageWeakExternSearchNolibrary = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_WEAK_EXTERN_SEARCH_LIBRARY")]
        public const int ImageWeakExternSearchLibrary = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_WEAK_EXTERN_SEARCH_ALIAS")]
        public const int ImageWeakExternSearchAlias = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY")]
        public const int ImageWeakExternAntiDependency = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_ABSOLUTE")]
        public const int ImageRelI386Absolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_DIR16")]
        public const int ImageRelI386Dir16 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_REL16")]
        public const int ImageRelI386Rel16 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_DIR32")]
        public const int ImageRelI386Dir32 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_DIR32NB")]
        public const int ImageRelI386Dir32NB = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_SEG12")]
        public const int ImageRelI386Seg12 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_SECTION")]
        public const int ImageRelI386Section = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_SECREL")]
        public const int ImageRelI386Secrel = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_TOKEN")]
        public const int ImageRelI386Token = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_SECREL7")]
        public const int ImageRelI386Secrel7 = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_I386_REL32")]
        public const int ImageRelI386Rel32 = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_ABSOLUTE")]
        public const int ImageRelMipsAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_REFHALF")]
        public const int ImageRelMipsRefhalf = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_REFWORD")]
        public const int ImageRelMipsRefword = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_JMPADDR")]
        public const int ImageRelMipsJmpaddr = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_REFHI")]
        public const int ImageRelMipsRefhi = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_REFLO")]
        public const int ImageRelMipsReflo = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_GPREL")]
        public const int ImageRelMipsGprel = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_LITERAL")]
        public const int ImageRelMipsLiteral = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_SECTION")]
        public const int ImageRelMipsSection = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_SECREL")]
        public const int ImageRelMipsSecrel = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_SECRELLO")]
        public const int ImageRelMipsSecrello = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_SECRELHI")]
        public const int ImageRelMipsSecrelhi = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_TOKEN")]
        public const int ImageRelMipsToken = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_JMPADDR16")]
        public const int ImageRelMipsJmpaddr16 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_REFWORDNB")]
        public const int ImageRelMipsRefwordnb = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_MIPS_PAIR")]
        public const int ImageRelMipsPair = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_ABSOLUTE")]
        public const int ImageRelAlphaAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFLONG")]
        public const int ImageRelAlphaReflong = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFQUAD")]
        public const int ImageRelAlphaRefquad = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_GPREL32")]
        public const int ImageRelAlphaGprel32 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_LITERAL")]
        public const int ImageRelAlphaLiteral = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_LITUSE")]
        public const int ImageRelAlphaLituse = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_GPDISP")]
        public const int ImageRelAlphaGpdisp = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_BRADDR")]
        public const int ImageRelAlphaBraddr = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_HINT")]
        public const int ImageRelAlphaHint = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_INLINE_REFLONG")]
        public const int ImageRelAlphaInlineReflong = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFHI")]
        public const int ImageRelAlphaRefhi = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFLO")]
        public const int ImageRelAlphaReflo = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_PAIR")]
        public const int ImageRelAlphaPair = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_MATCH")]
        public const int ImageRelAlphaMatch = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_SECTION")]
        public const int ImageRelAlphaSection = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_SECREL")]
        public const int ImageRelAlphaSecrel = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFLONGNB")]
        public const int ImageRelAlphaReflongnb = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_SECRELLO")]
        public const int ImageRelAlphaSecrello = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_SECRELHI")]
        public const int ImageRelAlphaSecrelhi = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFQ3")]
        public const int ImageRelAlphaRefq3 = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFQ2")]
        public const int ImageRelAlphaRefq2 = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_REFQ1")]
        public const int ImageRelAlphaRefq1 = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_GPRELLO")]
        public const int ImageRelAlphaGprello = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ALPHA_GPRELHI")]
        public const int ImageRelAlphaGprelhi = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ABSOLUTE")]
        public const int ImageRelPpcAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR64")]
        public const int ImageRelPpcAddr64 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR32")]
        public const int ImageRelPpcAddr32 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR24")]
        public const int ImageRelPpcAddr24 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR16")]
        public const int ImageRelPpcAddr16 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR14")]
        public const int ImageRelPpcAddr14 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_REL24")]
        public const int ImageRelPpcRel24 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_REL14")]
        public const int ImageRelPpcRel14 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_TOCREL16")]
        public const int ImageRelPpcTocrel16 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_TOCREL14")]
        public const int ImageRelPpcTocrel14 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_ADDR32NB")]
        public const int ImageRelPpcAddr32NB = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_SECREL")]
        public const int ImageRelPpcSecrel = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_SECTION")]
        public const int ImageRelPpcSection = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_IFGLUE")]
        public const int ImageRelPpcIfglue = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_IMGLUE")]
        public const int ImageRelPpcImglue = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_SECREL16")]
        public const int ImageRelPpcSecrel16 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_REFHI")]
        public const int ImageRelPpcRefhi = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_REFLO")]
        public const int ImageRelPpcReflo = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_PAIR")]
        public const int ImageRelPpcPair = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_SECRELLO")]
        public const int ImageRelPpcSecrello = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_SECRELHI")]
        public const int ImageRelPpcSecrelhi = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_GPREL")]
        public const int ImageRelPpcGprel = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_TOKEN")]
        public const int ImageRelPpcToken = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_TYPEMASK")]
        public const int ImageRelPpcTypemask = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_NEG")]
        public const int ImageRelPpcNeg = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_BRTAKEN")]
        public const int ImageRelPpcBrtaken = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_BRNTAKEN")]
        public const int ImageRelPpcBrntaken = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_PPC_TOCDEFN")]
        public const int ImageRelPpcTocdefn = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_ABSOLUTE")]
        public const int ImageRelSH3Absolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT16")]
        public const int ImageRelSH3Direct16 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT32")]
        public const int ImageRelSH3Direct32 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT8")]
        public const int ImageRelSH3Direct8 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT8_WORD")]
        public const int ImageRelSH3Direct8Word = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT8_LONG")]
        public const int ImageRelSH3Direct8Long = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT4")]
        public const int ImageRelSH3Direct4 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT4_WORD")]
        public const int ImageRelSH3Direct4Word = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT4_LONG")]
        public const int ImageRelSH3Direct4Long = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_PCREL8_WORD")]
        public const int ImageRelSH3Pcrel8Word = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_PCREL8_LONG")]
        public const int ImageRelSH3Pcrel8Long = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_PCREL12_WORD")]
        public const int ImageRelSH3Pcrel12Word = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_STARTOF_SECTION")]
        public const int ImageRelSH3StartofSection = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_SIZEOF_SECTION")]
        public const int ImageRelSH3SizeofSection = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_SECTION")]
        public const int ImageRelSH3Section = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_SECREL")]
        public const int ImageRelSH3Secrel = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_DIRECT32_NB")]
        public const int ImageRelSH3Direct32NB = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_GPREL4_LONG")]
        public const int ImageRelSH3Gprel4Long = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH3_TOKEN")]
        public const int ImageRelSH3Token = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_PCRELPT")]
        public const int ImageRelShmPcrelpt = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_REFLO")]
        public const int ImageRelShmReflo = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_REFHALF")]
        public const int ImageRelShmRefhalf = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_RELLO")]
        public const int ImageRelShmRello = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_RELHALF")]
        public const int ImageRelShmRelhalf = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SHM_PAIR")]
        public const int ImageRelShmPair = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_SH_NOMODE")]
        public const int ImageRelSHNomode = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_ABSOLUTE")]
        public const int ImageRelArmAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_ADDR32")]
        public const int ImageRelArmAddr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_ADDR32NB")]
        public const int ImageRelArmAddr32NB = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BRANCH24")]
        public const int ImageRelArmBranch24 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BRANCH11")]
        public const int ImageRelArmBranch11 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_TOKEN")]
        public const int ImageRelArmToken = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_GPREL12")]
        public const int ImageRelArmGprel12 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_GPREL7")]
        public const int ImageRelArmGprel7 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BLX24")]
        public const int ImageRelArmBlx24 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BLX11")]
        public const int ImageRelArmBlx11 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_SECTION")]
        public const int ImageRelArmSection = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_SECREL")]
        public const int ImageRelArmSecrel = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_MOV32A")]
        public const int ImageRelArmMov32A = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_MOV32")]
        public const int ImageRelArmMov32 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_MOV32T")]
        public const int ImageRelArmMov32T = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_THUMB_MOV32")]
        public const int ImageRelThumbMov32 = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BRANCH20T")]
        public const int ImageRelArmBranch20T = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_THUMB_BRANCH20")]
        public const int ImageRelThumbBranch20 = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BRANCH24T")]
        public const int ImageRelArmBranch24T = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_THUMB_BRANCH24")]
        public const int ImageRelThumbBranch24 = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM_BLX23T")]
        public const int ImageRelArmBlx23T = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_THUMB_BLX23")]
        public const int ImageRelThumbBlx23 = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_ABSOLUTE")]
        public const int ImageRelAMAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_ADDR32")]
        public const int ImageRelAMAddr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_ADDR32NB")]
        public const int ImageRelAMAddr32NB = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_CALL32")]
        public const int ImageRelAMCall32 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_FUNCINFO")]
        public const int ImageRelAMFuncinfo = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_REL32_1")]
        public const int ImageRelAMRel321 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_REL32_2")]
        public const int ImageRelAMRel322 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_SECREL")]
        public const int ImageRelAMSecrel = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_SECTION")]
        public const int ImageRelAMSection = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AM_TOKEN")]
        public const int ImageRelAMToken = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_ABSOLUTE")]
        public const int ImageRelArm64Absolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_ADDR32")]
        public const int ImageRelArm64Addr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_ADDR32NB")]
        public const int ImageRelArm64Addr32NB = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_BRANCH26")]
        public const int ImageRelArm64Branch26 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_PAGEBASE_REL21")]
        public const int ImageRelArm64PagebaseRel21 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_REL21")]
        public const int ImageRelArm64Rel21 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_PAGEOFFSET_12A")]
        public const int ImageRelArm64Pageoffset12A = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_PAGEOFFSET_12L")]
        public const int ImageRelArm64Pageoffset12L = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_SECREL")]
        public const int ImageRelArm64Secrel = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_SECREL_LOW12A")]
        public const int ImageRelArm64SecrelLow12A = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_SECREL_HIGH12A")]
        public const int ImageRelArm64SecrelHigh12A = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_SECREL_LOW12L")]
        public const int ImageRelArm64SecrelLow12L = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_TOKEN")]
        public const int ImageRelArm64Token = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_SECTION")]
        public const int ImageRelArm64Section = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_ADDR64")]
        public const int ImageRelArm64Addr64 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_ARM64_BRANCH19")]
        public const int ImageRelArm64Branch19 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_ABSOLUTE")]
        public const int ImageRelAmd64Absolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_ADDR64")]
        public const int ImageRelAmd64Addr64 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_ADDR32")]
        public const int ImageRelAmd64Addr32 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_ADDR32NB")]
        public const int ImageRelAmd64Addr32NB = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32")]
        public const int ImageRelAmd64Rel32 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32_1")]
        public const int ImageRelAmd64Rel321 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32_2")]
        public const int ImageRelAmd64Rel322 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32_3")]
        public const int ImageRelAmd64Rel323 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32_4")]
        public const int ImageRelAmd64Rel324 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_REL32_5")]
        public const int ImageRelAmd64Rel325 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_SECTION")]
        public const int ImageRelAmd64Section = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_SECREL")]
        public const int ImageRelAmd64Secrel = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_SECREL7")]
        public const int ImageRelAmd64Secrel7 = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_TOKEN")]
        public const int ImageRelAmd64Token = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_SREL32")]
        public const int ImageRelAmd64Srel32 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_PAIR")]
        public const int ImageRelAmd64Pair = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_SSPAN32")]
        public const int ImageRelAmd64Sspan32 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_EHANDLER")]
        public const int ImageRelAmd64Ehandler = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_IMPORT_BR")]
        public const int ImageRelAmd64ImportBR = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_IMPORT_CALL")]
        public const int ImageRelAmd64ImportCall = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_CFG_BR")]
        public const int ImageRelAmd64CfgBR = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_CFG_BR_REX")]
        public const int ImageRelAmd64CfgBRRex = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_CFG_CALL")]
        public const int ImageRelAmd64CfgCall = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_INDIR_BR")]
        public const int ImageRelAmd64IndirBR = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_INDIR_BR_REX")]
        public const int ImageRelAmd64IndirBRRex = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_INDIR_CALL")]
        public const int ImageRelAmd64IndirCall = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST")]
        public const int ImageRelAmd64IndirBRSwitchtableFirst = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST")]
        public const int ImageRelAmd64IndirBRSwitchtableLast = unchecked((int) 0x2F);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_ABSOLUTE")]
        public const int ImageRelIA64Absolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_IMM14")]
        public const int ImageRelIA64Imm14 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_IMM22")]
        public const int ImageRelIA64Imm22 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_IMM64")]
        public const int ImageRelIA64Imm64 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_DIR32")]
        public const int ImageRelIA64Dir32 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_DIR64")]
        public const int ImageRelIA64Dir64 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL21B")]
        public const int ImageRelIA64Pcrel21B = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL21M")]
        public const int ImageRelIA64Pcrel21M = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL21F")]
        public const int ImageRelIA64Pcrel21f = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_GPREL22")]
        public const int ImageRelIA64Gprel22 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_LTOFF22")]
        public const int ImageRelIA64Ltoff22 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SECTION")]
        public const int ImageRelIA64Section = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SECREL22")]
        public const int ImageRelIA64Secrel22 = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SECREL64I")]
        public const int ImageRelIA64Secrel64i = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SECREL32")]
        public const int ImageRelIA64Secrel32 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_DIR32NB")]
        public const int ImageRelIA64Dir32NB = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SREL14")]
        public const int ImageRelIA64Srel14 = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SREL22")]
        public const int ImageRelIA64Srel22 = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_SREL32")]
        public const int ImageRelIA64Srel32 = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_UREL32")]
        public const int ImageRelIA64Urel32 = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL60X")]
        public const int ImageRelIA64Pcrel60X = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL60B")]
        public const int ImageRelIA64Pcrel60B = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL60F")]
        public const int ImageRelIA64Pcrel60f = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL60I")]
        public const int ImageRelIA64Pcrel60i = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_PCREL60M")]
        public const int ImageRelIA64Pcrel60M = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_IMMGPREL64")]
        public const int ImageRelIA64Immgprel64 = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_TOKEN")]
        public const int ImageRelIA64Token = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_GPREL32")]
        public const int ImageRelIA64Gprel32 = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_IA64_ADDEND")]
        public const int ImageRelIA64Addend = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_ABSOLUTE")]
        public const int ImageRelCefAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_ADDR32")]
        public const int ImageRelCefAddr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_ADDR64")]
        public const int ImageRelCefAddr64 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_ADDR32NB")]
        public const int ImageRelCefAddr32NB = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_SECTION")]
        public const int ImageRelCefSection = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_SECREL")]
        public const int ImageRelCefSecrel = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEF_TOKEN")]
        public const int ImageRelCefToken = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_ABSOLUTE")]
        public const int ImageRelCeeAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_ADDR32")]
        public const int ImageRelCeeAddr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_ADDR64")]
        public const int ImageRelCeeAddr64 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_ADDR32NB")]
        public const int ImageRelCeeAddr32NB = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_SECTION")]
        public const int ImageRelCeeSection = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_SECREL")]
        public const int ImageRelCeeSecrel = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_CEE_TOKEN")]
        public const int ImageRelCeeToken = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_ABSOLUTE")]
        public const int ImageRelM32RAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_ADDR32")]
        public const int ImageRelM32RAddr32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_ADDR32NB")]
        public const int ImageRelM32RAddr32NB = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_ADDR24")]
        public const int ImageRelM32RAddr24 = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_GPREL16")]
        public const int ImageRelM32RGprel16 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_PCREL24")]
        public const int ImageRelM32RPcrel24 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_PCREL16")]
        public const int ImageRelM32RPcrel16 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_PCREL8")]
        public const int ImageRelM32RPcrel8 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_REFHALF")]
        public const int ImageRelM32RRefhalf = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_REFHI")]
        public const int ImageRelM32RRefhi = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_REFLO")]
        public const int ImageRelM32RReflo = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_PAIR")]
        public const int ImageRelM32RPair = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_SECTION")]
        public const int ImageRelM32RSection = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_SECREL32")]
        public const int ImageRelM32RSecrel32 = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_M32R_TOKEN")]
        public const int ImageRelM32RToken = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_EBC_ABSOLUTE")]
        public const int ImageRelEbcAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_EBC_ADDR32NB")]
        public const int ImageRelEbcAddr32NB = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_EBC_REL32")]
        public const int ImageRelEbcRel32 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_EBC_SECTION")]
        public const int ImageRelEbcSection = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_EBC_SECREL")]
        public const int ImageRelEbcSecrel = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM7B_INST_WORD_X")]
        public const int EmarchEncI17Imm7BInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM7B_SIZE_X")]
        public const int EmarchEncI17Imm7BSizeX = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm7BInstWordPosX = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM7B_VAL_POS_X")]
        public const int EmarchEncI17Imm7BValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM9D_INST_WORD_X")]
        public const int EmarchEncI17Imm9DInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM9D_SIZE_X")]
        public const int EmarchEncI17Imm9DSizeX = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm9DInstWordPosX = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM9D_VAL_POS_X")]
        public const int EmarchEncI17Imm9DValPosX = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM5C_INST_WORD_X")]
        public const int EmarchEncI17Imm5CInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM5C_SIZE_X")]
        public const int EmarchEncI17Imm5CSizeX = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm5CInstWordPosX = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM5C_VAL_POS_X")]
        public const int EmarchEncI17Imm5CValPosX = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IC_INST_WORD_X")]
        public const int EmarchEncI17ICInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IC_SIZE_X")]
        public const int EmarchEncI17ICSizeX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IC_INST_WORD_POS_X")]
        public const int EmarchEncI17ICInstWordPosX = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IC_VAL_POS_X")]
        public const int EmarchEncI17ICValPosX = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41a_INST_WORD_X")]
        public const int EmarchEncI17Imm41aInstWordX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41a_SIZE_X")]
        public const int EmarchEncI17Imm41aSizeX = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm41aInstWordPosX = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41a_VAL_POS_X")]
        public const int EmarchEncI17Imm41aValPosX = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41b_INST_WORD_X")]
        public const int EmarchEncI17Imm41bInstWordX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41b_SIZE_X")]
        public const int EmarchEncI17Imm41bSizeX = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm41bInstWordPosX = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41b_VAL_POS_X")]
        public const int EmarchEncI17Imm41bValPosX = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41c_INST_WORD_X")]
        public const int EmarchEncI17Imm41cInstWordX = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41c_SIZE_X")]
        public const int EmarchEncI17Imm41cSizeX = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X")]
        public const int EmarchEncI17Imm41cInstWordPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_IMM41c_VAL_POS_X")]
        public const int EmarchEncI17Imm41cValPosX = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_SIGN_INST_WORD_X")]
        public const int EmarchEncI17SignInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_SIGN_SIZE_X")]
        public const int EmarchEncI17SignSizeX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_SIGN_INST_WORD_POS_X")]
        public const int EmarchEncI17SignInstWordPosX = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EMARCH_ENC_I17_SIGN_VAL_POS_X")]
        public const int EmarchEncI17SignValPosX = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_OPCODE_INST_WORD_X")]
        public const int X3OpcodeInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_OPCODE_SIZE_X")]
        public const int X3OpcodeSizeX = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_OPCODE_INST_WORD_POS_X")]
        public const int X3OpcodeInstWordPosX = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_OPCODE_SIGN_VAL_POS_X")]
        public const int X3OpcodeSignValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_I_INST_WORD_X")]
        public const int X3IInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_I_SIZE_X")]
        public const int X3ISizeX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_I_INST_WORD_POS_X")]
        public const int X3IInstWordPosX = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_I_SIGN_VAL_POS_X")]
        public const int X3ISignValPosX = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_D_WH_INST_WORD_X")]
        public const int X3DWHInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_D_WH_SIZE_X")]
        public const int X3DWHSizeX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_D_WH_INST_WORD_POS_X")]
        public const int X3DWHInstWordPosX = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_D_WH_SIGN_VAL_POS_X")]
        public const int X3DWHSignValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM20_INST_WORD_X")]
        public const int X3Imm20InstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM20_SIZE_X")]
        public const int X3Imm20SizeX = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM20_INST_WORD_POS_X")]
        public const int X3Imm20InstWordPosX = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM20_SIGN_VAL_POS_X")]
        public const int X3Imm20SignValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_1_INST_WORD_X")]
        public const int X3Imm391InstWordX = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_1_SIZE_X")]
        public const int X3Imm391SizeX = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_1_INST_WORD_POS_X")]
        public const int X3Imm391InstWordPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_1_SIGN_VAL_POS_X")]
        public const int X3Imm391SignValPosX = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_2_INST_WORD_X")]
        public const int X3Imm392InstWordX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_2_SIZE_X")]
        public const int X3Imm392SizeX = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_2_INST_WORD_POS_X")]
        public const int X3Imm392InstWordPosX = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_IMM39_2_SIGN_VAL_POS_X")]
        public const int X3Imm392SignValPosX = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_P_INST_WORD_X")]
        public const int X3PInstWordX = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_P_SIZE_X")]
        public const int X3PSizeX = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_P_INST_WORD_POS_X")]
        public const int X3PInstWordPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_P_SIGN_VAL_POS_X")]
        public const int X3PSignValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_TMPLT_INST_WORD_X")]
        public const int X3TmpltInstWordX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_TMPLT_SIZE_X")]
        public const int X3TmpltSizeX = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_TMPLT_INST_WORD_POS_X")]
        public const int X3TmpltInstWordPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_TMPLT_SIGN_VAL_POS_X")]
        public const int X3TmpltSignValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_BTYPE_QP_INST_WORD_X")]
        public const int X3BtypeQPInstWordX = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_BTYPE_QP_SIZE_X")]
        public const int X3BtypeQPSizeX = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_BTYPE_QP_INST_WORD_POS_X")]
        public const int X3BtypeQPInstWordPosX = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_BTYPE_QP_INST_VAL_POS_X")]
        public const int X3BtypeQPInstValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_EMPTY_INST_WORD_X")]
        public const int X3EmptyInstWordX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_EMPTY_SIZE_X")]
        public const int X3EmptySizeX = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_EMPTY_INST_WORD_POS_X")]
        public const int X3EmptyInstWordPosX = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "X3_EMPTY_INST_VAL_POS_X")]
        public const int X3EmptyInstValPosX = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_ABSOLUTE")]
        public const int ImageRelBasedAbsolute = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_HIGH")]
        public const int ImageRelBasedHigh = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_LOW")]
        public const int ImageRelBasedLow = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_HIGHLOW")]
        public const int ImageRelBasedHighlow = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_HIGHADJ")]
        public const int ImageRelBasedHighadj = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MACHINE_SPECIFIC_5")]
        public const int ImageRelBasedMachineSpecific5 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_RESERVED")]
        public const int ImageRelBasedReserved = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MACHINE_SPECIFIC_7")]
        public const int ImageRelBasedMachineSpecific7 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MACHINE_SPECIFIC_8")]
        public const int ImageRelBasedMachineSpecific8 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MACHINE_SPECIFIC_9")]
        public const int ImageRelBasedMachineSpecific9 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_DIR64")]
        public const int ImageRelBasedDir64 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_IA64_IMM64")]
        public const int ImageRelBasedIA64Imm64 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MIPS_JMPADDR")]
        public const int ImageRelBasedMipsJmpaddr = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_MIPS_JMPADDR16")]
        public const int ImageRelBasedMipsJmpaddr16 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_ARM_MOV32")]
        public const int ImageRelBasedArmMov32 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_REL_BASED_THUMB_MOV32")]
        public const int ImageRelBasedThumbMov32 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ARCHIVE_START_SIZE")]
        public const int ImageArchiveStartSize = unchecked((int) 0x8);
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_START")]
        public const string ImageArchiveStart = unchecked((string) "!<arch>\n");
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_END")]
        public const string ImageArchiveEnd = unchecked((string) "`\n");
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_PAD")]
        public const string ImageArchivePad = unchecked((string) "\n");
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_LINKER_MEMBER")]
        public const string ImageArchiveLinkerMember = unchecked((string) "/               ");
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_LONGNAMES_MEMBER")]
        public const string ImageArchiveLongnamesMember = unchecked((string) "//              ");
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_ARCHIVE_HYBRIDMAP_MEMBER")]
        public const string ImageArchiveHybridmapMember = unchecked((string) "/<HYBRIDMAP>/   ");
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR")]
        public const int ImageSizeofArchiveMemberHdr = unchecked((int) 0x3C);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "IMAGE_ORDINAL_FLAG64")]
        public const ulong ImageOrdinalFlag64 = unchecked((ulong) 0x8000000000000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_ORDINAL_FLAG32")]
        public const uint ImageOrdinalFlag32 = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_ORDINAL_FLAG")]
        public const uint ImageOrdinalFlag = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_RESOURCE_NAME_IS_STRING")]
        public const uint ImageResourceNameIsString = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_RESOURCE_DATA_IS_DIRECTORY")]
        public const uint ImageResourceDataIsDirectory = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE")]
        public const int ImageDynamicRelocationGuardRFPrologue = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE")]
        public const int ImageDynamicRelocationGuardRFEpilogue = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER")]
        public const int ImageDynamicRelocationGuardImportControlTransfer = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER")]
        public const int ImageDynamicRelocationGuardIndirControlTransfer = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH")]
        public const int ImageDynamicRelocationGuardSwitchtableBranch = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_BASE_OBLIGATORY")]
        public const int ImageHotPatchBaseObligatory = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK")]
        public const int ImageHotPatchBaseCanRollBack = unchecked((int) 0x2);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_INVERSE")]
        public const uint ImageHotPatchChunkInverse = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_OBLIGATORY")]
        public const int ImageHotPatchChunkObligatory = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_RESERVED")]
        public const int ImageHotPatchChunkReserved = unchecked((int) 0x3FF03000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_TYPE")]
        public const int ImageHotPatchChunkType = unchecked((int) 0xFC000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA")]
        public const int ImageHotPatchChunkSourceRva = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_TARGET_RVA")]
        public const int ImageHotPatchChunkTargetRva = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CHUNK_SIZE")]
        public const int ImageHotPatchChunkSize = unchecked((int) 0xFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_NONE")]
        public const int ImageHotPatchNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_FUNCTION")]
        public const int ImageHotPatchFunction = unchecked((int) 0x1C000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_ABSOLUTE")]
        public const int ImageHotPatchAbsolute = unchecked((int) 0x2C000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_REL32")]
        public const int ImageHotPatchRel32 = unchecked((int) 0x3C000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_CALL_TARGET")]
        public const int ImageHotPatchCallTarget = unchecked((int) 0x44000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_INDIRECT")]
        public const int ImageHotPatchIndirect = unchecked((int) 0x5C000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_NO_CALL_TARGET")]
        public const int ImageHotPatchNoCallTarget = unchecked((int) 0x64000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_HOT_PATCH_DYNAMIC_VALUE")]
        public const int ImageHotPatchDynamicValue = unchecked((int) 0x78000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_INSTRUMENTED")]
        public const int ImageGuardCFInstrumented = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CFW_INSTRUMENTED")]
        public const int ImageGuardCfwInstrumented = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT")]
        public const int ImageGuardCFFunctionTablePresent = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_SECURITY_COOKIE_UNUSED")]
        public const int ImageGuardSecurityCookieUnused = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_PROTECT_DELAYLOAD_IAT")]
        public const int ImageGuardProtectDelayloadIat = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION")]
        public const int ImageGuardDelayloadIatInItsOwnSection = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT")]
        public const int ImageGuardCFExportSuppressionInfoPresent = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION")]
        public const int ImageGuardCFEnableExportSuppression = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT")]
        public const int ImageGuardCFLongjumpTablePresent = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_RF_INSTRUMENTED")]
        public const int ImageGuardRFInstrumented = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_RF_ENABLE")]
        public const int ImageGuardRFEnable = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_RF_STRICT")]
        public const int ImageGuardRFStrict = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_RETPOLINE_PRESENT")]
        public const int ImageGuardRetpolinePresent = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_EH_CONTINUATION_TABLE_PRESENT")]
        public const int ImageGuardEHContinuationTablePresent = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_XFG_ENABLED")]
        public const int ImageGuardXfgEnabled = unchecked((int) 0x800000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK")]
        public const uint ImageGuardCFFunctionTableSizeMask = unchecked((uint) 0xFFFFFFFFF0000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT")]
        public const int ImageGuardCFFunctionTableSizeShift = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_FLAG_FID_SUPPRESSED")]
        public const int ImageGuardFlagFidSuppressed = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED")]
        public const int ImageGuardFlagExportSuppressed = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_FLAG_FID_LANGEXCPTHANDLER")]
        public const int ImageGuardFlagFidLangexcpthandler = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_GUARD_FLAG_FID_XFG")]
        public const int ImageGuardFlagFidXfg = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_LONG_ID_LENGTH")]
        public const int ImageEnclaveLongIDLength = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_SHORT_ID_LENGTH")]
        public const int ImageEnclaveShortIDLength = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_POLICY_DEBUGGABLE")]
        public const int ImageEnclavePolicyDebuggable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE")]
        public const int ImageEnclaveFlagPrimaryImage = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_IMPORT_MATCH_NONE")]
        public const int ImageEnclaveImportMatchNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID")]
        public const int ImageEnclaveImportMatchUniqueID = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID")]
        public const int ImageEnclaveImportMatchAuthorID = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID")]
        public const int ImageEnclaveImportMatchFamilyID = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID")]
        public const int ImageEnclaveImportMatchImageID = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_UNKNOWN")]
        public const int ImageDebugTypeUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_COFF")]
        public const int ImageDebugTypeCoff = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_CODEVIEW")]
        public const int ImageDebugTypeCodeview = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_FPO")]
        public const int ImageDebugTypeFpo = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_MISC")]
        public const int ImageDebugTypeMisc = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_EXCEPTION")]
        public const int ImageDebugTypeException = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_FIXUP")]
        public const int ImageDebugTypeFixup = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_OMAP_TO_SRC")]
        public const int ImageDebugTypeOmapToSrc = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_OMAP_FROM_SRC")]
        public const int ImageDebugTypeOmapFromSrc = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_BORLAND")]
        public const int ImageDebugTypeBorland = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_RESERVED10")]
        public const int ImageDebugTypeReserved10 = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_CLSID")]
        public const int ImageDebugTypeClsid = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_VC_FEATURE")]
        public const int ImageDebugTypeVCFeature = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_POGO")]
        public const int ImageDebugTypePogo = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_ILTCG")]
        public const int ImageDebugTypeIltcg = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_MPX")]
        public const int ImageDebugTypeMpx = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_REPRO")]
        public const int ImageDebugTypeRepro = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_TYPE_EX_DLLCHARACTERISTICS")]
        public const int ImageDebugTypeEXDllcharacteristics = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT")]
        public const int ImageDllcharacteristicsEXCetCompat = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT_STRICT_MODE")]
        public const int ImageDllcharacteristicsEXCetCompatStrictMode = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE")]
        public const int ImageDllcharacteristicsEXCetSetContextIPValidationRelaxedMode = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_DYNAMIC_APIS_ALLOW_IN_PROC")]
        public const int ImageDllcharacteristicsEXCetDynamicApisAllowInProc = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_1")]
        public const int ImageDllcharacteristicsEXCetReserved1 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_2")]
        public const int ImageDllcharacteristicsEXCetReserved2 = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FRAME_FPO")]
        public const int FrameFpo = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FRAME_TRAP")]
        public const int FrameTrap = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FRAME_TSS")]
        public const int FrameTss = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FRAME_NONFPO")]
        public const int FrameNonfpo = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SIZEOF_RFPO_DATA")]
        public const int SizeofRfpoData = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_DEBUG_MISC_EXENAME")]
        public const int ImageDebugMiscExename = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SEPARATE_DEBUG_SIGNATURE")]
        public const int ImageSeparateDebugSignature = unchecked((int) 0x4944);
        [NativeName("Type", "int")]
        [NativeName("Name", "NON_PAGED_DEBUG_SIGNATURE")]
        public const int NonPagedDebugSignature = unchecked((int) 0x494E);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SEPARATE_DEBUG_FLAGS_MASK")]
        public const int ImageSeparateDebugFlagsMask = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_SEPARATE_DEBUG_MISMATCH")]
        public const int ImageSeparateDebugMismatch = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMPORT_OBJECT_HDR_SIG2")]
        public const int ImportObjectHdrSig2 = unchecked((int) 0xFFFF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "RTL_RUN_ONCE_CHECK_ONLY")]
        public const uint RtlRunOnceCheckOnly = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "RTL_RUN_ONCE_ASYNC")]
        public const uint RtlRunOnceAsync = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "RTL_RUN_ONCE_INIT_FAILED")]
        public const uint RtlRunOnceInitFailed = unchecked((uint) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_RUN_ONCE_CTX_RESERVED_BITS")]
        public const int RtlRunOnceCtxReservedBits = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_LEGACY_GS_VIOLATION")]
        public const int FastFailLegacyGSViolation = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_VTGUARD_CHECK_FAILURE")]
        public const int FastFailVtguardCheckFailure = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_STACK_COOKIE_CHECK_FAILURE")]
        public const int FastFailStackCookieCheckFailure = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_CORRUPT_LIST_ENTRY")]
        public const int FastFailCorruptListEntry = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INCORRECT_STACK")]
        public const int FastFailIncorrectStack = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_ARG")]
        public const int FastFailInvalidArg = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GS_COOKIE_INIT")]
        public const int FastFailGSCookieInit = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_FATAL_APP_EXIT")]
        public const int FastFailFatalAppExit = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_RANGE_CHECK_FAILURE")]
        public const int FastFailRangeCheckFailure = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNSAFE_REGISTRY_ACCESS")]
        public const int FastFailUnsafeRegistryAccess = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_ICALL_CHECK_FAILURE")]
        public const int FastFailGuardIcallCheckFailure = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_WRITE_CHECK_FAILURE")]
        public const int FastFailGuardWriteCheckFailure = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_FIBER_SWITCH")]
        public const int FastFailInvalidFiberSwitch = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_SET_OF_CONTEXT")]
        public const int FastFailInvalidSetOfContext = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_REFERENCE_COUNT")]
        public const int FastFailInvalidReferenceCount = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_JUMP_BUFFER")]
        public const int FastFailInvalidJumpBuffer = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_MRDATA_MODIFIED")]
        public const int FastFailMrdataModified = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_CERTIFICATION_FAILURE")]
        public const int FastFailCertificationFailure = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_EXCEPTION_CHAIN")]
        public const int FastFailInvalidExceptionChain = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_CRYPTO_LIBRARY")]
        public const int FastFailCryptoLibrary = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT")]
        public const int FastFailInvalidCallInDllCallout = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_IMAGE_BASE")]
        public const int FastFailInvalidImageBase = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_DLOAD_PROTECTION_FAILURE")]
        public const int FastFailDloadProtectionFailure = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNSAFE_EXTENSION_CALL")]
        public const int FastFailUnsafeExtensionCall = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_DEPRECATED_SERVICE_INVOKED")]
        public const int FastFailDeprecatedServiceInvoked = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_BUFFER_ACCESS")]
        public const int FastFailInvalidBufferAccess = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_BALANCED_TREE")]
        public const int FastFailInvalidBalancedTree = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_NEXT_THREAD")]
        public const int FastFailInvalidNextThread = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED")]
        public const int FastFailGuardIcallCheckSuppressed = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_APCS_DISABLED")]
        public const int FastFailApcsDisabled = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_IDLE_STATE")]
        public const int FastFailInvalidIdleState = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_MRDATA_PROTECTION_FAILURE")]
        public const int FastFailMrdataProtectionFailure = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION")]
        public const int FastFailUnexpectedHeapException = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_LOCK_STATE")]
        public const int FastFailInvalidLockState = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_JUMPTABLE")]
        public const int FastFailGuardJumptable = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_LONGJUMP_TARGET")]
        public const int FastFailInvalidLongjumpTarget = unchecked((int) 0x26);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_DISPATCH_CONTEXT")]
        public const int FastFailInvalidDispatchContext = unchecked((int) 0x27);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_THREAD")]
        public const int FastFailInvalidThread = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_SYSCALL_NUMBER")]
        public const int FastFailInvalidSyscallNumber = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_FILE_OPERATION")]
        public const int FastFailInvalidFileOperation = unchecked((int) 0x2A);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_LPAC_ACCESS_DENIED")]
        public const int FastFailLpacAccessDenied = unchecked((int) 0x2B);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_SS_FAILURE")]
        public const int FastFailGuardSSFailure = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_LOADER_CONTINUITY_FAILURE")]
        public const int FastFailLoaderContinuityFailure = unchecked((int) 0x2D);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE")]
        public const int FastFailGuardExportSuppressionFailure = unchecked((int) 0x2E);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_CONTROL_STACK")]
        public const int FastFailInvalidControlStack = unchecked((int) 0x2F);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_SET_CONTEXT_DENIED")]
        public const int FastFailSetContextDenied = unchecked((int) 0x30);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_IAT")]
        public const int FastFailInvalidIat = unchecked((int) 0x31);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_HEAP_METADATA_CORRUPTION")]
        public const int FastFailHeapMetadataCorruption = unchecked((int) 0x32);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION")]
        public const int FastFailPayloadRestrictionViolation = unchecked((int) 0x33);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_LOW_LABEL_ACCESS_DENIED")]
        public const int FastFailLowLabelAccessDenied = unchecked((int) 0x34);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_ENCLAVE_CALL_FAILURE")]
        public const int FastFailEnclaveCallFailure = unchecked((int) 0x35);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNHANDLED_LSS_EXCEPTON")]
        public const int FastFailUnhandledLssExcepton = unchecked((int) 0x36);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_ADMINLESS_ACCESS_DENIED")]
        public const int FastFailAdminlessAccessDenied = unchecked((int) 0x37);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNEXPECTED_CALL")]
        public const int FastFailUnexpectedCall = unchecked((int) 0x38);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS")]
        public const int FastFailControlInvalidReturnAddress = unchecked((int) 0x39);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR")]
        public const int FastFailUnexpectedHostBehavior = unchecked((int) 0x3A);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_FLAGS_CORRUPTION")]
        public const int FastFailFlagsCorruption = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_VEH_CORRUPTION")]
        public const int FastFailVehCorruption = unchecked((int) 0x3C);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_ETW_CORRUPTION")]
        public const int FastFailEtwCorruption = unchecked((int) 0x3D);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_RIO_ABORT")]
        public const int FastFailRioAbort = unchecked((int) 0x3E);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_PFN")]
        public const int FastFailInvalidPfn = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG")]
        public const int FastFailGuardIcallCheckFailureXfg = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_CAST_GUARD")]
        public const int FastFailCastGuard = unchecked((int) 0x41);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_HOST_VISIBILITY_CHANGE")]
        public const int FastFailHostVisibilityChange = unchecked((int) 0x42);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST")]
        public const int FastFailKernelCetShadowStackAssist = unchecked((int) 0x43);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_PATCH_CALLBACK_FAILED")]
        public const int FastFailPatchCallbackFailed = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_NTDLL_PATCH_FAILED")]
        public const int FastFailNtdllPatchFailed = unchecked((int) 0x45);
        [NativeName("Type", "int")]
        [NativeName("Name", "FAST_FAIL_INVALID_FLS_DATA")]
        public const int FastFailInvalidFlsData = unchecked((int) 0x46);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "FAST_FAIL_INVALID_FAST_FAIL_CODE")]
        public const uint FastFailInvalidFastFailCode = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_NO_SERIALIZE")]
        public const int HeapNoSerialize = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_GROWABLE")]
        public const int HeapGrowable = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_GENERATE_EXCEPTIONS")]
        public const int HeapGenerateExceptions = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_ZERO_MEMORY")]
        public const int HeapZeroMemory = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_REALLOC_IN_PLACE_ONLY")]
        public const int HeapReallocInPlaceOnly = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_TAIL_CHECKING_ENABLED")]
        public const int HeapTailCheckingEnabled = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_FREE_CHECKING_ENABLED")]
        public const int HeapFreeCheckingEnabled = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_DISABLE_COALESCE_ON_FREE")]
        public const int HeapDisableCoalesceOnFree = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_CREATE_ALIGN_16")]
        public const int HeapCreateAlign16 = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_CREATE_ENABLE_TRACING")]
        public const int HeapCreateEnableTracing = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_CREATE_ENABLE_EXECUTE")]
        public const int HeapCreateEnableExecute = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_MAXIMUM_TAG")]
        public const int HeapMaximumTag = unchecked((int) 0xFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_PSEUDO_TAG_FLAG")]
        public const int HeapPseudoTagFlag = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_TAG_SHIFT")]
        public const int HeapTagShift = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_CREATE_SEGMENT_HEAP")]
        public const int HeapCreateSegmentHeap = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_CREATE_HARDENED")]
        public const int HeapCreateHardened = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_ASCII16")]
        public const int IsTextUnicodeAscii16 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_REVERSE_ASCII16")]
        public const int IsTextUnicodeReverseAscii16 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_STATISTICS")]
        public const int IsTextUnicodeStatistics = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_REVERSE_STATISTICS")]
        public const int IsTextUnicodeReverseStatistics = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_CONTROLS")]
        public const int IsTextUnicodeControls = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_REVERSE_CONTROLS")]
        public const int IsTextUnicodeReverseControls = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_SIGNATURE")]
        public const int IsTextUnicodeSignature = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_REVERSE_SIGNATURE")]
        public const int IsTextUnicodeReverseSignature = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_ILLEGAL_CHARS")]
        public const int IsTextUnicodeIllegalChars = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_ODD_LENGTH")]
        public const int IsTextUnicodeOddLength = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_DBCS_LEADBYTE")]
        public const int IsTextUnicodeDbcsLeadbyte = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_UTF8")]
        public const int IsTextUnicodeUtf8 = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_NULL_BYTES")]
        public const int IsTextUnicodeNullBytes = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_UNICODE_MASK")]
        public const int IsTextUnicodeUnicodeMask = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_REVERSE_MASK")]
        public const int IsTextUnicodeReverseMask = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_NOT_UNICODE_MASK")]
        public const int IsTextUnicodeNotUnicodeMask = unchecked((int) 0xF00);
        [NativeName("Type", "int")]
        [NativeName("Name", "IS_TEXT_UNICODE_NOT_ASCII_MASK")]
        public const int IsTextUnicodeNotAsciiMask = unchecked((int) 0xF000);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_NONE")]
        public const int CompressionFormatNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_DEFAULT")]
        public const int CompressionFormatDefault = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_LZNT1")]
        public const int CompressionFormatLznt1 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_XPRESS")]
        public const int CompressionFormatXpress = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_XPRESS_HUFF")]
        public const int CompressionFormatXpressHuff = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_FORMAT_XP10")]
        public const int CompressionFormatXP10 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_ENGINE_STANDARD")]
        public const int CompressionEngineStandard = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_ENGINE_MAXIMUM")]
        public const int CompressionEngineMaximum = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPRESSION_ENGINE_HIBER")]
        public const int CompressionEngineHiber = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_DACL_AUTO_INHERIT")]
        public const int SefDaclAutoInherit = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_SACL_AUTO_INHERIT")]
        public const int SefSaclAutoInherit = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT")]
        public const int SefDefaultDescriptorForObject = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_AVOID_PRIVILEGE_CHECK")]
        public const int SefAvoidPrivilegeCheck = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_AVOID_OWNER_CHECK")]
        public const int SefAvoidOwnerCheck = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_DEFAULT_OWNER_FROM_PARENT")]
        public const int SefDefaultOwnerFromParent = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_DEFAULT_GROUP_FROM_PARENT")]
        public const int SefDefaultGroupFromParent = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_MACL_NO_WRITE_UP")]
        public const int SefMaclNoWriteUp = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_MACL_NO_READ_UP")]
        public const int SefMaclNoReadUp = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_MACL_NO_EXECUTE_UP")]
        public const int SefMaclNoExecuteUp = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_AI_USE_EXTRA_PARAMS")]
        public const int SefAIUseExtraParams = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_AVOID_OWNER_RESTRICTION")]
        public const int SefAvoidOwnerRestriction = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SEF_FORCE_USER_MODE")]
        public const int SefForceUserMode = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "MESSAGE_RESOURCE_UNICODE")]
        public const int MessageResourceUnicode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "MESSAGE_RESOURCE_UTF8")]
        public const int MessageResourceUtf8 = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_EQUAL")]
        public const int VerEqual = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_GREATER")]
        public const int VerGreater = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_GREATER_EQUAL")]
        public const int VerGreaterEqual = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_LESS")]
        public const int VerLess = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_LESS_EQUAL")]
        public const int VerLessEqual = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_AND")]
        public const int VerAnd = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_OR")]
        public const int VerOr = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_CONDITION_MASK")]
        public const int VerConditionMask = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_NUM_BITS_PER_CONDITION_MASK")]
        public const int VerNumBitsPerConditionMask = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_MINORVERSION")]
        public const int VerMinorversion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_MAJORVERSION")]
        public const int VerMajorversion = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_BUILDNUMBER")]
        public const int VerBuildnumber = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_PLATFORMID")]
        public const int VerPlatformid = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SERVICEPACKMINOR")]
        public const int VerServicepackminor = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SERVICEPACKMAJOR")]
        public const int VerServicepackmajor = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_SUITENAME")]
        public const int VerSuitename = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_PRODUCT_TYPE")]
        public const int VerProductType = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_NT_WORKSTATION")]
        public const int VerNTWorkstation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_NT_DOMAIN_CONTROLLER")]
        public const int VerNTDomainController = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_NT_SERVER")]
        public const int VerNTServer = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_PLATFORM_WIN32s")]
        public const int VerPlatformWin32s = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_PLATFORM_WIN32_WINDOWS")]
        public const int VerPlatformWin32Windows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VER_PLATFORM_WIN32_NT")]
        public const int VerPlatformWin32NT = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_UMS_VERSION")]
        public const int RtlUmsVersion = unchecked((int) 0x100);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "CTMF_INCLUDE_APPCONTAINER")]
        public const uint CtmfIncludeAppcontainer = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "CTMF_INCLUDE_LPAC")]
        public const uint CtmfIncludeLpac = unchecked((uint) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN")]
        public const int FlushNVMemoryInFlagNoDrain = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "WRITE_NV_MEMORY_FLAG_FLUSH")]
        public const int WriteNVMemoryFlagFlush = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "WRITE_NV_MEMORY_FLAG_NON_TEMPORAL")]
        public const int WriteNVMemoryFlagNonTemporal = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "WRITE_NV_MEMORY_FLAG_NO_DRAIN")]
        public const int WriteNVMemoryFlagNoDrain = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILL_NV_MEMORY_FLAG_FLUSH")]
        public const int FillNVMemoryFlagFlush = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILL_NV_MEMORY_FLAG_NON_TEMPORAL")]
        public const int FillNVMemoryFlagNonTemporal = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FILL_NV_MEMORY_FLAG_NO_DRAIN")]
        public const int FillNVMemoryFlagNoDrain = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CORRELATION_VECTOR_STRING_LENGTH")]
        public const int RtlCorrelationVectorStringLength = unchecked((int) 0x81);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH")]
        public const int RtlCorrelationVectorV1PrefixLength = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CORRELATION_VECTOR_V1_LENGTH")]
        public const int RtlCorrelationVectorV1Length = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH")]
        public const int RtlCorrelationVectorV2PrefixLength = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CORRELATION_VECTOR_V2_LENGTH")]
        public const int RtlCorrelationVectorV2Length = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "IMAGE_POLICY_METADATA_VERSION")]
        public const int ImagePolicyMetadataVersion = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "IMAGE_POLICY_SECTION_NAME")]
        public const string ImagePolicySectionName = unchecked((string) ".tPolicy");
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "RTL_VIRTUAL_UNWIND2_VALIDATE_PAC")]
        public const uint RtlVirtualUnwind2ValidatePac = unchecked((uint) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO")]
        public const int RtlCriticalSectionFlagNoDebugInfo = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN")]
        public const int RtlCriticalSectionFlagDynamicSpin = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_FLAG_STATIC_INIT")]
        public const int RtlCriticalSectionFlagStaticInit = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE")]
        public const int RtlCriticalSectionFlagResourceType = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO")]
        public const int RtlCriticalSectionFlagForceDebugInfo = unchecked((int) 0x10000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_ALL_FLAG_BITS")]
        public const uint RtlCriticalSectionAllFlagBits = unchecked((uint) 0xFFFFFFFFFF000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT")]
        public const int RtlCriticalSectionDebugFlagStaticInit = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "RTL_CONDITION_VARIABLE_LOCKMODE_SHARED")]
        public const int RtlConditionVariableLockmodeShared = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION")]
        public const int HeapOptimizeResourcesCurrentVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEDEFAULT")]
        public const int WTExecutedefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINIOTHREAD")]
        public const int WTExecuteiniothread = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINUITHREAD")]
        public const int WTExecuteinuithread = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINWAITTHREAD")]
        public const int WTExecuteinwaitthread = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEONLYONCE")]
        public const int WTExecuteonlyonce = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINTIMERTHREAD")]
        public const int WTExecuteintimerthread = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTELONGFUNCTION")]
        public const int WTExecutelongfunction = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINPERSISTENTIOTHREAD")]
        public const int WTExecuteinpersistentiothread = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINPERSISTENTTHREAD")]
        public const int WTExecuteinpersistentthread = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_TRANSFER_IMPERSONATION")]
        public const int WTTransferImpersonation = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEINLONGTHREAD")]
        public const int WTExecuteinlongthread = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "WT_EXECUTEDELETEWAIT")]
        public const int WTExecutedeletewait = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_PATH_TYPE_NONE")]
        public const int ActivationContextPathTypeNone = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE")]
        public const int ActivationContextPathTypeWin32File = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_PATH_TYPE_URL")]
        public const int ActivationContextPathTypeUrl = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF")]
        public const int ActivationContextPathTypeAssemblyref = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID")]
        public const int CreateBoundaryDescriptorAddAppcontainerSid = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PERFORMANCE_DATA_VERSION")]
        public const int PerformanceDataVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "READ_THREAD_PROFILING_FLAG_DISPATCHING")]
        public const int ReadThreadProfilingFlagDispatching = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS")]
        public const int ReadThreadProfilingFlagHardwareCounters = unchecked((int) 0x2);
        [NativeName("Type", "")]
        [NativeName("Name", "UNIFIEDBUILDREVISION_KEY")]
        public const string UnifiedbuildrevisionKey = unchecked((string) "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion");
        [NativeName("Type", "")]
        [NativeName("Name", "UNIFIEDBUILDREVISION_VALUE")]
        public const string UnifiedbuildrevisionValue = unchecked((string) "UBR");
        [NativeName("Type", "int")]
        [NativeName("Name", "UNIFIEDBUILDREVISION_MIN")]
        public const int UnifiedbuildrevisionMin = unchecked((int) 0x0);
        [NativeName("Type", "")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_KEY")]
        public const string DevicefamilydeviceformKey = unchecked((string) "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion\\OEM");
        [NativeName("Type", "")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_VALUE")]
        public const string DevicefamilydeviceformValue = unchecked((string) "DeviceForm");
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_UAP")]
        public const int DevicefamilyinfoenumUap = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_WINDOWS_8X")]
        public const int DevicefamilyinfoenumWindows8X = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X")]
        public const int DevicefamilyinfoenumWindowsPhone8X = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_DESKTOP")]
        public const int DevicefamilyinfoenumDesktop = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_MOBILE")]
        public const int DevicefamilyinfoenumMobile = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_XBOX")]
        public const int DevicefamilyinfoenumXbox = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_TEAM")]
        public const int DevicefamilyinfoenumTeam = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_IOT")]
        public const int DevicefamilyinfoenumIot = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_IOT_HEADLESS")]
        public const int DevicefamilyinfoenumIotHeadless = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_SERVER")]
        public const int DevicefamilyinfoenumServer = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_HOLOGRAPHIC")]
        public const int DevicefamilyinfoenumHolographic = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_XBOXSRA")]
        public const int DevicefamilyinfoenumXboxsra = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_XBOXERA")]
        public const int DevicefamilyinfoenumXboxera = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_SERVER_NANO")]
        public const int DevicefamilyinfoenumServerNano = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_8828080")]
        public const int Devicefamilyinfoenum8828080 = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_7067329")]
        public const int Devicefamilyinfoenum7067329 = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_WINDOWS_CORE")]
        public const int DevicefamilyinfoenumWindowsCore = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS")]
        public const int DevicefamilyinfoenumWindowsCoreHeadless = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYINFOENUM_MAX")]
        public const int DevicefamilyinfoenumMax = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_UNKNOWN")]
        public const int DevicefamilydeviceformUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_PHONE")]
        public const int DevicefamilydeviceformPhone = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_TABLET")]
        public const int DevicefamilydeviceformTablet = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_DESKTOP")]
        public const int DevicefamilydeviceformDesktop = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_NOTEBOOK")]
        public const int DevicefamilydeviceformNotebook = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_CONVERTIBLE")]
        public const int DevicefamilydeviceformConvertible = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_DETACHABLE")]
        public const int DevicefamilydeviceformDetachable = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_ALLINONE")]
        public const int DevicefamilydeviceformAllinone = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_STICKPC")]
        public const int DevicefamilydeviceformStickpc = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_PUCK")]
        public const int DevicefamilydeviceformPuck = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_LARGESCREEN")]
        public const int DevicefamilydeviceformLargescreen = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_HMD")]
        public const int DevicefamilydeviceformHmd = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD")]
        public const int DevicefamilydeviceformIndustryHandheld = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET")]
        public const int DevicefamilydeviceformIndustryTablet = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_BANKING")]
        public const int DevicefamilydeviceformBanking = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION")]
        public const int DevicefamilydeviceformBuildingAutomation = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE")]
        public const int DevicefamilydeviceformDigitalSignage = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_GAMING")]
        public const int DevicefamilydeviceformGaming = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION")]
        public const int DevicefamilydeviceformHomeAutomation = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION")]
        public const int DevicefamilydeviceformIndustrialAutomation = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_KIOSK")]
        public const int DevicefamilydeviceformKiosk = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_MAKER_BOARD")]
        public const int DevicefamilydeviceformMakerBoard = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_MEDICAL")]
        public const int DevicefamilydeviceformMedical = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_NETWORKING")]
        public const int DevicefamilydeviceformNetworking = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE")]
        public const int DevicefamilydeviceformPointOfService = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_PRINTING")]
        public const int DevicefamilydeviceformPrinting = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_THIN_CLIENT")]
        public const int DevicefamilydeviceformThinClient = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_TOY")]
        public const int DevicefamilydeviceformToy = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_VENDING")]
        public const int DevicefamilydeviceformVending = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER")]
        public const int DevicefamilydeviceformIndustryOther = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_ONE")]
        public const int DevicefamilydeviceformXboxOne = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_ONE_S")]
        public const int DevicefamilydeviceformXboxOneS = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_ONE_X")]
        public const int DevicefamilydeviceformXboxOneX = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT")]
        public const int DevicefamilydeviceformXboxOneXDevkit = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X")]
        public const int DevicefamilydeviceformXboxSeriesX = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X_DEVKIT")]
        public const int DevicefamilydeviceformXboxSeriesXDevkit = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_00")]
        public const int DevicefamilydeviceformXboxReserved00 = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_01")]
        public const int DevicefamilydeviceformXboxReserved01 = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_02")]
        public const int DevicefamilydeviceformXboxReserved02 = unchecked((int) 0x26);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_03")]
        public const int DevicefamilydeviceformXboxReserved03 = unchecked((int) 0x27);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_04")]
        public const int DevicefamilydeviceformXboxReserved04 = unchecked((int) 0x28);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_05")]
        public const int DevicefamilydeviceformXboxReserved05 = unchecked((int) 0x29);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_06")]
        public const int DevicefamilydeviceformXboxReserved06 = unchecked((int) 0x2A);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_07")]
        public const int DevicefamilydeviceformXboxReserved07 = unchecked((int) 0x2B);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_08")]
        public const int DevicefamilydeviceformXboxReserved08 = unchecked((int) 0x2C);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_09")]
        public const int DevicefamilydeviceformXboxReserved09 = unchecked((int) 0x2D);
        [NativeName("Type", "int")]
        [NativeName("Name", "DEVICEFAMILYDEVICEFORM_MAX")]
        public const int DevicefamilydeviceformMax = unchecked((int) 0x2D);
        [NativeName("Type", "int")]
        [NativeName("Name", "DLL_PROCESS_ATTACH")]
        public const int DllProcessAttach = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "DLL_THREAD_ATTACH")]
        public const int DllThreadAttach = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DLL_THREAD_DETACH")]
        public const int DllThreadDetach = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "DLL_PROCESS_DETACH")]
        public const int DllProcessDetach = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_SEQUENTIAL_READ")]
        public const int EventlogSequentialRead = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_SEEK_READ")]
        public const int EventlogSeekRead = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_FORWARDS_READ")]
        public const int EventlogForwardsRead = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_BACKWARDS_READ")]
        public const int EventlogBackwardsRead = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_SUCCESS")]
        public const int EventlogSuccess = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_ERROR_TYPE")]
        public const int EventlogErrorType = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_WARNING_TYPE")]
        public const int EventlogWarningType = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_INFORMATION_TYPE")]
        public const int EventlogInformationType = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_AUDIT_SUCCESS")]
        public const int EventlogAuditSuccess = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_AUDIT_FAILURE")]
        public const int EventlogAuditFailure = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_START_PAIRED_EVENT")]
        public const int EventlogStartPairedEvent = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_END_PAIRED_EVENT")]
        public const int EventlogEndPairedEvent = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_END_ALL_PAIRED_EVENTS")]
        public const int EventlogEndAllPairedEvents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_PAIRED_EVENT_ACTIVE")]
        public const int EventlogPairedEventActive = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENTLOG_PAIRED_EVENT_INACTIVE")]
        public const int EventlogPairedEventInactive = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "MAXLOGICALLOGNAMESIZE")]
        public const int Maxlogicallognamesize = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_QUERY_VALUE")]
        public const int KeyQueryValue = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_SET_VALUE")]
        public const int KeySetValue = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_CREATE_SUB_KEY")]
        public const int KeyCreateSubKey = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_ENUMERATE_SUB_KEYS")]
        public const int KeyEnumerateSubKeys = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_NOTIFY")]
        public const int KeyNotify = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_CREATE_LINK")]
        public const int KeyCreateLink = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_WOW64_32KEY")]
        public const int KeyWow6432Key = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_WOW64_64KEY")]
        public const int KeyWow6464Key = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "KEY_WOW64_RES")]
        public const int KeyWow64Res = unchecked((int) 0x300);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_RESERVED")]
        public const int RegOptionReserved = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_NON_VOLATILE")]
        public const int RegOptionNonVolatile = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_VOLATILE")]
        public const int RegOptionVolatile = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_CREATE_LINK")]
        public const int RegOptionCreateLink = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_BACKUP_RESTORE")]
        public const int RegOptionBackupRestore = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_OPEN_LINK")]
        public const int RegOptionOpenLink = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPTION_DONT_VIRTUALIZE")]
        public const int RegOptionDontVirtualize = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_CREATED_NEW_KEY")]
        public const int RegCreatedNewKey = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPENED_EXISTING_KEY")]
        public const int RegOpenedExistingKey = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "REG_STANDARD_FORMAT")]
        public const int RegStandardFormat = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "REG_LATEST_FORMAT")]
        public const int RegLatestFormat = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "REG_NO_COMPRESSION")]
        public const int RegNoCompression = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_WHOLE_HIVE_VOLATILE")]
        public const int RegWholeHiveVolatile = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_REFRESH_HIVE")]
        public const int RegRefreshHive = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NO_LAZY_FLUSH")]
        public const int RegNoLazyFlush = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_FORCE_RESTORE")]
        public const int RegForceRestore = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_APP_HIVE")]
        public const int RegAppHive = unchecked((int) 0x10);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_PROCESS_PRIVATE")]
        public const int RegProcessPrivate = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_START_JOURNAL")]
        public const int RegStartJournal = unchecked((int) 0x40);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_HIVE_EXACT_FILE_GROWTH")]
        public const int RegHiveExactFileGrowth = unchecked((int) 0x80);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_HIVE_NO_RM")]
        public const int RegHiveNoRM = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_HIVE_SINGLE_LOG")]
        public const int RegHiveSingleLog = unchecked((int) 0x200);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_BOOT_HIVE")]
        public const int RegBootHive = unchecked((int) 0x400);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_LOAD_HIVE_OPEN_HANDLE")]
        public const int RegLoadHiveOpenHandle = unchecked((int) 0x800);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_FLUSH_HIVE_FILE_GROWTH")]
        public const int RegFlushHiveFileGrowth = unchecked((int) 0x1000);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_OPEN_READ_ONLY")]
        public const int RegOpenReadOnly = unchecked((int) 0x2000);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_IMMUTABLE")]
        public const int RegImmutable = unchecked((int) 0x4000);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NO_IMPERSONATION_FALLBACK")]
        public const int RegNoImpersonationFallback = unchecked((int) 0x8000);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_APP_HIVE_OPEN_READ_ONLY")]
        public const int RegAppHiveOpenReadOnly = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "REG_FORCE_UNLOAD")]
        public const int RegForceUnload = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "REG_UNLOAD_LEGAL_FLAGS")]
        public const int RegUnloadLegalFlags = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NOTIFY_CHANGE_NAME")]
        public const int RegNotifyChangeName = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NOTIFY_CHANGE_ATTRIBUTES")]
        public const int RegNotifyChangeAttributes = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NOTIFY_CHANGE_LAST_SET")]
        public const int RegNotifyChangeLastSet = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NOTIFY_CHANGE_SECURITY")]
        public const int RegNotifyChangeSecurity = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "REG_NOTIFY_THREAD_AGNOSTIC")]
        public const int RegNotifyThreadAgnostic = unchecked((int) 0x10000000);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_NONE")]
        public const uint RegNone = unchecked((uint) 0x0);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_SZ")]
        public const uint RegSZ = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_EXPAND_SZ")]
        public const uint RegExpandSZ = unchecked((uint) 0x2);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_BINARY")]
        public const uint RegBinary = unchecked((uint) 0x3);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_DWORD")]
        public const uint RegDword = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_DWORD_LITTLE_ENDIAN")]
        public const uint RegDwordLittleEndian = unchecked((uint) 0x4);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_DWORD_BIG_ENDIAN")]
        public const uint RegDwordBigEndian = unchecked((uint) 0x5);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_LINK")]
        public const uint RegLink = unchecked((uint) 0x6);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_MULTI_SZ")]
        public const uint RegMultiSZ = unchecked((uint) 0x7);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_RESOURCE_LIST")]
        public const uint RegResourceList = unchecked((uint) 0x8);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_FULL_RESOURCE_DESCRIPTOR")]
        public const uint RegFullResourceDescriptor = unchecked((uint) 0x9);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_RESOURCE_REQUIREMENTS_LIST")]
        public const uint RegResourceRequirementsList = unchecked((uint) 0xA);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_QWORD")]
        public const uint RegQword = unchecked((uint) 0xB);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "REG_QWORD_LITTLE_ENDIAN")]
        public const uint RegQwordLittleEndian = unchecked((uint) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_KERNEL_DRIVER")]
        public const int ServiceKernelDriver = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_FILE_SYSTEM_DRIVER")]
        public const int ServiceFileSystemDriver = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_ADAPTER")]
        public const int ServiceAdapter = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_RECOGNIZER_DRIVER")]
        public const int ServiceRecognizerDriver = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_WIN32_OWN_PROCESS")]
        public const int ServiceWin32OwnProcess = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_WIN32_SHARE_PROCESS")]
        public const int ServiceWin32ShareProcess = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_USER_SERVICE")]
        public const int ServiceUserService = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_USERSERVICE_INSTANCE")]
        public const int ServiceUserserviceInstance = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_INTERACTIVE_PROCESS")]
        public const int ServiceInteractiveProcess = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_PKG_SERVICE")]
        public const int ServicePkgService = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_BOOT_START")]
        public const int ServiceBootStart = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_SYSTEM_START")]
        public const int ServiceSystemStart = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_AUTO_START")]
        public const int ServiceAutoStart = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_DEMAND_START")]
        public const int ServiceDemandStart = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_DISABLED")]
        public const int ServiceDisabled = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_ERROR_IGNORE")]
        public const int ServiceErrorIgnore = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_ERROR_NORMAL")]
        public const int ServiceErrorNormal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_ERROR_SEVERE")]
        public const int ServiceErrorSevere = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SERVICE_ERROR_CRITICAL")]
        public const int ServiceErrorCritical = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_NETWORK_BOOT_LOAD")]
        public const int CMServiceNetworkBootLoad = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD")]
        public const int CMServiceVirtualDiskBootLoad = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_USB_DISK_BOOT_LOAD")]
        public const int CMServiceUsbDiskBootLoad = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_SD_DISK_BOOT_LOAD")]
        public const int CMServiceSDDiskBootLoad = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_USB3_DISK_BOOT_LOAD")]
        public const int CMServiceUsb3DiskBootLoad = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_MEASURED_BOOT_LOAD")]
        public const int CMServiceMeasuredBootLoad = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_VERIFIER_BOOT_LOAD")]
        public const int CMServiceVerifierBootLoad = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_WINPE_BOOT_LOAD")]
        public const int CMServiceWinpeBootLoad = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "CM_SERVICE_RAM_DISK_BOOT_LOAD")]
        public const int CMServiceRamDiskBootLoad = unchecked((int) 0x100);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_ERASE_SHORT")]
        public const int TapeEraseShort = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_ERASE_LONG")]
        public const int TapeEraseLong = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_LOAD")]
        public const int TapeLoad = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_UNLOAD")]
        public const int TapeUnload = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_TENSION")]
        public const int TapeTension = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_LOCK")]
        public const int TapeLock = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_UNLOCK")]
        public const int TapeUnlock = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_FORMAT")]
        public const int TapeFormat = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SETMARKS")]
        public const int TapeSetmarks = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_FILEMARKS")]
        public const int TapeFilemarks = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SHORT_FILEMARKS")]
        public const int TapeShortFilemarks = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_LONG_FILEMARKS")]
        public const int TapeLongFilemarks = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_ABSOLUTE_POSITION")]
        public const int TapeAbsolutePosition = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_LOGICAL_POSITION")]
        public const int TapeLogicalPosition = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_PSEUDO_LOGICAL_POSITION")]
        public const int TapePseudoLogicalPosition = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_REWIND")]
        public const int TapeRewind = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_ABSOLUTE_BLOCK")]
        public const int TapeAbsoluteBlock = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_LOGICAL_BLOCK")]
        public const int TapeLogicalBlock = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_PSEUDO_LOGICAL_BLOCK")]
        public const int TapePseudoLogicalBlock = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_END_OF_DATA")]
        public const int TapeSpaceEndOfData = unchecked((int) 0x4);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_RELATIVE_BLOCKS")]
        public const int TapeSpaceRelativeBlocks = unchecked((int) 0x5);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_FILEMARKS")]
        public const int TapeSpaceFilemarks = unchecked((int) 0x6);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_SEQUENTIAL_FMKS")]
        public const int TapeSpaceSequentialFmks = unchecked((int) 0x7);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_SETMARKS")]
        public const int TapeSpaceSetmarks = unchecked((int) 0x8);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SPACE_SEQUENTIAL_SMKS")]
        public const int TapeSpaceSequentialSmks = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_FIXED")]
        public const int TapeDriveFixed = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_SELECT")]
        public const int TapeDriveSelect = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_INITIATOR")]
        public const int TapeDriveInitiator = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_ERASE_SHORT")]
        public const int TapeDriveEraseShort = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_ERASE_LONG")]
        public const int TapeDriveEraseLong = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_ERASE_BOP_ONLY")]
        public const int TapeDriveEraseBopOnly = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_ERASE_IMMEDIATE")]
        public const int TapeDriveEraseImmediate = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_TAPE_CAPACITY")]
        public const int TapeDriveTapeCapacity = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_TAPE_REMAINING")]
        public const int TapeDriveTapeRemaining = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_FIXED_BLOCK")]
        public const int TapeDriveFixedBlock = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_VARIABLE_BLOCK")]
        public const int TapeDriveVariableBlock = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_PROTECT")]
        public const int TapeDriveWriteProtect = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_EOT_WZ_SIZE")]
        public const int TapeDriveEotWZSize = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_ECC")]
        public const int TapeDriveEcc = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_COMPRESSION")]
        public const int TapeDriveCompression = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_PADDING")]
        public const int TapeDrivePadding = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_REPORT_SMKS")]
        public const int TapeDriveReportSmks = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_GET_ABSOLUTE_BLK")]
        public const int TapeDriveGetAbsoluteBlk = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_GET_LOGICAL_BLK")]
        public const int TapeDriveGetLogicalBlk = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_SET_EOT_WZ_SIZE")]
        public const int TapeDriveSetEotWZSize = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_EJECT_MEDIA")]
        public const int TapeDriveEjectMedia = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_CLEAN_REQUESTS")]
        public const int TapeDriveCleanRequests = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TAPE_DRIVE_SET_CMP_BOP_ONLY")]
        public const int TapeDriveSetCmpBopOnly = unchecked((int) 0x4000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_RESERVED_BIT")]
        public const uint TapeDriveReservedBit = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOAD_UNLOAD")]
        public const uint TapeDriveLoadUnload = unchecked((uint) 0xFFFFFFFF80000001);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_TENSION")]
        public const uint TapeDriveTension = unchecked((uint) 0xFFFFFFFF80000002);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOCK_UNLOCK")]
        public const uint TapeDriveLockUnlock = unchecked((uint) 0xFFFFFFFF80000004);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_REWIND_IMMEDIATE")]
        public const uint TapeDriveRewindImmediate = unchecked((uint) 0xFFFFFFFF80000008);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SET_BLOCK_SIZE")]
        public const uint TapeDriveSetBlockSize = unchecked((uint) 0xFFFFFFFF80000010);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOAD_UNLD_IMMED")]
        public const uint TapeDriveLoadUnldImmed = unchecked((uint) 0xFFFFFFFF80000020);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_TENSION_IMMED")]
        public const uint TapeDriveTensionImmed = unchecked((uint) 0xFFFFFFFF80000040);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOCK_UNLK_IMMED")]
        public const uint TapeDriveLockUnlkImmed = unchecked((uint) 0xFFFFFFFF80000080);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SET_ECC")]
        public const uint TapeDriveSetEcc = unchecked((uint) 0xFFFFFFFF80000100);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SET_COMPRESSION")]
        public const uint TapeDriveSetCompression = unchecked((uint) 0xFFFFFFFF80000200);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SET_PADDING")]
        public const uint TapeDriveSetPadding = unchecked((uint) 0xFFFFFFFF80000400);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SET_REPORT_SMKS")]
        public const uint TapeDriveSetReportSmks = unchecked((uint) 0xFFFFFFFF80000800);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_ABSOLUTE_BLK")]
        public const uint TapeDriveAbsoluteBlk = unchecked((uint) 0xFFFFFFFF80001000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_ABS_BLK_IMMED")]
        public const uint TapeDriveAbsBlkImmed = unchecked((uint) 0xFFFFFFFF80002000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOGICAL_BLK")]
        public const uint TapeDriveLogicalBlk = unchecked((uint) 0xFFFFFFFF80004000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_LOG_BLK_IMMED")]
        public const uint TapeDriveLogBlkImmed = unchecked((uint) 0xFFFFFFFF80008000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_END_OF_DATA")]
        public const uint TapeDriveEndOfData = unchecked((uint) 0xFFFFFFFF80010000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_RELATIVE_BLKS")]
        public const uint TapeDriveRelativeBlks = unchecked((uint) 0xFFFFFFFF80020000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_FILEMARKS")]
        public const uint TapeDriveFilemarks = unchecked((uint) 0xFFFFFFFF80040000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SEQUENTIAL_FMKS")]
        public const uint TapeDriveSequentialFmks = unchecked((uint) 0xFFFFFFFF80080000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SETMARKS")]
        public const uint TapeDriveSetmarks = unchecked((uint) 0xFFFFFFFF80100000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SEQUENTIAL_SMKS")]
        public const uint TapeDriveSequentialSmks = unchecked((uint) 0xFFFFFFFF80200000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_REVERSE_POSITION")]
        public const uint TapeDriveReversePosition = unchecked((uint) 0xFFFFFFFF80400000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_SPACE_IMMEDIATE")]
        public const uint TapeDriveSpaceImmediate = unchecked((uint) 0xFFFFFFFF80800000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_SETMARKS")]
        public const uint TapeDriveWriteSetmarks = unchecked((uint) 0xFFFFFFFF81000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_FILEMARKS")]
        public const uint TapeDriveWriteFilemarks = unchecked((uint) 0xFFFFFFFF82000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_SHORT_FMKS")]
        public const uint TapeDriveWriteShortFmks = unchecked((uint) 0xFFFFFFFF84000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_LONG_FMKS")]
        public const uint TapeDriveWriteLongFmks = unchecked((uint) 0xFFFFFFFF88000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_WRITE_MARK_IMMED")]
        public const uint TapeDriveWriteMarkImmed = unchecked((uint) 0xFFFFFFFF90000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_FORMAT")]
        public const uint TapeDriveFormat = unchecked((uint) 0xFFFFFFFFA0000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_FORMAT_IMMEDIATE")]
        public const uint TapeDriveFormatImmediate = unchecked((uint) 0xFFFFFFFFC0000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "TAPE_DRIVE_HIGH_FEATURES")]
        public const uint TapeDriveHighFeatures = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_FIXED_PARTITIONS")]
        public const int TapeFixedPartitions = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_SELECT_PARTITIONS")]
        public const int TapeSelectPartitions = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_INITIATOR_PARTITIONS")]
        public const int TapeInitiatorPartitions = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_QUERY_DRIVE_PARAMETERS")]
        public const int TapeQueryDriveParameters = unchecked((int) 0x0);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_QUERY_MEDIA_CAPACITY")]
        public const int TapeQueryMediaCapacity = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_CHECK_FOR_DRIVE_PROBLEM")]
        public const int TapeCheckForDriveProblem = unchecked((int) 0x2);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_QUERY_IO_ERROR_DATA")]
        public const int TapeQueryIOErrorData = unchecked((int) 0x3);
        [NativeName("Type", "long")]
        [NativeName("Name", "TAPE_QUERY_DEVICE_ERROR_DATA")]
        public const int TapeQueryDeviceErrorData = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_QUERY_INFORMATION")]
        public const int TransactionmanagerQueryInformation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_SET_INFORMATION")]
        public const int TransactionmanagerSetInformation = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_RECOVER")]
        public const int TransactionmanagerRecover = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_RENAME")]
        public const int TransactionmanagerRename = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_CREATE_RM")]
        public const int TransactionmanagerCreateRM = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTIONMANAGER_BIND_TRANSACTION")]
        public const int TransactionmanagerBindTransaction = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "TRANSACTIONMANAGER_GENERIC_EXECUTE")]
        public const int TransactionmanagerGenericExecute = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_QUERY_INFORMATION")]
        public const int TransactionQueryInformation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_SET_INFORMATION")]
        public const int TransactionSetInformation = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_ENLIST")]
        public const int TransactionEnlist = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_COMMIT")]
        public const int TransactionCommit = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_ROLLBACK")]
        public const int TransactionRollback = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_PROPAGATE")]
        public const int TransactionPropagate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRANSACTION_RIGHT_RESERVED1")]
        public const int TransactionRightReserved1 = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_QUERY_INFORMATION")]
        public const int ResourcemanagerQueryInformation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_SET_INFORMATION")]
        public const int ResourcemanagerSetInformation = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_RECOVER")]
        public const int ResourcemanagerRecover = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_ENLIST")]
        public const int ResourcemanagerEnlist = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_GET_NOTIFICATION")]
        public const int ResourcemanagerGetNotification = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_REGISTER_PROTOCOL")]
        public const int ResourcemanagerRegisterProtocol = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "RESOURCEMANAGER_COMPLETE_PROPAGATION")]
        public const int ResourcemanagerCompletePropagation = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENLISTMENT_QUERY_INFORMATION")]
        public const int EnlistmentQueryInformation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENLISTMENT_SET_INFORMATION")]
        public const int EnlistmentSetInformation = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENLISTMENT_RECOVER")]
        public const int EnlistmentRecover = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENLISTMENT_SUBORDINATE_RIGHTS")]
        public const int EnlistmentSubordinateRights = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENLISTMENT_SUPERIOR_RIGHTS")]
        public const int EnlistmentSuperiorRights = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PcTeb")]
        public const int PcTeb = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION")]
        public const int ActivationContextSectionAssemblyInformation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION")]
        public const int ActivationContextSectionDllRedirection = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION")]
        public const int ActivationContextSectionWindowClassRedirection = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION")]
        public const int ActivationContextSectionComServerRedirection = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION")]
        public const int ActivationContextSectionComInterfaceRedirection = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION")]
        public const int ActivationContextSectionComTypeLibraryRedirection = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION")]
        public const int ActivationContextSectionComProgidRedirection = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE")]
        public const int ActivationContextSectionGlobalObjectRenameTable = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES")]
        public const int ActivationContextSectionClrSurrogates = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS")]
        public const int ActivationContextSectionApplicationSettings = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO")]
        public const int ActivationContextSectionCompatibilityInfo = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES")]
        public const int ActivationContextSectionWinrtActivatableClasses = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "FIND_FIRST_EX_CASE_SENSITIVE")]
        public const int FindFirstEXCaseSensitive = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FIND_FIRST_EX_LARGE_FETCH")]
        public const int FindFirstEXLargeFetch = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY")]
        public const int FindFirstEXOnDiskEntriesOnly = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCKFILE_FAIL_IMMEDIATELY")]
        public const int LockfileFailImmediately = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOCKFILE_EXCLUSIVE_LOCK")]
        public const int LockfileExclusiveLock = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_REGION")]
        public const int ProcessHeapRegion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_UNCOMMITTED_RANGE")]
        public const int ProcessHeapUncommittedRange = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_ENTRY_BUSY")]
        public const int ProcessHeapEntryBusy = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_SEG_ALLOC")]
        public const int ProcessHeapSegAlloc = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_ENTRY_MOVEABLE")]
        public const int ProcessHeapEntryMoveable = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "PROCESS_HEAP_ENTRY_DDESHARE")]
        public const int ProcessHeapEntryDdeshare = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXCEPTION_DEBUG_EVENT")]
        public const int ExceptionDebugEvent = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "CREATE_THREAD_DEBUG_EVENT")]
        public const int CreateThreadDebugEvent = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "CREATE_PROCESS_DEBUG_EVENT")]
        public const int CreateProcessDebugEvent = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXIT_THREAD_DEBUG_EVENT")]
        public const int ExitThreadDebugEvent = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EXIT_PROCESS_DEBUG_EVENT")]
        public const int ExitProcessDebugEvent = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "LOAD_DLL_DEBUG_EVENT")]
        public const int LoadDllDebugEvent = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "UNLOAD_DLL_DEBUG_EVENT")]
        public const int UnloadDllDebugEvent = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "OUTPUT_DEBUG_STRING_EVENT")]
        public const int OutputDebugStringEvent = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "RIP_EVENT")]
        public const int RipEvent = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_FIXED")]
        public const int LmemFixed = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_MOVEABLE")]
        public const int LmemMoveable = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_NOCOMPACT")]
        public const int LmemNocompact = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_NODISCARD")]
        public const int LmemNodiscard = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_ZEROINIT")]
        public const int LmemZeroinit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_MODIFY")]
        public const int LmemModify = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_DISCARDABLE")]
        public const int LmemDiscardable = unchecked((int) 0xF00);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_VALID_FLAGS")]
        public const int LmemValidFlags = unchecked((int) 0xF72);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_INVALID_HANDLE")]
        public const int LmemInvalidHandle = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "NONZEROLHND")]
        public const int Nonzerolhnd = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "NONZEROLPTR")]
        public const int Nonzerolptr = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_DISCARDED")]
        public const int LmemDiscarded = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "LMEM_LOCKCOUNT")]
        public const int LmemLockcount = unchecked((int) 0xFF);
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAMEW")]
        public const string KernelLoggerNamew = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAMEW")]
        public const string GlobalLoggerNamew = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAMEW")]
        public const string EventLoggerNamew = unchecked((string) "EventLog");
        [NativeName("Type", "")]
        [NativeName("Name", "DIAG_LOGGER_NAMEW")]
        public const string DiagLoggerNamew = unchecked((string) "DiagLog");
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAMEA")]
        public const string KernelLoggerNamea = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAMEA")]
        public const string GlobalLoggerNamea = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAMEA")]
        public const string EventLoggerNamea = unchecked((string) "EventLog");
        [NativeName("Type", "")]
        [NativeName("Name", "DIAG_LOGGER_NAMEA")]
        public const string DiagLoggerNamea = unchecked((string) "DiagLog");
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_MOF_FIELDS")]
        public const int MaxMofFields = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_EVENT_TYPE")]
        public const int SystemEventType = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_INFO")]
        public const int EventTraceTypeInfo = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_START")]
        public const int EventTraceTypeStart = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_END")]
        public const int EventTraceTypeEnd = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_STOP")]
        public const int EventTraceTypeStop = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DC_START")]
        public const int EventTraceTypeDCStart = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DC_END")]
        public const int EventTraceTypeDCEnd = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_EXTENSION")]
        public const int EventTraceTypeExtension = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REPLY")]
        public const int EventTraceTypeReply = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DEQUEUE")]
        public const int EventTraceTypeDequeue = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RESUME")]
        public const int EventTraceTypeResume = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CHECKPOINT")]
        public const int EventTraceTypeCheckpoint = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SUSPEND")]
        public const int EventTraceTypeSuspend = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_WINEVT_SEND")]
        public const int EventTraceTypeWinevtSend = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_WINEVT_RECEIVE")]
        public const int EventTraceTypeWinevtReceive = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_NONE")]
        public const int TraceLevelNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_CRITICAL")]
        public const int TraceLevelCritical = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_FATAL")]
        public const int TraceLevelFatal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_ERROR")]
        public const int TraceLevelError = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_WARNING")]
        public const int TraceLevelWarning = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_INFORMATION")]
        public const int TraceLevelInformation = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_VERBOSE")]
        public const int TraceLevelVerbose = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED6")]
        public const int TraceLevelReserved6 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED7")]
        public const int TraceLevelReserved7 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED8")]
        public const int TraceLevelReserved8 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED9")]
        public const int TraceLevelReserved9 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_LOAD")]
        public const int EventTraceTypeLoad = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_TERMINATE")]
        public const int EventTraceTypeTerminate = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_READ")]
        public const int EventTraceTypeIORead = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_WRITE")]
        public const int EventTraceTypeIOWrite = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_READ_INIT")]
        public const int EventTraceTypeIOReadInit = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_WRITE_INIT")]
        public const int EventTraceTypeIOWriteInit = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_FLUSH")]
        public const int EventTraceTypeIOFlush = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_FLUSH_INIT")]
        public const int EventTraceTypeIOFlushInit = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_REDIRECTED_INIT")]
        public const int EventTraceTypeIORedirectedInit = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_TF")]
        public const int EventTraceTypeMMTF = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_DZF")]
        public const int EventTraceTypeMMDzf = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_COW")]
        public const int EventTraceTypeMMCow = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_GPF")]
        public const int EventTraceTypeMMGpf = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_HPF")]
        public const int EventTraceTypeMMHpf = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_AV")]
        public const int EventTraceTypeMMAV = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SEND")]
        public const int EventTraceTypeSend = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RECEIVE")]
        public const int EventTraceTypeReceive = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONNECT")]
        public const int EventTraceTypeConnect = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DISCONNECT")]
        public const int EventTraceTypeDisconnect = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RETRANSMIT")]
        public const int EventTraceTypeRetransmit = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACCEPT")]
        public const int EventTraceTypeAccept = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RECONNECT")]
        public const int EventTraceTypeReconnect = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONNFAIL")]
        public const int EventTraceTypeConnfail = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_COPY_TCP")]
        public const int EventTraceTypeCopyTcp = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_COPY_ARP")]
        public const int EventTraceTypeCopyArp = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKFULL")]
        public const int EventTraceTypeAckfull = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKPART")]
        public const int EventTraceTypeAckpart = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKDUP")]
        public const int EventTraceTypeAckdup = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_GUIDMAP")]
        public const int EventTraceTypeGuidmap = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG")]
        public const int EventTraceTypeConfig = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SIDINFO")]
        public const int EventTraceTypeSidinfo = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SECURITY")]
        public const int EventTraceTypeSecurity = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DBGID_RSDS")]
        public const int EventTraceTypeDbgidRsds = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCREATE")]
        public const int EventTraceTypeRegcreate = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGOPEN")]
        public const int EventTraceTypeRegopen = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGDELETE")]
        public const int EventTraceTypeRegdelete = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERY")]
        public const int EventTraceTypeRegquery = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETVALUE")]
        public const int EventTraceTypeRegsetvalue = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGDELETEVALUE")]
        public const int EventTraceTypeRegdeletevalue = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYVALUE")]
        public const int EventTraceTypeRegqueryvalue = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGENUMERATEKEY")]
        public const int EventTraceTypeRegenumeratekey = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGENUMERATEVALUEKEY")]
        public const int EventTraceTypeRegenumeratevaluekey = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYMULTIPLEVALUE")]
        public const int EventTraceTypeRegquerymultiplevalue = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETINFORMATION")]
        public const int EventTraceTypeRegsetinformation = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGFLUSH")]
        public const int EventTraceTypeRegflush = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBCREATE")]
        public const int EventTraceTypeRegkcbcreate = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBDELETE")]
        public const int EventTraceTypeRegkcbdelete = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBRUNDOWNBEGIN")]
        public const int EventTraceTypeRegkcbrundownbegin = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBRUNDOWNEND")]
        public const int EventTraceTypeRegkcbrundownend = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGVIRTUALIZE")]
        public const int EventTraceTypeRegvirtualize = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCLOSE")]
        public const int EventTraceTypeRegclose = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETSECURITY")]
        public const int EventTraceTypeRegsetsecurity = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYSECURITY")]
        public const int EventTraceTypeRegquerysecurity = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCOMMIT")]
        public const int EventTraceTypeRegcommit = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGPREPARE")]
        public const int EventTraceTypeRegprepare = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGROLLBACK")]
        public const int EventTraceTypeRegrollback = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGMOUNTHIVE")]
        public const int EventTraceTypeRegmounthive = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_CPU")]
        public const int EventTraceTypeConfigCpu = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PHYSICALDISK")]
        public const int EventTraceTypeConfigPhysicaldisk = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_LOGICALDISK")]
        public const int EventTraceTypeConfigLogicaldisk = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NIC")]
        public const int EventTraceTypeConfigNic = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_VIDEO")]
        public const int EventTraceTypeConfigVideo = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_SERVICES")]
        public const int EventTraceTypeConfigServices = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_POWER")]
        public const int EventTraceTypeConfigPower = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NETINFO")]
        public const int EventTraceTypeConfigNetinfo = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_OPTICALMEDIA")]
        public const int EventTraceTypeConfigOpticalmedia = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_IRQ")]
        public const int EventTraceTypeConfigIrq = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PNP")]
        public const int EventTraceTypeConfigPnp = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_IDECHANNEL")]
        public const int EventTraceTypeConfigIdechannel = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NUMANODE")]
        public const int EventTraceTypeConfigNumanode = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PLATFORM")]
        public const int EventTraceTypeConfigPlatform = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSORGROUP")]
        public const int EventTraceTypeConfigProcessorgroup = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSORNUMBER")]
        public const int EventTraceTypeConfigProcessornumber = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DPI")]
        public const int EventTraceTypeConfigDpi = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_CI_INFO")]
        public const int EventTraceTypeConfigCIInfo = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_MACHINEID")]
        public const int EventTraceTypeConfigMachineid = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DEFRAG")]
        public const int EventTraceTypeConfigDefrag = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_MOBILEPLATFORM")]
        public const int EventTraceTypeConfigMobileplatform = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DEVICEFAMILY")]
        public const int EventTraceTypeConfigDevicefamily = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_FLIGHTID")]
        public const int EventTraceTypeConfigFlightid = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSOR")]
        public const int EventTraceTypeConfigProcessor = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_VIRTUALIZATION")]
        public const int EventTraceTypeConfigVirtualization = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_BOOT")]
        public const int EventTraceTypeConfigBoot = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_READ")]
        public const int EventTraceTypeOpticalIORead = unchecked((int) 0x37);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_WRITE")]
        public const int EventTraceTypeOpticalIOWrite = unchecked((int) 0x38);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_FLUSH")]
        public const int EventTraceTypeOpticalIOFlush = unchecked((int) 0x39);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_READ_INIT")]
        public const int EventTraceTypeOpticalIOReadInit = unchecked((int) 0x3A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_WRITE_INIT")]
        public const int EventTraceTypeOpticalIOWriteInit = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_FLUSH_INIT")]
        public const int EventTraceTypeOpticalIOFlushInit = unchecked((int) 0x3C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_INIT")]
        public const int EventTraceTypeFltPreopInit = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_INIT")]
        public const int EventTraceTypeFltPostopInit = unchecked((int) 0x61);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_COMPLETION")]
        public const int EventTraceTypeFltPreopCompletion = unchecked((int) 0x62);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_COMPLETION")]
        public const int EventTraceTypeFltPostopCompletion = unchecked((int) 0x63);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_FAILURE")]
        public const int EventTraceTypeFltPreopFailure = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_FAILURE")]
        public const int EventTraceTypeFltPostopFailure = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROCESS")]
        public const int EventTraceFlagProcess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_THREAD")]
        public const int EventTraceFlagThread = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_IMAGE_LOAD")]
        public const int EventTraceFlagImageLoad = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_IO")]
        public const int EventTraceFlagDiskIO = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_FILE_IO")]
        public const int EventTraceFlagDiskFileIO = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_MEMORY_PAGE_FAULTS")]
        public const int EventTraceFlagMemoryPageFaults = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_MEMORY_HARD_FAULTS")]
        public const int EventTraceFlagMemoryHardFaults = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_NETWORK_TCPIP")]
        public const int EventTraceFlagNetworkTcpip = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_REGISTRY")]
        public const int EventTraceFlagRegistry = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DBGPRINT")]
        public const int EventTraceFlagDbgprint = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROCESS_COUNTERS")]
        public const int EventTraceFlagProcessCounters = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_CSWITCH")]
        public const int EventTraceFlagCswitch = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DPC")]
        public const int EventTraceFlagDpc = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_INTERRUPT")]
        public const int EventTraceFlagInterrupt = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_SYSTEMCALL")]
        public const int EventTraceFlagSystemcall = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_IO_INIT")]
        public const int EventTraceFlagDiskIOInit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_ALPC")]
        public const int EventTraceFlagAlpc = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_SPLIT_IO")]
        public const int EventTraceFlagSplitIO = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DRIVER")]
        public const int EventTraceFlagDriver = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROFILE")]
        public const int EventTraceFlagProfile = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FILE_IO")]
        public const int EventTraceFlagFileIO = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FILE_IO_INIT")]
        public const int EventTraceFlagFileIOInit = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISPATCHER")]
        public const int EventTraceFlagDispatcher = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_VIRTUAL_ALLOC")]
        public const int EventTraceFlagVirtualAlloc = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_VAMAP")]
        public const int EventTraceFlagVamap = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_NO_SYSCONFIG")]
        public const int EventTraceFlagNoSysconfig = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_JOB")]
        public const int EventTraceFlagJob = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DEBUG_EVENTS")]
        public const int EventTraceFlagDebugEvents = unchecked((int) 0x400000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_EXTENSION")]
        public const uint EventTraceFlagExtension = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FORWARD_WMI")]
        public const int EventTraceFlagForwardWmi = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_ENABLE_RESERVE")]
        public const int EventTraceFlagEnableReserve = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_NONE")]
        public const int EventTraceFileModeNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_SEQUENTIAL")]
        public const int EventTraceFileModeSequential = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_CIRCULAR")]
        public const int EventTraceFileModeCircular = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_APPEND")]
        public const int EventTraceFileModeAppend = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_REAL_TIME_MODE")]
        public const int EventTraceRealTimeMode = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_DELAY_OPEN_FILE_MODE")]
        public const int EventTraceDelayOpenFileMode = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_BUFFERING_MODE")]
        public const int EventTraceBufferingMode = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PRIVATE_LOGGER_MODE")]
        public const int EventTracePrivateLoggerMode = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_ADD_HEADER_MODE")]
        public const int EventTraceAddHeaderMode = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_GLOBAL_SEQUENCE")]
        public const int EventTraceUseGlobalSequence = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_LOCAL_SEQUENCE")]
        public const int EventTraceUseLocalSequence = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_RELOG_MODE")]
        public const int EventTraceRelogMode = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_PAGED_MEMORY")]
        public const int EventTraceUsePagedMemory = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_NEWFILE")]
        public const int EventTraceFileModeNewfile = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_PREALLOCATE")]
        public const int EventTraceFileModePreallocate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_NONSTOPPABLE_MODE")]
        public const int EventTraceNonstoppableMode = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_SECURE_MODE")]
        public const int EventTraceSecureMode = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_KBYTES_FOR_SIZE")]
        public const int EventTraceUseKbytesForSize = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PRIVATE_IN_PROC")]
        public const int EventTracePrivateInProc = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_MODE_RESERVED")]
        public const int EventTraceModeReserved = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_NO_PER_PROCESSOR_BUFFERING")]
        public const int EventTraceNoPerProcessorBuffering = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_SYSTEM_LOGGER_MODE")]
        public const int EventTraceSystemLoggerMode = unchecked((int) 0x2000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "EVENT_TRACE_ADDTO_TRIAGE_DUMP")]
        public const uint EventTraceAddtoTriageDump = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_STOP_ON_HYBRID_SHUTDOWN")]
        public const int EventTraceStopOnHybridShutdown = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PERSIST_ON_HYBRID_SHUTDOWN")]
        public const int EventTracePersistOnHybridShutdown = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_INDEPENDENT_SESSION_MODE")]
        public const int EventTraceIndependentSessionMode = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_COMPRESSED_MODE")]
        public const int EventTraceCompressedMode = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_QUERY")]
        public const int EventTraceControlQuery = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_STOP")]
        public const int EventTraceControlStop = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_UPDATE")]
        public const int EventTraceControlUpdate = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_FLUSH")]
        public const int EventTraceControlFlush = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_INCREMENT_FILE")]
        public const int EventTraceControlIncrementFile = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_CONVERT_TO_REALTIME")]
        public const int EventTraceControlConvertToRealtime = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_SEQUENCE")]
        public const int TraceMessageSequence = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_GUID")]
        public const int TraceMessageGuid = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_COMPONENTID")]
        public const int TraceMessageComponentid = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_TIMESTAMP")]
        public const int TraceMessageTimestamp = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_PERFORMANCE_TIMESTAMP")]
        public const int TraceMessagePerformanceTimestamp = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_SYSTEMINFO")]
        public const int TraceMessageSysteminfo = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_POINTER32")]
        public const int TraceMessagePointer32 = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_POINTER64")]
        public const int TraceMessagePointer64 = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_FLAG_MASK")]
        public const int TraceMessageFlagMask = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_PROCTIME")]
        public const int EventTraceUseProctime = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_NOCPUTIME")]
        public const int EventTraceUseNocputime = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_TIMESTAMP")]
        public const int TraceHeaderFlagUseTimestamp = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_TRACED_GUID")]
        public const int TraceHeaderFlagTracedGuid = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_LOG_WNODE")]
        public const int TraceHeaderFlagLogWnode = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_GUID_PTR")]
        public const int TraceHeaderFlagUseGuidPtr = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_MOF_PTR")]
        public const int TraceHeaderFlagUseMofPtr = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_ALPC_KW_GENERAL")]
        public const int SystemAlpcKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_SYSTEM")]
        public const int SystemConfigKWSystem = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_GRAPHICS")]
        public const int SystemConfigKWGraphics = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_STORAGE")]
        public const int SystemConfigKWStorage = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_NETWORK")]
        public const int SystemConfigKWNetwork = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_SERVICES")]
        public const int SystemConfigKWServices = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_PNP")]
        public const int SystemConfigKWPnp = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CONFIG_KW_OPTICAL")]
        public const int SystemConfigKWOptical = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_KW_CONFIG")]
        public const int SystemCpuKWConfig = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_KW_CACHE_FLUSH")]
        public const int SystemCpuKWCacheFlush = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_CPU_KW_SPEC_CONTROL")]
        public const int SystemCpuKWSpecControl = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_HYPERVISOR_KW_PROFILE")]
        public const int SystemHypervisorKWProfile = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_HYPERVISOR_KW_CALLOUTS")]
        public const int SystemHypervisorKWCallouts = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_HYPERVISOR_KW_VTL_CHANGE")]
        public const int SystemHypervisorKWVtlChange = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_GENERAL")]
        public const int SystemInterruptKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_CLOCK_INTERRUPT")]
        public const int SystemInterruptKWClockInterrupt = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_DPC")]
        public const int SystemInterruptKWDpc = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_DPC_QUEUE")]
        public const int SystemInterruptKWDpcQueue = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_WDF_DPC")]
        public const int SystemInterruptKWWdfDpc = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_WDF_INTERRUPT")]
        public const int SystemInterruptKWWdfInterrupt = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_INTERRUPT_KW_IPI")]
        public const int SystemInterruptKWIpi = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_DISK")]
        public const int SystemIOKWDisk = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_DISK_INIT")]
        public const int SystemIOKWDiskInit = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_FILENAME")]
        public const int SystemIOKWFilename = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_SPLIT")]
        public const int SystemIOKWSplit = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_FILE")]
        public const int SystemIOKWFile = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_OPTICAL")]
        public const int SystemIOKWOptical = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_OPTICAL_INIT")]
        public const int SystemIOKWOpticalInit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_DRIVERS")]
        public const int SystemIOKWDrivers = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_CC")]
        public const int SystemIOKWCC = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IO_KW_NETWORK")]
        public const int SystemIOKWNetwork = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IOFILTER_KW_GENERAL")]
        public const int SystemIofilterKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IOFILTER_KW_INIT")]
        public const int SystemIofilterKWInit = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IOFILTER_KW_FASTIO")]
        public const int SystemIofilterKWFastio = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_IOFILTER_KW_FAILURE")]
        public const int SystemIofilterKWFailure = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_LOCK_KW_SPINLOCK")]
        public const int SystemLockKWSpinlock = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_LOCK_KW_SPINLOCK_COUNTERS")]
        public const int SystemLockKWSpinlockCounters = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_LOCK_KW_SYNC_OBJECTS")]
        public const int SystemLockKWSyncObjects = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_GENERAL")]
        public const int SystemMemoryKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_HARD_FAULTS")]
        public const int SystemMemoryKWHardFaults = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_ALL_FAULTS")]
        public const int SystemMemoryKWAllFaults = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_POOL")]
        public const int SystemMemoryKWPool = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_MEMINFO")]
        public const int SystemMemoryKWMeminfo = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_PFSECTION")]
        public const int SystemMemoryKWPfsection = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_MEMINFO_WS")]
        public const int SystemMemoryKWMeminfoWS = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_HEAP")]
        public const int SystemMemoryKWHeap = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_WS")]
        public const int SystemMemoryKWWS = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_CONTMEM_GEN")]
        public const int SystemMemoryKWContmemGen = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_VIRTUAL_ALLOC")]
        public const int SystemMemoryKWVirtualAlloc = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_FOOTPRINT")]
        public const int SystemMemoryKWFootprint = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_SESSION")]
        public const int SystemMemoryKWSession = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_REFSET")]
        public const int SystemMemoryKWRefset = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_VAMAP")]
        public const int SystemMemoryKWVamap = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_KW_NONTRADEABLE")]
        public const int SystemMemoryKWNontradeable = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_OBJECT_KW_GENERAL")]
        public const int SystemObjectKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_OBJECT_KW_HANDLE")]
        public const int SystemObjectKWHandle = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_POWER_KW_GENERAL")]
        public const int SystemPowerKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_POWER_KW_HIBER_RUNDOWN")]
        public const int SystemPowerKWHiberRundown = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_POWER_KW_PROCESSOR_IDLE")]
        public const int SystemPowerKWProcessorIdle = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_POWER_KW_IDLE_SELECTION")]
        public const int SystemPowerKWIdleSelection = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_POWER_KW_PPM_EXIT_LATENCY")]
        public const int SystemPowerKWPpmExitLatency = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_GENERAL")]
        public const int SystemProcessKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_INSWAP")]
        public const int SystemProcessKWInswap = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_FREEZE")]
        public const int SystemProcessKWFreeze = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_PERF_COUNTER")]
        public const int SystemProcessKWPerfCounter = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_WAKE_COUNTER")]
        public const int SystemProcessKWWakeCounter = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_WAKE_DROP")]
        public const int SystemProcessKWWakeDrop = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_WAKE_EVENT")]
        public const int SystemProcessKWWakeEvent = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_DEBUG_EVENTS")]
        public const int SystemProcessKWDebugEvents = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_DBGPRINT")]
        public const int SystemProcessKWDbgprint = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_JOB")]
        public const int SystemProcessKWJob = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_WORKER_THREAD")]
        public const int SystemProcessKWWorkerThread = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_THREAD")]
        public const int SystemProcessKWThread = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROCESS_KW_LOADER")]
        public const int SystemProcessKWLoader = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROFILE_KW_GENERAL")]
        public const int SystemProfileKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_PROFILE_KW_PMC_PROFILE")]
        public const int SystemProfileKWPmcProfile = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_REGISTRY_KW_GENERAL")]
        public const int SystemRegistryKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_REGISTRY_KW_HIVE")]
        public const int SystemRegistryKWHive = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_REGISTRY_KW_NOTIFICATION")]
        public const int SystemRegistryKWNotification = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_XSCHEDULER")]
        public const int SystemSchedulerKWXscheduler = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_DISPATCHER")]
        public const int SystemSchedulerKWDispatcher = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_KERNEL_QUEUE")]
        public const int SystemSchedulerKWKernelQueue = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_SHOULD_YIELD")]
        public const int SystemSchedulerKWShouldYield = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_ANTI_STARVATION")]
        public const int SystemSchedulerKWAntiStarvation = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_LOAD_BALANCER")]
        public const int SystemSchedulerKWLoadBalancer = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_AFFINITY")]
        public const int SystemSchedulerKWAffinity = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_PRIORITY")]
        public const int SystemSchedulerKWPriority = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_IDEAL_PROCESSOR")]
        public const int SystemSchedulerKWIdealProcessor = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_CONTEXT_SWITCH")]
        public const int SystemSchedulerKWContextSwitch = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SCHEDULER_KW_COMPACT_CSWITCH")]
        public const int SystemSchedulerKWCompactCswitch = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_SYSCALL_KW_GENERAL")]
        public const int SystemSyscallKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_TIMER_KW_GENERAL")]
        public const int SystemTimerKWGeneral = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_TIMER_KW_CLOCK_TIMER")]
        public const int SystemTimerKWClockTimer = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_MEMORY_POOL_FILTER_ID")]
        public const int SystemMemoryPoolFilterID = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_NULL_TYPE_VALUE")]
        public const int EtwNullTypeValue = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_OBJECT_TYPE_VALUE")]
        public const int EtwObjectTypeValue = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_STRING_TYPE_VALUE")]
        public const int EtwStringTypeValue = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SBYTE_TYPE_VALUE")]
        public const int EtwSbyteTypeValue = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BYTE_TYPE_VALUE")]
        public const int EtwByteTypeValue = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT16_TYPE_VALUE")]
        public const int EtwInt16TypeValue = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT16_TYPE_VALUE")]
        public const int EtwUint16TypeValue = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT32_TYPE_VALUE")]
        public const int EtwInt32TypeValue = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT32_TYPE_VALUE")]
        public const int EtwUint32TypeValue = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT64_TYPE_VALUE")]
        public const int EtwInt64TypeValue = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT64_TYPE_VALUE")]
        public const int EtwUint64TypeValue = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_CHAR_TYPE_VALUE")]
        public const int EtwCharTypeValue = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SINGLE_TYPE_VALUE")]
        public const int EtwSingleTypeValue = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DOUBLE_TYPE_VALUE")]
        public const int EtwDoubleTypeValue = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BOOLEAN_TYPE_VALUE")]
        public const int EtwBooleanTypeValue = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DECIMAL_TYPE_VALUE")]
        public const int EtwDecimalTypeValue = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_GUID_TYPE_VALUE")]
        public const int EtwGuidTypeValue = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_ASCIICHAR_TYPE_VALUE")]
        public const int EtwAsciicharTypeValue = unchecked((int) 0x66);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_ASCIISTRING_TYPE_VALUE")]
        public const int EtwAsciistringTypeValue = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_COUNTED_STRING_TYPE_VALUE")]
        public const int EtwCountedStringTypeValue = unchecked((int) 0x68);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_POINTER_TYPE_VALUE")]
        public const int EtwPointerTypeValue = unchecked((int) 0x69);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SIZET_TYPE_VALUE")]
        public const int EtwSizetTypeValue = unchecked((int) 0x6A);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_HIDDEN_TYPE_VALUE")]
        public const int EtwHiddenTypeValue = unchecked((int) 0x6B);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BOOL_TYPE_VALUE")]
        public const int EtwBoolTypeValue = unchecked((int) 0x6C);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_COUNTED_ANSISTRING_TYPE_VALUE")]
        public const int EtwCountedAnsistringTypeValue = unchecked((int) 0x6D);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REVERSED_COUNTED_STRING_TYPE_VALUE")]
        public const int EtwReversedCountedStringTypeValue = unchecked((int) 0x6E);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REVERSED_COUNTED_ANSISTRING_TYPE_VALUE")]
        public const int EtwReversedCountedAnsistringTypeValue = unchecked((int) 0x6F);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_NON_NULL_TERMINATED_STRING_TYPE_VALUE")]
        public const int EtwNonNullTerminatedStringTypeValue = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REDUCED_ANSISTRING_TYPE_VALUE")]
        public const int EtwReducedAnsistringTypeValue = unchecked((int) 0x71);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REDUCED_STRING_TYPE_VALUE")]
        public const int EtwReducedStringTypeValue = unchecked((int) 0x72);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SID_TYPE_VALUE")]
        public const int EtwSidTypeValue = unchecked((int) 0x73);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_VARIANT_TYPE_VALUE")]
        public const int EtwVariantTypeValue = unchecked((int) 0x74);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_PTVECTOR_TYPE_VALUE")]
        public const int EtwPtvectorTypeValue = unchecked((int) 0x75);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_WMITIME_TYPE_VALUE")]
        public const int EtwWmitimeTypeValue = unchecked((int) 0x76);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DATETIME_TYPE_VALUE")]
        public const int EtwDatetimeTypeValue = unchecked((int) 0x77);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REFRENCE_TYPE_VALUE")]
        public const int EtwRefrenceTypeValue = unchecked((int) 0x78);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_PROVIDER_FLAG_LEGACY")]
        public const int TraceProviderFlagLegacy = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_PROVIDER_FLAG_PRE_ENABLE")]
        public const int TraceProviderFlagPreEnable = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_DISABLE_PROVIDER")]
        public const int EventControlCodeDisableProvider = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_ENABLE_PROVIDER")]
        public const int EventControlCodeEnableProvider = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_CAPTURE_STATE")]
        public const int EventControlCodeCaptureState = unchecked((int) 0x2);
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAME")]
        public const string KernelLoggerName = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAME")]
        public const string GlobalLoggerName = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAME")]
        public const string EventLoggerName = unchecked((string) "EventLog");
        [NativeName("Type", "int")]
        [NativeName("Name", "ENABLE_TRACE_PARAMETERS_VERSION")]
        public const int EnableTraceParametersVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENABLE_TRACE_PARAMETERS_VERSION_2")]
        public const int EnableTraceParametersVersion2 = unchecked((int) 0x2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public partial uint StartTraceW(ref ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW", Convention = CallingConvention.Winapi)]
        public partial uint StartTraceW(ref ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public partial uint StartTraceA(ref ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA", Convention = CallingConvention.Winapi)]
        public partial uint StartTraceA(ref ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public partial uint StopTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW", Convention = CallingConvention.Winapi)]
        public partial uint StopTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public partial uint StopTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint StopTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA", Convention = CallingConvention.Winapi)]
        public partial uint StopTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public partial uint QueryTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW", Convention = CallingConvention.Winapi)]
        public partial uint QueryTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public partial uint QueryTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA", Convention = CallingConvention.Winapi)]
        public partial uint QueryTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public partial uint UpdateTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW", Convention = CallingConvention.Winapi)]
        public partial uint UpdateTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public partial uint UpdateTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA", Convention = CallingConvention.Winapi)]
        public partial uint UpdateTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public partial uint FlushTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW", Convention = CallingConvention.Winapi)]
        public partial uint FlushTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public partial uint FlushTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA", Convention = CallingConvention.Winapi)]
        public partial uint FlushTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public partial uint ControlTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW", Convention = CallingConvention.Winapi)]
        public partial uint ControlTraceW(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public partial uint ControlTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA", Convention = CallingConvention.Winapi)]
        public partial uint ControlTraceA(ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesW(EventTraceProperties** PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesW(EventTraceProperties** PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesW(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesW(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesA(EventTraceProperties** PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesA(EventTraceProperties** PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesA(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryAllTracesA(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1865, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTrace(uint Enable, uint EnableFlag, uint EnableLevel, Guid* ControlGuid, ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1865, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTrace", Convention = CallingConvention.Winapi)]
        public partial uint EnableTrace(uint Enable, uint EnableFlag, uint EnableLevel, ref Guid ControlGuid, ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx", Convention = CallingConvention.Winapi)]
        public partial uint EnableTraceEx(ref Guid ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, ref EnableTraceParameters EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, ref Guid ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2", Convention = CallingConvention.Winapi)]
        public partial uint EnableTraceEx2(ulong TraceHandle, ref Guid ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, ref EnableTraceParameters EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuidsEx<T0, T1>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx", Convention = CallingConvention.Winapi)]
        public partial uint EnumerateTraceGuidsEx<T0, T1>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2350, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceSetInformation", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceSetInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2350, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceSetInformation", Convention = CallingConvention.Winapi)]
        public partial uint TraceSetInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceQueryInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceQueryInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceQueryInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation", Convention = CallingConvention.Winapi)]
        public partial uint TraceQueryInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateTraceInstanceId(void* RegHandle, EventInstanceInfo* InstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateTraceInstanceId(void* RegHandle, ref EventInstanceInfo InstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateTraceInstanceId<T0>(ref T0 RegHandle, EventInstanceInfo* InstInfo) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId", Convention = CallingConvention.Winapi)]
        public partial uint CreateTraceInstanceId<T0>(ref T0 RegHandle, ref EventInstanceInfo InstInfo) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2402, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEvent(ulong TraceHandle, EventTraceHeader* EventTrace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2402, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEvent", Convention = CallingConvention.Winapi)]
        public partial uint TraceEvent(ulong TraceHandle, ref EventTraceHeader EventTrace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, ref EventInstanceInfo InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, ref EventInstanceInfo InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, EventInstanceInfo* InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, ref EventInstanceInfo InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance", Convention = CallingConvention.Winapi)]
        public partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, ref EventInstanceInfo InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA", Convention = CallingConvention.Winapi)]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuids(TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, uint* GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuids(TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, ref uint GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuids(ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, uint* GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateTraceGuids(ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, ref uint GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2501, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UnregisterTraceGuids", Convention = CallingConvention.Winapi)]
        public partial uint UnregisterTraceGuids(ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2508, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceLoggerHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetTraceLoggerHandle(void* Buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2508, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceLoggerHandle", Convention = CallingConvention.Winapi)]
        public partial ulong GetTraceLoggerHandle<T0>(ref T0 Buffer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2515, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceEnableLevel", Convention = CallingConvention.Winapi)]
        public partial byte GetTraceEnableLevel(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceEnableFlags", Convention = CallingConvention.Winapi)]
        public partial uint GetTraceEnableFlags(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceW", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong OpenTraceW(EventTraceLogfilew* Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceW", Convention = CallingConvention.Winapi)]
        public partial ulong OpenTraceW(ref EventTraceLogfilew Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, Filetime* StartTime, Filetime* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, Filetime* StartTime, ref Filetime EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, ref Filetime StartTime, Filetime* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, ref Filetime StartTime, ref Filetime EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, Filetime* StartTime, Filetime* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, Filetime* StartTime, ref Filetime EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, ref Filetime StartTime, Filetime* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace", Convention = CallingConvention.Winapi)]
        public partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, ref Filetime StartTime, ref Filetime EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2566, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CloseTrace", Convention = CallingConvention.Winapi)]
        public partial uint CloseTrace(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public unsafe partial uint QueryTraceProcessingHandle<T0, T1>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle", Convention = CallingConvention.Winapi)]
        public partial uint QueryTraceProcessingHandle<T0, T1>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceA", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong OpenTraceA(EventTraceLogfilea* Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceA", Convention = CallingConvention.Winapi)]
        public partial ulong OpenTraceA(ref EventTraceLogfilea Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2637, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "SetTraceCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial uint SetTraceCallback(Guid* pGuid, PfnPeventCallback EventCallback);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2637, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "SetTraceCallback", Convention = CallingConvention.Winapi)]
        public partial uint SetTraceCallback(ref Guid pGuid, PfnPeventCallback EventCallback);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2645, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RemoveTraceCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial uint RemoveTraceCallback(Guid* pGuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2645, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RemoveTraceCallback", Convention = CallingConvention.Winapi)]
        public partial uint RemoveTraceCallback(ref Guid pGuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2662, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessage", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceMessage(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2662, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessage", Convention = CallingConvention.Winapi)]
        public partial uint TraceMessage(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, byte* MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, ref byte MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, byte* MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, ref byte MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa", Convention = CallingConvention.Winapi)]
        public partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string MessageArgList);


        public Windows(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

