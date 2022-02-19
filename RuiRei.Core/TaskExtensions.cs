namespace RuiRei.Core;

internal static class TaskExtensions
{
    public static Task<T> ToTask<T>(this T value) => Task.FromResult(value);

    public static async Task<T> WithDelay<T>(this Task<T> value, TimeSpan delay)
    {
        await Task.Delay(delay);
        return await value;
    }
}
