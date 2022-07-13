namespace test_actions;

public class TestModel
{
    public string GetValue() => "abcde";
    
    public string? String1 { get; init; }
    
    public int GetLength() => String1.Length;
    
    public Action<string> Predicate { get; set; }
    
    public void FireAction(string? message) => Predicate(message);
}
