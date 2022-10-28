using System.Globalization;

namespace Optional.Utilities;

/// <summary>
/// A collection of static helper methods, for parsing strings into simple types.
/// </summary>
public static class Parse
{
#if NETSTANDARD2_1 || NET6_0_OR_GREATER

    /// <summary>
    /// Tries to parse a string into a byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<byte> ToByte(ReadOnlySpan<char> chars)
    {
        return byte.TryParse(chars, out byte result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<byte> ToByte(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return byte.TryParse(chars, styles, provider, out byte result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a signed byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<sbyte> ToSByte(ReadOnlySpan<char> chars)
    {
        return sbyte.TryParse(chars, out sbyte result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a signed byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<sbyte> ToSByte(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return sbyte.TryParse(chars, styles, provider, out sbyte result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<short> ToShort(ReadOnlySpan<char> chars)
    {
        return short.TryParse(chars, out short result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<short> ToShort(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return short.TryParse(chars, styles, provider, out short result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ushort> ToUShort(ReadOnlySpan<char> chars)
    {
        return ushort.TryParse(chars, out ushort result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ushort> ToUShort(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return ushort.TryParse(chars, styles, provider, out ushort result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<int> ToInt(ReadOnlySpan<char> chars)
    {
        return int.TryParse(chars, out int result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<int> ToInt(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return int.TryParse(chars, styles, provider, out int result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<uint> ToUInt(ReadOnlySpan<char> chars)
    {
        return uint.TryParse(chars, out uint result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<uint> ToUInt(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return uint.TryParse(chars, styles, provider, out uint result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<long> ToLong(ReadOnlySpan<char> chars)
    {
        return long.TryParse(chars, out long result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<long> ToLong(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return long.TryParse(chars, styles, provider, out long result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ulong> ToULong(ReadOnlySpan<char> chars)
    {
        return ulong.TryParse(chars, out ulong result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ulong> ToULong(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return ulong.TryParse(chars, styles, provider, out ulong result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a float.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<float> ToFloat(ReadOnlySpan<char> chars)
    {
        return float.TryParse(chars, out float result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a float.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<float> ToFloat(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return float.TryParse(chars, styles, provider, out float result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a double.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<double> ToDouble(ReadOnlySpan<char> chars)
    {
        return double.TryParse(chars, out double result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a double.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<double> ToDouble(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return double.TryParse(chars, styles, provider, out double result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a decimal.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<decimal> ToDecimal(ReadOnlySpan<char> chars)
    {
        return decimal.TryParse(chars, out decimal result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a decimal.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<decimal> ToDecimal(ReadOnlySpan<char> chars, IFormatProvider provider, NumberStyles styles)
    {
        return decimal.TryParse(chars, styles, provider, out decimal result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a bool.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<bool> ToBool(ReadOnlySpan<char> chars)
    {
        return bool.TryParse(chars, out bool result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a char.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<char> ToChar(ReadOnlySpan<char> chars)
    {
        return chars.Length == 1 ? chars[0].Some() : Option<char>.None;
    }

    /// <summary>
    /// Tries to parse a string into a guid.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<Guid> ToGuid(ReadOnlySpan<char> chars)
    {
        return Guid.TryParse(chars, out Guid result) ? result.Some() : result.None();
    }

#if NET6_0_OR_GREATER

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(ReadOnlySpan<char> chars) where TEnum : struct, Enum
    {
        return Enum.TryParse<TEnum>(chars, out TEnum result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(ReadOnlySpan<char> chars, bool ignoreCase) where TEnum : struct, Enum
    {
        return Enum.TryParse<TEnum>(chars, ignoreCase, out TEnum result) ? result.Some() : result.None();
    }

#else

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(string chars) where TEnum : struct, Enum
    {
        return Enum.TryParse<TEnum>(chars, out TEnum result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(string chars, bool ignoreCase) where TEnum : struct, Enum
    {
        return Enum.TryParse<TEnum>(chars, ignoreCase, out TEnum result) ? result.Some() : result.None();
    }

#endif

    /// <summary>
    /// Tries to parse a string into a datetime.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTime(ReadOnlySpan<char> chars)
    {
        return DateTime.TryParse(chars, out DateTime result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTime(ReadOnlySpan<char> chars, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTime.TryParse(chars, provider, styles, out DateTime result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTimeExact(ReadOnlySpan<char> chars, string format, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTime.TryParseExact(chars, format, provider, styles, out DateTime result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTimeExact(ReadOnlySpan<char> chars, string[] formats, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTime.TryParseExact(chars, formats, provider, styles, out DateTime result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpan(ReadOnlySpan<char> chars)
    {
        return TimeSpan.TryParse(chars, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpan(ReadOnlySpan<char> chars, IFormatProvider provider)
    {
        return TimeSpan.TryParse(chars, provider, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(ReadOnlySpan<char> chars, string format, IFormatProvider provider)
    {
        return TimeSpan.TryParseExact(chars, format, provider, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(ReadOnlySpan<char> chars, string[] formats, IFormatProvider provider)
    {
        return TimeSpan.TryParseExact(chars, formats, provider, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(ReadOnlySpan<char> chars, string format, IFormatProvider provider, TimeSpanStyles styles)
    {
        return TimeSpan.TryParseExact(chars, format, provider, styles, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(ReadOnlySpan<char> chars, string[] formats, IFormatProvider provider, TimeSpanStyles styles)
    {
        return TimeSpan.TryParseExact(chars, formats, provider, styles, out TimeSpan result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffset(ReadOnlySpan<char> chars)
    {
        return DateTimeOffset.TryParse(chars, out DateTimeOffset result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffset(ReadOnlySpan<char> chars, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTimeOffset.TryParse(chars, provider, styles, out DateTimeOffset result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffsetExact(ReadOnlySpan<char> chars, string format, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTimeOffset.TryParseExact(chars, format, provider, styles, out DateTimeOffset result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffsetExact(ReadOnlySpan<char> chars, string[] formats, IFormatProvider provider, DateTimeStyles styles)
    {
        return DateTimeOffset.TryParseExact(chars, formats, provider, styles, out DateTimeOffset result) ? result.Some() : result.None();
    }

#else

    /// <summary>
    /// Tries to parse a string into a byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<byte> ToByte(string s)
    {
        byte result;
        return byte.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<byte> ToByte(string s, IFormatProvider provider, NumberStyles styles)
    {
        byte result;
        return byte.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a signed byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<sbyte> ToSByte(string s)
    {
        sbyte result;
        return sbyte.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a signed byte.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<sbyte> ToSByte(string s, IFormatProvider provider, NumberStyles styles)
    {
        sbyte result;
        return sbyte.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<short> ToShort(string s)
    {
        short result;
        return short.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<short> ToShort(string s, IFormatProvider provider, NumberStyles styles)
    {
        short result;
        return short.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ushort> ToUShort(string s)
    {
        ushort result;
        return ushort.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned short.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ushort> ToUShort(string s, IFormatProvider provider, NumberStyles styles)
    {
        ushort result;
        return ushort.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<int> ToInt(string s)
    {
        int result;
        return int.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<int> ToInt(string s, IFormatProvider provider, NumberStyles styles)
    {
        int result;
        return int.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<uint> ToUInt(string s)
    {
        uint result;
        return uint.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned int.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<uint> ToUInt(string s, IFormatProvider provider, NumberStyles styles)
    {
        uint result;
        return uint.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<long> ToLong(string s)
    {
        long result;
        return long.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<long> ToLong(string s, IFormatProvider provider, NumberStyles styles)
    {
        long result;
        return long.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ulong> ToULong(string s)
    {
        ulong result;
        return ulong.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an unsigned long.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    [CLSCompliant(false)]
    public static Option<ulong> ToULong(string s, IFormatProvider provider, NumberStyles styles)
    {
        ulong result;
        return ulong.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a float.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<float> ToFloat(string s)
    {
        float result;
        return float.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a float.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<float> ToFloat(string s, IFormatProvider provider, NumberStyles styles)
    {
        float result;
        return float.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a double.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<double> ToDouble(string s)
    {
        double result;
        return double.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a double.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<double> ToDouble(string s, IFormatProvider provider, NumberStyles styles)
    {
        double result;
        return double.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a decimal.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<decimal> ToDecimal(string s)
    {
        decimal result;
        return decimal.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a decimal.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<decimal> ToDecimal(string s, IFormatProvider provider, NumberStyles styles)
    {
        decimal result;
        return decimal.TryParse(s, styles, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a bool.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<bool> ToBool(string s)
    {
        bool result;
        return bool.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a char.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<char> ToChar(string s)
    {
        char result;
        return char.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a guid.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<Guid> ToGuid(string s)
    {
        Guid result;
        return Guid.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(string s) where TEnum : struct
    {
        TEnum result;
        return Enum.TryParse<TEnum>(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into an enum.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TEnum> ToEnum<TEnum>(string s, bool ignoreCase) where TEnum : struct
    {
        TEnum result;
        return Enum.TryParse<TEnum>(s, ignoreCase, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTime(string s)
    {
        DateTime result;
        return DateTime.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTime(string s, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTime result;
        return DateTime.TryParse(s, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTimeExact(string s, string format, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTime result;
        return DateTime.TryParseExact(s, format, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTime> ToDateTimeExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTime result;
        return DateTime.TryParseExact(s, formats, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpan(string s)
    {
        TimeSpan result;
        return TimeSpan.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpan(string s, IFormatProvider provider)
    {
        TimeSpan result;
        return TimeSpan.TryParse(s, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(string s, string format, IFormatProvider provider)
    {
        TimeSpan result;
        return TimeSpan.TryParseExact(s, format, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(string s, string[] formats, IFormatProvider provider)
    {
        TimeSpan result;
        return TimeSpan.TryParseExact(s, formats, provider, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(string s, string format, IFormatProvider provider, TimeSpanStyles styles)
    {
        TimeSpan result;
        return TimeSpan.TryParseExact(s, format, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a timespan with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<TimeSpan> ToTimeSpanExact(string s, string[] formats, IFormatProvider provider, TimeSpanStyles styles)
    {
        TimeSpan result;
        return TimeSpan.TryParseExact(s, formats, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffset(string s)
    {
        DateTimeOffset result;
        return DateTimeOffset.TryParse(s, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffset(string s, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTimeOffset result;
        return DateTimeOffset.TryParse(s, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffsetExact(string s, string format, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTimeOffset result;
        return DateTimeOffset.TryParseExact(s, format, provider, styles, out result) ? result.Some() : result.None();
    }

    /// <summary>
    /// Tries to parse a string into a datetime offset with a specific format.
    /// </summary>
    /// <returns>An optional value containing the result if any.</returns>
    public static Option<DateTimeOffset> ToDateTimeOffsetExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles)
    {
        DateTimeOffset result;
        return DateTimeOffset.TryParseExact(s, formats, provider, styles, out result) ? result.Some() : result.None();
    }

#endif
}
