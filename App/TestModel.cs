using System.Text;

namespace test_actions;

public class TestModel
{
    public string GetValue() => "abcde";
    
    public string? String1 { get; init; }
    
    public int GetLength() => String1.Length;
    
    public Action<string> Predicate { get; set; }
    
    public void FireAction(string? message) => Predicate(message);

    private Dictionary<string, string> _dic = new ();

    public string GetValue(string key)
        => _dic.ContainsKey(key) ? _dic[key] : string.Empty;
    
    public string GenerateString()
    {
        var result = new List<string>();

        for (var i = 0; i < 10; i++)
        {
            var builder = new StringBuilder();
            builder.AppendLine("number: " + i);
            result.Add(builder.ToString());
        }

        return string.Join(", ", result);
    }
}
