using System.Text;

namespace Example;

public class Code
{
    public string? ClassName;

    public string? FieldName;

    public string? FieldType;

    private const int indentSize = 2;

    public List<Code> Fields = new List<Code>();

    public Code(string className)
    {
        ClassName = className;
    }

    public Code(string fieldName, string fieldType)
    {
        FieldName = fieldName;
        FieldType = fieldType;
    }

    public string ToStringImpl()
    {
        var sb = new StringBuilder();

        sb.Append($"public class {ClassName}\n" + "{\n");

        var i = new string(' ', indentSize);

        Fields.ForEach(child =>
        {
            sb.Append($"{i}public {child.FieldType} {child.FieldName};\n");
        });

        sb.Append("}");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl();
    }
}