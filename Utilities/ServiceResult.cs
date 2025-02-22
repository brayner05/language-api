namespace languages_app.Utilities;

public class ServiceResult <T> (T? value, bool success) {
    public T? Value { get; private set; } = value;

    public bool Success { get; set; } = success;
}