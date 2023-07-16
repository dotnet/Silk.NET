// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='InputScope.xml' path='doc/member[@name="InputScope"]/*'/>
public enum InputScope
{
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DEFAULT"]/*'/>
    IS_DEFAULT = 0,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_URL"]/*'/>
    IS_URL = 1,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_FILE_FULLFILEPATH"]/*'/>
    IS_FILE_FULLFILEPATH = 2,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_FILE_FILENAME"]/*'/>
    IS_FILE_FILENAME = 3,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_EMAIL_USERNAME"]/*'/>
    IS_EMAIL_USERNAME = 4,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_EMAIL_SMTPEMAILADDRESS"]/*'/>
    IS_EMAIL_SMTPEMAILADDRESS = 5,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_LOGINNAME"]/*'/>
    IS_LOGINNAME = 6,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_FULLNAME"]/*'/>
    IS_PERSONALNAME_FULLNAME = 7,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_PREFIX"]/*'/>
    IS_PERSONALNAME_PREFIX = 8,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_GIVENNAME"]/*'/>
    IS_PERSONALNAME_GIVENNAME = 9,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_MIDDLENAME"]/*'/>
    IS_PERSONALNAME_MIDDLENAME = 10,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_SURNAME"]/*'/>
    IS_PERSONALNAME_SURNAME = 11,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PERSONALNAME_SUFFIX"]/*'/>
    IS_PERSONALNAME_SUFFIX = 12,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_FULLPOSTALADDRESS"]/*'/>
    IS_ADDRESS_FULLPOSTALADDRESS = 13,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_POSTALCODE"]/*'/>
    IS_ADDRESS_POSTALCODE = 14,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_STREET"]/*'/>
    IS_ADDRESS_STREET = 15,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_STATEORPROVINCE"]/*'/>
    IS_ADDRESS_STATEORPROVINCE = 16,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_CITY"]/*'/>
    IS_ADDRESS_CITY = 17,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_COUNTRYNAME"]/*'/>
    IS_ADDRESS_COUNTRYNAME = 18,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ADDRESS_COUNTRYSHORTNAME"]/*'/>
    IS_ADDRESS_COUNTRYSHORTNAME = 19,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CURRENCY_AMOUNTANDSYMBOL"]/*'/>
    IS_CURRENCY_AMOUNTANDSYMBOL = 20,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CURRENCY_AMOUNT"]/*'/>
    IS_CURRENCY_AMOUNT = 21,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_FULLDATE"]/*'/>
    IS_DATE_FULLDATE = 22,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_MONTH"]/*'/>
    IS_DATE_MONTH = 23,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_DAY"]/*'/>
    IS_DATE_DAY = 24,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_YEAR"]/*'/>
    IS_DATE_YEAR = 25,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_MONTHNAME"]/*'/>
    IS_DATE_MONTHNAME = 26,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DATE_DAYNAME"]/*'/>
    IS_DATE_DAYNAME = 27,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_DIGITS"]/*'/>
    IS_DIGITS = 28,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NUMBER"]/*'/>
    IS_NUMBER = 29,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ONECHAR"]/*'/>
    IS_ONECHAR = 30,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PASSWORD"]/*'/>
    IS_PASSWORD = 31,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TELEPHONE_FULLTELEPHONENUMBER"]/*'/>
    IS_TELEPHONE_FULLTELEPHONENUMBER = 32,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TELEPHONE_COUNTRYCODE"]/*'/>
    IS_TELEPHONE_COUNTRYCODE = 33,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TELEPHONE_AREACODE"]/*'/>
    IS_TELEPHONE_AREACODE = 34,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TELEPHONE_LOCALNUMBER"]/*'/>
    IS_TELEPHONE_LOCALNUMBER = 35,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TIME_FULLTIME"]/*'/>
    IS_TIME_FULLTIME = 36,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TIME_HOUR"]/*'/>
    IS_TIME_HOUR = 37,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TIME_MINORSEC"]/*'/>
    IS_TIME_MINORSEC = 38,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NUMBER_FULLWIDTH"]/*'/>
    IS_NUMBER_FULLWIDTH = 39,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ALPHANUMERIC_HALFWIDTH"]/*'/>
    IS_ALPHANUMERIC_HALFWIDTH = 40,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ALPHANUMERIC_FULLWIDTH"]/*'/>
    IS_ALPHANUMERIC_FULLWIDTH = 41,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CURRENCY_CHINESE"]/*'/>
    IS_CURRENCY_CHINESE = 42,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_BOPOMOFO"]/*'/>
    IS_BOPOMOFO = 43,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_HIRAGANA"]/*'/>
    IS_HIRAGANA = 44,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_KATAKANA_HALFWIDTH"]/*'/>
    IS_KATAKANA_HALFWIDTH = 45,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_KATAKANA_FULLWIDTH"]/*'/>
    IS_KATAKANA_FULLWIDTH = 46,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_HANJA"]/*'/>
    IS_HANJA = 47,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_HANGUL_HALFWIDTH"]/*'/>
    IS_HANGUL_HALFWIDTH = 48,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_HANGUL_FULLWIDTH"]/*'/>
    IS_HANGUL_FULLWIDTH = 49,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_SEARCH"]/*'/>
    IS_SEARCH = 50,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_FORMULA"]/*'/>
    IS_FORMULA = 51,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_SEARCH_INCREMENTAL"]/*'/>
    IS_SEARCH_INCREMENTAL = 52,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CHINESE_HALFWIDTH"]/*'/>
    IS_CHINESE_HALFWIDTH = 53,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CHINESE_FULLWIDTH"]/*'/>
    IS_CHINESE_FULLWIDTH = 54,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NATIVE_SCRIPT"]/*'/>
    IS_NATIVE_SCRIPT = 55,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_YOMI"]/*'/>
    IS_YOMI = 56,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_TEXT"]/*'/>
    IS_TEXT = 57,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CHAT"]/*'/>
    IS_CHAT = 58,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NAME_OR_PHONENUMBER"]/*'/>
    IS_NAME_OR_PHONENUMBER = 59,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_EMAILNAME_OR_ADDRESS"]/*'/>
    IS_EMAILNAME_OR_ADDRESS = 60,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PRIVATE"]/*'/>
    IS_PRIVATE = 61,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_MAPS"]/*'/>
    IS_MAPS = 62,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NUMERIC_PASSWORD"]/*'/>
    IS_NUMERIC_PASSWORD = 63,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_NUMERIC_PIN"]/*'/>
    IS_NUMERIC_PIN = 64,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ALPHANUMERIC_PIN"]/*'/>
    IS_ALPHANUMERIC_PIN = 65,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ALPHANUMERIC_PIN_SET"]/*'/>
    IS_ALPHANUMERIC_PIN_SET = 66,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_FORMULA_NUMBER"]/*'/>
    IS_FORMULA_NUMBER = 67,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_CHAT_WITHOUT_EMOJI"]/*'/>
    IS_CHAT_WITHOUT_EMOJI = 68,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_PHRASELIST"]/*'/>
    IS_PHRASELIST = -1,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_REGULAREXPRESSION"]/*'/>
    IS_REGULAREXPRESSION = -2,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_SRGS"]/*'/>
    IS_SRGS = -3,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_XML"]/*'/>
    IS_XML = -4,
    /// <include file='InputScope.xml' path='doc/member[@name="InputScope.IS_ENUMSTRING"]/*'/>
    IS_ENUMSTRING = -5,
}