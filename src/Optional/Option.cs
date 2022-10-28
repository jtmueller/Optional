namespace Optional;

/// <summary>
/// Provides a set of functions for creating optional values.
/// </summary>
public static class Option
{
    /// <summary>
    /// Wraps an existing value in an <see cref="Option{T}"/> instance.
    /// </summary>
    /// <param name="value">The value to be wrapped.</param>
    /// <returns>An optional containing the specified value.</returns>
    public static Option<T> Some<T>(T value) => new Option<T>(value, true);

    /// <summary>
    /// Wraps an existing value in an <see cref="Option{T, TException}"/> instance.
    /// </summary>
    /// <param name="value">The value to be wrapped.</param>
    /// <returns>An optional containing the specified value.</returns>
    public static Option<T, TException> Some<T, TException>(T value) =>
        new Option<T, TException>(value, default!, true);

    /// <summary>
    /// Creates an empty <see cref="Option{T}"/> instance.
    /// </summary>
    /// <returns>An empty optional.</returns>
    public static Option<T> None<T>() => Option<T>.None;

    /// <summary>
    /// Creates an empty <see cref="Option{T, TException}"/> instance, 
    /// with a specified exceptional value.
    /// </summary>
    /// <param name="exception">The exceptional value.</param>
    /// <returns>An empty optional.</returns>
    public static Option<T, TException> None<T, TException>(TException exception) =>
        new Option<T, TException>(default!, exception, false);
}
